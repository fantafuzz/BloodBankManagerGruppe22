Imports MySql.Data.MySqlClient
'This class is used for all SQL-interaction.
'Spørsmål? Skal vi bruke en "public" versjon av denne, som vi lager i form1? Eller skal vi konstruere en egen i hver?

'Dette er en klasse for all SQL tilkobling. Vi har valgt å ha en klasse for SQL tilkobling siden det gir en god oversikt for alle sql deklareringer istedenfor å deklarere hver og en sql syntax i hver og en form.
Public Class SQL_hookup
    Private salt As String = "detteErEnVeldigLangHashSomGjorAtVaarePassordBlirMyeSikrere"
    Private username As String = "g_oops_22"
    Private password As String = "BtUDpVoR"
    Private databasename As String = "g_oops_22"
    Private server As String = "mysql.stud.iie.ntnu.no"

    'Her kan vi legge inn brukernavn/passord osv, og ikke ha det i constructoren. Men det kan være lurt å ha det åpent i constructor, så kan vi ha den menyen for å
    '   legge inn database fra programmet.

    Private connstring As String
    Private connection As New MySqlConnection()

    Public Sub New() 'Default connecter den til databasen.
        connstring = "Server=" & server & ";" & "Database=" & databasename & ";" & "Uid=" & username & ";" & "Pwd=" & password & ";"
        connection.ConnectionString = connstring
    End Sub
    Public Sub New(ByVal uname As String, pword As String, dbname As String, sv As String) 'Eller så kan du koble til en ny database
        username = uname
        password = pword
        databasename = dbname
        server = sv

        connstring = "Server=" & server & ";" & "Database=" & databasename & ";" & "Uid=" & username & ";" & "Pwd=" & password & ";"
        connection.ConnectionString = connstring
    End Sub

    Private Function hash(passord As String, salt As String) As String
        'Hash for å sikre passord
        Dim hashObject = New Security.Cryptography.SHA256Managed()
        Dim bytes = System.Text.Encoding.ASCII.GetBytes(passord & salt)
        bytes = hashObject.ComputeHash(bytes)

        Dim hexString As String = ""
        For Each aByte In bytes
            hexString &= aByte.ToString("x2")
        Next

        Return hexString
    End Function
    Public Function Query(ByVal sql As String) As DataTable
        Dim table As New DataTable
        Try
            connection.Open()


            Dim command As New MySqlCommand(sql, connection)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            da.Fill(table)

            connection.Close()

        Catch ex As MySqlException
            MsgBox("En feil oppstått i 'Public Function Query', i 'SQL-hookub.vb' klassen: " & ex.Message)
        End Try
        Return table
    End Function

    Public Function logInnSql(ByVal epost As String, ByVal passord As String, ByVal type As String) As Tuple(Of Integer, String)
        Dim e = epost
        Dim p = hash(passord, salt)
        Dim fail As Boolean = False

        Select Case type 'Forskjell mellom å logge inn som ansatt eller som blodgiver.
            Case "ansatt"
                Try
                    connection.Open()
                    Dim sqlLogInn As New MySqlCommand("SELECT bruker_id, ansatt_type FROM bruker, ansatt WHERE bruker.epost = @epost AND bruker.passord = @passord AND bruker.bruker_id = ansatt.ansatt_bruker_id", connection)
                    sqlLogInn.Parameters.AddWithValue("@epost", e)
                    sqlLogInn.Parameters.AddWithValue("@passord", p)
                    Dim reader As MySqlDataReader = sqlLogInn.ExecuteReader
                    If reader.HasRows Then
                        reader.Read()
                        Dim bruker_id As Integer = reader("bruker_id")
                        Dim ansatt_type As String = CStr(reader("ansatt_type"))
                        Return Tuple.Create(bruker_id, ansatt_type) 'Returnerer en tuple, som har (bruker_id, ansatt_type). Dette er for å kunne spesifisere hvilken bruker_id, og om det er administrasjon eller vanlig ansatt.
                    Else
                        fail = True
                    End If
                Catch ex As MySqlException
                    MsgBox("Feil ved tilkobling av databasen: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            Case "bruker"
                Try
                    connection.Open()
                    Dim sqlLogInn As New MySqlCommand("SELECT bruker_id, personnummer FROM bruker, blodgiver WHERE bruker.epost = @epost AND bruker.passord = @passord AND bruker.bruker_id = blodgiver.blodgiver_bruker_id", connection)
                    sqlLogInn.Parameters.AddWithValue("@epost", e)
                    sqlLogInn.Parameters.AddWithValue("@passord", p)
                    Dim reader As MySqlDataReader = sqlLogInn.ExecuteReader
                    If reader.HasRows Then
                        reader.Read()
                        Dim bruker_id As Integer = reader("bruker_id")
                        Dim personnummer As String = reader("personnummer")
                        Return Tuple.Create(bruker_id, personnummer)
                    Else
                        fail = True
                    End If
                Catch ex As MySqlException
                    MsgBox("Feil ved tilkobling av database: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            Case Else
                MsgBox("Fikse koden din. Om du ser denne er ikke koden riktig.")
                Return Tuple.Create(-1, "feil")
        End Select

        If fail Then
            Return Tuple.Create(-1, "feil")
        End If
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Public Sub registrerAnsatt(ByVal fornavn As String, ByVal etternavn As String, ByVal epost As String, ByVal passord As String, ByVal ansatttype As Integer)
        Dim hashedPassord = hash(passord, salt)
        Try
            connection.Open()
            Dim sqlAddBruker As New MySqlCommand("INSERT INTO bruker (fornavn, etternavn, epost, passord) VALUES (@fornavn, @etternavn, @epost, @passord)", connection)
            sqlAddBruker.Parameters.AddWithValue("@fornavn", fornavn)
            sqlAddBruker.Parameters.AddWithValue("@etternavn", etternavn)
            sqlAddBruker.Parameters.AddWithValue("@epost", epost)
            sqlAddBruker.Parameters.AddWithValue("@passord", hashedPassord)
            sqlAddBruker.ExecuteNonQuery()

            Dim sqlAddAnsatt As New MySqlCommand("INSERT INTO ansatt (ansatt_type, ansatt_bruker_id) VALUES (@ansatt_type, (SELECT MAX(bruker_id) FROM bruker WHERE fornavn = @fornavn AND etternavn = @etternavn AND epost = @epost))", connection)
            sqlAddAnsatt.Parameters.AddWithValue("@fornavn", fornavn)
            sqlAddAnsatt.Parameters.AddWithValue("@etternavn", etternavn)
            sqlAddAnsatt.Parameters.AddWithValue("@epost", epost)
            sqlAddAnsatt.Parameters.AddWithValue("@ansatt_type", ansatttype)
            sqlAddAnsatt.ExecuteNonQuery()
        Catch ex As mysqlException
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub registrerNy(ByVal fornavn As String, ByVal etternavn As String, ByVal epost As String, ByVal passord As String, ByVal fodselsdato As String, ByVal personnummer As String, ByVal adresse As String, ByVal postnummer As Integer, ByVal poststed As String, ByVal telefonnummerEn As String, ByVal telefonnummerTo As String, ByVal kjonn As String, ByVal blodtype As Integer, ByVal blodgivningLokasjon As String, ByVal blodbefore As Boolean, ByVal hvilkenBlodbank As String, ByVal samtykke As Boolean, ByVal infoRodekors As Boolean)
        Dim hashedPassord = hash(passord, salt)

        Try
            connection.Open()
            Dim sqlAddBruker As New MySqlCommand("INSERT INTO bruker (fornavn, etternavn, epost, passord) values (@fornavn, @etternavn, @epost, @passord)", connection)
            sqlAddBruker.Parameters.AddWithValue("@fornavn", fornavn)
            sqlAddBruker.Parameters.AddWithValue("@etternavn", etternavn)
            sqlAddBruker.Parameters.AddWithValue("@epost", epost)
            sqlAddBruker.Parameters.AddWithValue("@passord", hashedPassord)
            sqlAddBruker.ExecuteNonQuery()

            Dim sqlAddBlodgiver As New MySqlCommand("INSERT INTO blodgiver (blodgiver_bruker_id, fodselsdato, personnummer, adresse, postnr, poststed, telefon_1, telefon_2, kjonn, blodgiver_blodtype_id, onsket_lok, gitt_for, hvor_gitt, samtykke_for, modta_rode_kors) values ((SELECT bruker_id FROM bruker WHERE fornavn = @fornavn AND etternavn = @etternavn AND epost = @epost), @fodselsdato, @personnummer, @adresse, @postnr, @poststed, @telefonnummerEn, @telefonnummerTo, @kjonn, (SELECT blodtype_id FROM blodtype WHERE blodtype_id = @blodtype), @onsket_lok, @gitt_for, @hvor_gitt, @samtykke_for, @modta_rode_kors)", connection)
            sqlAddBlodgiver.Parameters.AddWithValue("@fornavn", fornavn)
            sqlAddBlodgiver.Parameters.AddWithValue("@etternavn", etternavn)
            sqlAddBlodgiver.Parameters.AddWithValue("@epost", epost)
            sqlAddBlodgiver.Parameters.AddWithValue("@fodselsdato", fodselsdato)
            sqlAddBlodgiver.Parameters.AddWithValue("@personnummer", personnummer)
            sqlAddBlodgiver.Parameters.AddWithValue("@adresse", adresse)
            sqlAddBlodgiver.Parameters.AddWithValue("@postnr", postnummer)
            sqlAddBlodgiver.Parameters.AddWithValue("@poststed", poststed)
            sqlAddBlodgiver.Parameters.AddWithValue("@telefonnummerEn", telefonnummerEn)
            sqlAddBlodgiver.Parameters.AddWithValue("@telefonnummerTo", telefonnummerTo)
            sqlAddBlodgiver.Parameters.AddWithValue("@kjonn", kjonn)
            sqlAddBlodgiver.Parameters.AddWithValue("@blodtype", blodtype)
            sqlAddBlodgiver.Parameters.AddWithValue("@onsket_lok", blodgivningLokasjon)
            sqlAddBlodgiver.Parameters.AddWithValue("@gitt_for", blodbefore)
            sqlAddBlodgiver.Parameters.AddWithValue("@hvor_gitt", hvilkenBlodbank)
            sqlAddBlodgiver.Parameters.AddWithValue("@samtykke_for", samtykke)
            sqlAddBlodgiver.Parameters.AddWithValue("@modta_rode_kors", infoRodekors)
            sqlAddBlodgiver.ExecuteNonQuery()

        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Sub tapping(ByVal bruker)
        Dim currdate As Date = Date.Today()
        Try
            connection.Open()
            Dim sqlendring As New MySqlCommand("INSERT INTO blodbeholdning_endring (dato, endring_aarsak, endring_mengde, endring_blodbeholdning_id) VALUES (@dato, @aarsak, @mengde, (SELECT blodbeholdning.beholdningstype_id FROM blodbeholdning, blodgiver WHERE blodbeholdning.beholdningstype_id = blodgiver.blodgiver_blodtype_id AND blodgiver.blodgiver_bruker_id = @bruker))", connection)
            sqlendring.Parameters.AddWithValue("@dato", currdate)
            sqlendring.Parameters.AddWithValue("@aarsak", "Blodtapping")
            sqlendring.Parameters.AddWithValue("@mengde", 400)
            sqlendring.Parameters.AddWithValue("@bruker", bruker)
            sqlendring.ExecuteNonQuery()

            Dim sqltapping As New MySqlCommand("INSERT INTO blodtapping (tapping_bruker_id, tapping_endring_id) VALUES ((SELECT bruker_id FROM bruker WHERE bruker_id = @bruker),(SELECT MAX(endring_id) FROM blodbeholdning_endring WHERE endring_aarsak = @aarsak AND endring_mengde = @mengde AND dato = @dato AND endring_blodbeholdning_id = (SELECT blodbeholdning.beholdningstype_id FROM blodbeholdning, blodgiver WHERE blodgiver.blodgiver_blodtype_id = blodbeholdning.beholdningstype_id AND blodgiver.blodgiver_bruker_id = @bruker)))", connection)
            sqltapping.Parameters.AddWithValue("@aarsak", "Blodtapping")
            sqltapping.Parameters.AddWithValue("@mengde", 400)
            sqltapping.Parameters.AddWithValue("@dato", currdate)
            sqltapping.Parameters.AddWithValue("@bruker", bruker)
            sqltapping.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub sendHelsesjekk(ByVal bruker_id As Integer, ByVal status As Boolean)
        Dim currDate As Date = Date.Today

        Try
            connection.Open()
            Dim sqlSend As New MySqlCommand("INSERT INTO helsesjekk (godkjent_status, dato, helsesjekk_bruker_id) VALUES (@status, @dato, (SELECT blodgiver_bruker_id FROM blodgiver WHERE blodgiver_bruker_id = @bruker_id))", connection)
            sqlSend.Parameters.AddWithValue("@status", status)
            sqlSend.Parameters.AddWithValue("@dato", currDate)
            sqlSend.Parameters.AddWithValue("@bruker_id", bruker_id)
            sqlSend.ExecuteNonQuery()
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub bestillTime(ByVal bruker_id As Integer, ByVal info As String, ByVal dato As String)
        Try
            connection.Open()
            Dim sqlBestill As New MySqlCommand("INSERT INTO time_bestilling (bestilling_bruker_id, dato, info) values ((SELECT blodgiver_bruker_id FROM blodgiver WHERE blodgiver_bruker_id = @bruker_id), @dato, @info)", connection)
            sqlBestill.Parameters.AddWithValue("@bruker_id", bruker_id)
            sqlBestill.Parameters.AddWithValue("@dato", dato)
            sqlBestill.Parameters.AddWithValue("@info", info)
            sqlBestill.ExecuteNonQuery()
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub MottaUtleverBlod(ByVal mengde As Integer, id As Integer)
        Dim currDate As Date = Date.Today()
        Try
            connection.Open()
            Dim sqlUtlever As New MySqlCommand("INSERT INTO blodbeholdning_endring (dato, endring_aarsak, endring_mengde, endring_blodbeholdning_id) VALUES (@dato, @aarsak, @mengde, (SELECT beholdningstype_id FROM blodbeholdning WHERE beholdningstype_id = @id))", connection)
            sqlUtlever.Parameters.AddWithValue("@dato", currDate)
            sqlUtlever.Parameters.AddWithValue("@aarsak", "Utlevering")
            sqlUtlever.Parameters.AddWithValue("@mengde", mengde)
            sqlUtlever.Parameters.AddWithValue("@id", id)
            sqlUtlever.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            connection.Close()
        End Try
    End Sub
    Public Sub SendSvar(ByVal currentUser As Integer, ByVal svar As Hashtable, ByVal evt As String)
        Dim currDate As Date = Date.Now
        Try
            connection.Open()
            Dim sqlSendSvar As New MySqlCommand("INSERT INTO egenerklaeringsskjema(skjema_bruker_id, dato, tillat_epost, tillat_sms, evt_info, 1_1, 1_2, 1_3, 1_4, 1_5, 1_6, 2_1, 2_2, 2_3, 2_4, 2_5, 3_1, 3_2, 3_3, 3_4, 3_5, 3_6, 3_7, 4_1, 4_2, 4_3, 4_4, 4_5, 4_6, 4_7, 4_8, 4_9, 4_10, 5_1, 6_1, 6_2, 6_3, 6_4, 6_5, 6_6, 6_7, 6_8, 6_9, 6_10, 6_11, 6_12, 6_13, 6_14, 6_15, 7_1, 7_2, 7_3, 7_4, 8_1, 9_1, 9_2, 9_3, 9_4, 9_5, 9_6, 9_7, 9_8, 9_9, 9_10) VALUES ((SELECT blodgiver_bruker_id FROM blodgiver WHERE blodgiver_bruker_id = @currentuser), @dato, @tillat_epost, @tillat_sms, @evt_info, @1_1, @1_2, @1_3, @1_4, @1_5, @1_6, @2_1, @2_2, @2_3, @2_4, @2_5, @3_1, @3_2, @3_3, @3_4, @3_5, @3_6, @3_7, @4_1, @4_2, @4_3, @4_4, @4_5, @4_6, @4_7, @4_8, @4_9, @4_10, @5_1, @6_1, @6_2, @6_3, @6_4, @6_5, @6_6, @6_7, @6_8, @6_9, @6_10, @6_11, @6_12, @6_13, @6_14, @6_15, @7_1, @7_2, @7_3, @7_4, @8_1, @9_1, @9_2, @9_3, @9_4, @9_5, @9_6, @9_7, @9_8, @9_9, @9_10)", connection)
            sqlSendSvar.Parameters.AddWithValue("@currentuser", currentUser)
            sqlSendSvar.Parameters.AddWithValue("@dato", currDate)
            sqlSendSvar.Parameters.AddWithValue("@tillat_epost", svar(60))
            sqlSendSvar.Parameters.AddWithValue("@tillat_sms", svar(61))
            sqlSendSvar.Parameters.AddWithValue("@evt_info", evt)
            sqlSendSvar.Parameters.AddWithValue("@1_1", svar(1))
            sqlSendSvar.Parameters.AddWithValue("@1_2", svar(2))
            sqlSendSvar.Parameters.AddWithValue("@1_3", svar(3))
            sqlSendSvar.Parameters.AddWithValue("@1_4", svar(4))
            sqlSendSvar.Parameters.AddWithValue("@1_5", svar(5))
            sqlSendSvar.Parameters.AddWithValue("@1_6", svar(6))
            sqlSendSvar.Parameters.AddWithValue("@2_1", svar(7))
            sqlSendSvar.Parameters.AddWithValue("@2_2", svar(8))
            sqlSendSvar.Parameters.AddWithValue("@2_3", svar(9))
            sqlSendSvar.Parameters.AddWithValue("@2_4", svar(10))
            sqlSendSvar.Parameters.AddWithValue("@2_5", svar(11))
            sqlSendSvar.Parameters.AddWithValue("@3_1", svar(12))
            sqlSendSvar.Parameters.AddWithValue("@3_2", svar(13))
            sqlSendSvar.Parameters.AddWithValue("@3_3", svar(14))
            sqlSendSvar.Parameters.AddWithValue("@3_4", svar(15))
            sqlSendSvar.Parameters.AddWithValue("@3_5", svar(16))
            sqlSendSvar.Parameters.AddWithValue("@3_6", svar(17))
            sqlSendSvar.Parameters.AddWithValue("@3_7", svar(18))
            sqlSendSvar.Parameters.AddWithValue("@4_1", svar(19))
            sqlSendSvar.Parameters.AddWithValue("@4_2", svar(20))
            sqlSendSvar.Parameters.AddWithValue("@4_3", svar(21))
            sqlSendSvar.Parameters.AddWithValue("@4_4", svar(22))
            sqlSendSvar.Parameters.AddWithValue("@4_5", svar(23))
            sqlSendSvar.Parameters.AddWithValue("@4_6", svar(24))
            sqlSendSvar.Parameters.AddWithValue("@4_7", svar(25))
            sqlSendSvar.Parameters.AddWithValue("@4_8", svar(26))
            sqlSendSvar.Parameters.AddWithValue("@4_9", svar(27))
            sqlSendSvar.Parameters.AddWithValue("@4_10", svar(28))
            sqlSendSvar.Parameters.AddWithValue("@5_1", svar(29))
            sqlSendSvar.Parameters.AddWithValue("@6_1", svar(30))
            sqlSendSvar.Parameters.AddWithValue("@6_2", svar(31))
            sqlSendSvar.Parameters.AddWithValue("@6_3", svar(32))
            sqlSendSvar.Parameters.AddWithValue("@6_4", svar(33))
            sqlSendSvar.Parameters.AddWithValue("@6_5", svar(34))
            sqlSendSvar.Parameters.AddWithValue("@6_6", svar(35))
            sqlSendSvar.Parameters.AddWithValue("@6_7", svar(36))
            sqlSendSvar.Parameters.AddWithValue("@6_8", svar(37))
            sqlSendSvar.Parameters.AddWithValue("@6_9", svar(38))
            sqlSendSvar.Parameters.AddWithValue("@6_10", svar(39))
            sqlSendSvar.Parameters.AddWithValue("@6_11", svar(40))
            sqlSendSvar.Parameters.AddWithValue("@6_12", svar(41))
            sqlSendSvar.Parameters.AddWithValue("@6_13", svar(42))
            sqlSendSvar.Parameters.AddWithValue("@6_14", svar(43))
            sqlSendSvar.Parameters.AddWithValue("@6_15", svar(44))
            sqlSendSvar.Parameters.AddWithValue("@7_1", svar(45))
            sqlSendSvar.Parameters.AddWithValue("@7_2", svar(46))
            sqlSendSvar.Parameters.AddWithValue("@7_3", svar(47))
            sqlSendSvar.Parameters.AddWithValue("@7_4", svar(48))
            sqlSendSvar.Parameters.AddWithValue("@8_1", svar(49))
            sqlSendSvar.Parameters.AddWithValue("@9_1", svar(50))
            sqlSendSvar.Parameters.AddWithValue("@9_2", svar(51))
            sqlSendSvar.Parameters.AddWithValue("@9_3", svar(52))
            sqlSendSvar.Parameters.AddWithValue("@9_4", svar(53))
            sqlSendSvar.Parameters.AddWithValue("@9_5", svar(54))
            sqlSendSvar.Parameters.AddWithValue("@9_6", svar(55))
            sqlSendSvar.Parameters.AddWithValue("@9_7", svar(56))
            sqlSendSvar.Parameters.AddWithValue("@9_8", svar(57))
            sqlSendSvar.Parameters.AddWithValue("@9_9", svar(58))
            sqlSendSvar.Parameters.AddWithValue("@9_10", svar(59))
            sqlSendSvar.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Function getNavn(ByVal currentUser As Integer) As String
        Dim fornavn As String = "Hvis du ser dette, har du gjort noe feil."
        Try
            connection.Open()
            Dim sqlGetNavn As New MySqlCommand("SELECT fornavn FROM bruker WHERE bruker_id = @id", connection)
            sqlGetNavn.Parameters.AddWithValue("@id", currentUser)
            Dim reader As MySqlDataReader = sqlGetNavn.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                fornavn = reader("fornavn")
            End If
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
        Return fornavn
    End Function
    Public Function getKjonn(ByVal currentuser As Integer) As String
        Dim kjonn As String = "Hvis du ser dette, har noe galt hendt."
        Try
            connection.Open()
            Dim sqlGetKjonn As New MySqlCommand("SELECT kjonn FROM blodgiver WHERE blodgiver_bruker_id = @id", connection)
            sqlGetKjonn.Parameters.AddWithValue("@id", currentuser)
            Dim reader As MySqlDataReader = sqlGetKjonn.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                kjonn = reader("kjonn")
            End If
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
        Return kjonn
    End Function

    Public Function getByBlodgiverId(ByVal currentuser As Integer, ByVal what As String) As String
        Dim returnstring As String = "Noe galt har skjedd"
        Try
            connection.Open()
            Dim sqlGet As New MySqlCommand("SELECT @what FROM blodgiver WHERE blodgiver_bruker_id = @id", connection)
            sqlGet.Parameters.AddWithValue("@what", what)
            sqlGet.Parameters.AddWithValue("@id", currentuser)
            Dim reader As MySqlDataReader = sqlGet.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                returnstring = reader(what)
            End If
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
        Return returnstring
    End Function

    Public Function getSisteEgenerklaering(ByVal bruker_id As Integer)
        Dim returnTable As New DataTable()
        Dim returnRow As DataRow
        Try
            connection.Open()
            Dim sqlGet As New MySqlCommand("SELECT * FROM egenerklaeringsskjema WHERE skjema_bruker_id = @id AND skjema_id = (SELECT MAX(skjema_id) FROM egenerklaeringsskjema WHERE skjema_bruker_id = @id)", connection)
            sqlGet.Parameters.AddWithValue("@id", bruker_id)
            Dim adapter As New MySqlDataAdapter(sqlGet)
            adapter.Fill(returnTable)
            If returnTable IsNot Nothing AndAlso returnTable.Rows.Count > 0 Then
                returnRow = returnTable.Rows(0)
            End If
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
    End Function

    Public Function FilterData(ByVal valueToSearch As String) As DataTable
        Dim returntable As New DataTable
        Dim value As String = "%" & valueToSearch & "%"
        Try
            connection.Open()
            Dim sqlFilterData As New MySqlCommand("SELECT bruker.bruker_id, bruker.fornavn, bruker.etternavn, blodgiver.personnummer FROM bruker, blodgiver WHERE bruker.bruker_id = blodgiver.blodgiver_bruker_id AND CONCAT(bruker.bruker_id, bruker.fornavn, bruker.etternavn, blodgiver.personnummer, bruker.epost) LIKE @value;", connection)
            sqlFilterData.Parameters.AddWithValue("@value", value)
            Dim adapter As New MySqlDataAdapter(sqlFilterData)
            adapter.Fill(returntable)
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try

        Return returntable
    End Function
    Public Function getBlodprodukter() As DataTable
        Dim returntable As New DataTable
        Try
            connection.Open()
            Dim sqlGet As New MySqlCommand("SELECT blodbeholdning.beholdningstype_id AS id, blodbeholdning.beholdningstype_navn AS Type, SUM(blodbeholdning_endring.endring_mengde) AS Mengde FROM blodbeholdning JOIN blodbeholdning_endring ON blodbeholdning.beholdningstype_id = blodbeholdning_endring.endring_blodbeholdning_id GROUP BY blodbeholdning.beholdningstype_id, blodbeholdning.beholdningstype_navn", connection)
            Dim adapter As New MySqlDataAdapter(sqlGet)
            adapter.Fill(returntable)
        Catch ex As Exception

        Finally
            connection.Close()
        End Try
        Return returntable
    End Function
    Public Function getLabSvar(ByVal bruker_id As Integer)
        Dim returntable As New DataTable
        Try
            connection.Open()
            Dim sqlgetLab As New MySqlCommand("SELECT test_utfort, svar FROM lab_svar WHERE svar_bruker_id = @bruker_id", connection)
            sqlgetLab.Parameters.AddWithValue("@bruker_id", bruker_id)
            Dim adapter As New MySqlDataAdapter(sqlgetLab)
            adapter.Fill(returntable)
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try

        Return returntable
    End Function

    Public Function getSisteBlodgivning(ByVal bruker_id As Integer)
        Dim returnstring As String = ""
        Try
            connection.Open()
            Dim sqlgetTapping As New MySqlCommand("SELECT MAX(blodbeholdning_endring.dato) AS Dato FROM blodbeholdning_endring, blodtapping WHERE blodtapping.tapping_bruker_id = @bruker_id AND blodtapping.tapping_endring_id = blodbeholdning_endring.dato", connection)
            sqlgetTapping.Parameters.AddWithValue("bruker_id", bruker_id)
            Dim reader As MySqlDataReader = sqlgetTapping.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                If Not reader("Dato").GetType Is GetType(DBNull) Then
                    returnstring = reader("Dato")
                End If
            End If
        Finally
            connection.Close()
        End Try
        Return returnstring
    End Function

    Public Function getAllinfo(ByVal bruker_id As Integer)
        Dim returntable As New DataTable
        Dim returnrow As DataRow
        Try
            connection.Open()
            Dim sqlgetAll As New MySqlCommand("SELECT bruker.bruker_id, bruker.fornavn, bruker.etternavn, bruker.epost, blodgiver.adresse, blodgiver.postnr, blodgiver.poststed, blodgiver.telefon_1, blodgiver.telefon_2 FROM blodgiver, bruker WHERE blodgiver.blodgiver_bruker_id = bruker.bruker_id AND bruker.bruker_id = @bruker_id", connection)
            sqlgetAll.Parameters.AddWithValue("@bruker_id", bruker_id)
            Dim adapter As New MySqlDataAdapter(sqlgetAll)
            adapter.Fill(returntable)
            returnrow = returntable.Rows(0)
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        Return returnrow
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
    End Function

    Public Function getAntallTapp() As DataTable
        Dim returntable As New DataTable
        Try
            connection.Open()
            Dim sqlgetTapp As New MySqlCommand("SELECT dato, count(endring_id) AS 'Antall tappinger' FROM blodbeholdning_endring WHERE endring_aarsak = 'Blodtapping' GROUP BY dato ORDER BY dato DESC", connection)
            Dim adapter As New MySqlDataAdapter(sqlgetTapp)
            adapter.Fill(returntable)
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
        Return returntable
    End Function

    Public Function getTappByBlodgiver() As DataTable
        Dim returntable As New DataTable
        Try
            connection.Open()
            Dim sqlGetByBlodgiver As New MySqlCommand("SELECT tapping_bruker_id AS 'Bruker ID', COUNT(tapping_bruker_id) AS 'Antall tappinger' FROM blodtapping GROUP BY tapping_bruker_id", connection)
            Dim adapter As New MySqlDataAdapter(sqlGetByBlodgiver)
            adapter.Fill(returntable)
        Catch ex As mysqlException
        Finally
            connection.Close()
        End Try
        Return returntable
    End Function

    Public Function getAnsatte(ByVal valueToSearch As String) As DataTable
        Dim returntable As New DataTable
        Dim value As String = "%" & valueToSearch & "%"
        Try
            connection.Open()
            Dim sqlgetAnsatte As New MySqlCommand("SELECT bruker.bruker_id, bruker.fornavn, bruker.etternavn, ansatt.ansatt_type FROM bruker, ansatt WHERE bruker.bruker_id = ansatt.ansatt_bruker_id AND CONCAT(bruker.fornavn, bruker.etternavn, bruker.epost) LIKE @value;", connection)
            sqlgetAnsatte.Parameters.AddWithValue("@value", value)
            Dim adapter As New MySqlDataAdapter(sqlgetAnsatte)
            adapter.Fill(returntable)
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try

        Return returntable

    End Function
    'DELETE FROM ansatt WHERE ansatt_bruker_id = 1; DELETE FROM bruker WHERE bruker_id = 1;

    Public Sub fjernAnsatt(ByVal bruker_id As Integer)
        Try
            connection.Open()
            Dim sqlFjernAnsatt As New MySqlCommand("DELETE FROM ansatt WHERE ansatt_bruker_id = @bruker_id; DELETE FROM bruker WHERE bruker_id = @bruker_id;", connection)
            sqlFjernAnsatt.Parameters.AddWithValue("bruker_id", bruker_id)
            sqlFjernAnsatt.ExecuteNonQuery()
        Catch ex As mysqlException
        Finally
            connection.Close()
        End Try
    End Sub
    Public Sub endreSingleBruker(ByVal bruker_id As Integer, ByVal field As String, ByVal value As String)
        Try
            connection.Open()
            Dim sqlendre As MySqlCommand
            If field = "adresse" Then
                sqlendre = New MySqlCommand("UPDATE blodgiver SET adresse = @value WHERE blodgiver_bruker_id = @bruker_id;", connection)
            ElseIf field = "postnr" Then
                sqlendre = New MySqlCommand("UPDATE blodgiver SET postnr = @value WHERE blodgiver_bruker_id = @bruker_id;", connection)
            ElseIf field = "poststed" Then
                sqlendre = New MySqlCommand("UPDATE blodgiver SET poststed = @value WHERE blodgiver_bruker_id = @bruker_id;", connection)
            ElseIf field = "telefon_1" Then
                sqlendre = New MySqlCommand("UPDATE blodgiver SET telefon_1 = @value WHERE blodgiver_bruker_id = @bruker_id;", connection)
            ElseIf field = "telefon_2" Then
                sqlendre = New MySqlCommand("UPDATE blodgiver SET telefon_2 = @value WHERE blodgiver_bruker_id = @bruker_id;", connection)
            ElseIf field = "fornavn" Then
                sqlendre = New MySqlCommand("UPDATE bruker SET fornavn = @value WHERE bruker_id = @bruker_id;", connection)
            ElseIf field = "etternavn" Then
                sqlendre = New MySqlCommand("UPDATE bruker SET etternavn = @value WHERE bruker_id = @bruker_id;", connection)
            ElseIf field = "epost" Then
                sqlendre = New MySqlCommand("UPDATE bruker SET epost = @value WHERE bruker_id = @bruker_id;", connection)
            Else
                MsgBox("What")
                connection.Close()
                Exit Sub
            End If
            sqlendre.Parameters.AddWithValue("@value", value)
            sqlendre.Parameters.AddWithValue("@bruker_id", bruker_id)
            sqlendre.ExecuteNonQuery()
        Catch ex As MySqlException
        Finally
            connection.Close()
        End Try
    End Sub
End Class
