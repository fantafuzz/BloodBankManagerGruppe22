Imports MySql.Data.MySqlClient
'This class is used for all SQL-interaction.
'Spørsmål? Skal vi bruke en "public" versjon av denne, som vi lager i form1? Eller skal vi konstruere en egen i hver?
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

    Public Sub New()
        connstring = "Server=" & server & ";" & "Database=" & databasename & ";" & "Uid=" & username & ";" & "Pwd=" & password & ";"
        connection.ConnectionString = connstring
    End Sub
    Public Sub New(ByVal uname As String, pword As String, dbname As String, sv As String)
        username = uname
        password = pword
        databasename = dbname
        server = sv

        connstring = "Server=" & server & ";" & "Database=" & databasename & ";" & "Uid=" & username & ";" & "Pwd=" & password & ";"
        connection.ConnectionString = connstring
    End Sub

    Private Function hash(passord As String, salt As String) As String
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

        Select Case type
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
                        Return Tuple.Create(bruker_id, ansatt_type)
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
    Public Sub SendSvar(ByVal currentUser As Integer, ByVal svar As ArrayList, ByVal evt As String)
        Dim currDate As Date = Date.Now
        Dim currDateString As String = currDate.ToString("YYYY-mm-dd")
        Try
            connection.Open()
            Dim sqlSendSvar As New MySqlCommand("INSERT INTO egenerklaeringsskjema(skjema_bruker_id, dato, tillat_epost, tillat_sms, evt_info, 1_1, 1_2, 1_3, 1_4, 1_5, 1_6, 2_1, 2_2, 2_3, 2_4, 2_5, 3_1, 3_2, 3_3, 3_4, 3_5, 3_6, 3_7, 4_1, 4_2, 4_3, 4_4, 4_5, 4_6, 4_7, 4_8, 4_9, 4_10, 5_1, 6_1, 6_2, 6_3, 6_4, 6_5, 6_6, 6_7, 6_8, 6_9, 6_10, 6_11, 6_12, 6_13, 6_14, 6_15, 7_1, 7_2, 7_3, 7_4, 8_1, 9_1, 9_2, 9_3, 9_4, 9_5, 9_6, 9_7, 9_8, 9_9, 9_10) VALUES ((SELECT blodgiver_bruker_id FROM blodgiver WHERE blodgiver_bruker_id = @currentuser), @dato, @tillat_epost, @tillat_sms, @evt_info, @1_1, @1_2, @1_3, @1_4, @1_5, @1_6, @2_1, @2_2, @2_3, @2_4, @2_5, @3_1, @3_2, @3_3, @3_4, @3_5, @3_6, @3_7, @4_1, @4_2, @4_3, @4_4, @4_5, @4_6, @4_7, @4_8, @4_9, @4_10, @5_1, @6_1, @6_2, @6_3, @6_4, @6_5, @6_6, @6_7, @6_8, @6_9, @6_10, @6_11, @6_12, @6_13, @6_14, @6_16, @7_1, @7_2, @7_3, @7_4, @8_1, @9_1, @9_2, @9_3, @9_4, @9_5, @9_6, @9_7, @9_8, @9_9, @9_10)", connection)
            sqlSendSvar.Parameters.AddWithValue("@currentuser", currentUser)
            sqlSendSvar.Parameters.AddWithValue("@dato", currDateString)
            sqlSendSvar.Parameters.AddWithValue("@tillat_epost", svar.Item(59))
            sqlSendSvar.Parameters.AddWithValue("@tillat_sms", svar.Item(60))
            sqlSendSvar.Parameters.AddWithValue("@evt_info", evt)
            sqlSendSvar.Parameters.AddWithValue("@1_1", svar.Item(0))
            sqlSendSvar.Parameters.AddWithValue("@1_2", svar.Item(1))
            sqlSendSvar.Parameters.AddWithValue("@1_3", svar.Item(2))
            sqlSendSvar.Parameters.AddWithValue("@1_4", svar.Item(3))
            sqlSendSvar.Parameters.AddWithValue("@1_5", svar.Item(4))
            sqlSendSvar.Parameters.AddWithValue("@1_6", svar.Item(5))
            sqlSendSvar.Parameters.AddWithValue("@2_1", svar.Item(6))
            sqlSendSvar.Parameters.AddWithValue("@2_2", svar.Item(7))
            sqlSendSvar.Parameters.AddWithValue("@2_3", svar.Item(8))
            sqlSendSvar.Parameters.AddWithValue("@2_4", svar.Item(9))
            sqlSendSvar.Parameters.AddWithValue("@2_5", svar.Item(10))
            sqlSendSvar.Parameters.AddWithValue("@3_1", svar.Item(11))
            sqlSendSvar.Parameters.AddWithValue("@3_2", svar.Item(12))
            sqlSendSvar.Parameters.AddWithValue("@3_3", svar.Item(13))
            sqlSendSvar.Parameters.AddWithValue("@3_4", svar.Item(14))
            sqlSendSvar.Parameters.AddWithValue("@3_5", svar.Item(15))
            sqlSendSvar.Parameters.AddWithValue("@3_6", svar.Item(16))
            sqlSendSvar.Parameters.AddWithValue("@3_7", svar.Item(17))
            sqlSendSvar.Parameters.AddWithValue("@4_1", svar.Item(18))
            sqlSendSvar.Parameters.AddWithValue("@4_2", svar.Item(19))
            sqlSendSvar.Parameters.AddWithValue("@4_3", svar.Item(20))
            sqlSendSvar.Parameters.AddWithValue("@4_4", svar.Item(21))
            sqlSendSvar.Parameters.AddWithValue("@4_5", svar.Item(22))
            sqlSendSvar.Parameters.AddWithValue("@4_6", svar.Item(23))
            sqlSendSvar.Parameters.AddWithValue("@4_7", svar.Item(24))
            sqlSendSvar.Parameters.AddWithValue("@4_8", svar.Item(25))
            sqlSendSvar.Parameters.AddWithValue("@4_9", svar.Item(26))
            sqlSendSvar.Parameters.AddWithValue("@4_10", svar.Item(27))
            sqlSendSvar.Parameters.AddWithValue("@5_1", svar.Item(28))
            sqlSendSvar.Parameters.AddWithValue("@6_1", svar.Item(29))
            sqlSendSvar.Parameters.AddWithValue("@6_2", svar.Item(30))
            sqlSendSvar.Parameters.AddWithValue("@6_3", svar.Item(31))
            sqlSendSvar.Parameters.AddWithValue("@6_4", svar.Item(32))
            sqlSendSvar.Parameters.AddWithValue("@6_5", svar.Item(33))
            sqlSendSvar.Parameters.AddWithValue("@6_6", svar.Item(34))
            sqlSendSvar.Parameters.AddWithValue("@6_7", svar.Item(35))
            sqlSendSvar.Parameters.AddWithValue("@6_8", svar.Item(36))
            sqlSendSvar.Parameters.AddWithValue("@6_9", svar.Item(37))
            sqlSendSvar.Parameters.AddWithValue("@6_10", svar.Item(38))
            sqlSendSvar.Parameters.AddWithValue("@6_11", svar.Item(39))
            sqlSendSvar.Parameters.AddWithValue("@6_12", svar.Item(40))
            sqlSendSvar.Parameters.AddWithValue("@6_13", svar.Item(41))
            sqlSendSvar.Parameters.AddWithValue("@6_14", svar.Item(42))
            sqlSendSvar.Parameters.AddWithValue("@6_15", svar.Item(43))
            sqlSendSvar.Parameters.AddWithValue("@7_1", svar.Item(44))
            sqlSendSvar.Parameters.AddWithValue("@7_2", svar.Item(45))
            sqlSendSvar.Parameters.AddWithValue("@7_3", svar.Item(46))
            sqlSendSvar.Parameters.AddWithValue("@7_4", svar.Item(47))
            sqlSendSvar.Parameters.AddWithValue("@8_1", svar.Item(48))
            sqlSendSvar.Parameters.AddWithValue("@9_1", svar.Item(49))
            sqlSendSvar.Parameters.AddWithValue("@9_2", svar.Item(50))
            sqlSendSvar.Parameters.AddWithValue("@9_3", svar.Item(51))
            sqlSendSvar.Parameters.AddWithValue("@9_4", svar.Item(52))
            sqlSendSvar.Parameters.AddWithValue("@9_5", svar.Item(53))
            sqlSendSvar.Parameters.AddWithValue("@9_6", svar.Item(54))
            sqlSendSvar.Parameters.AddWithValue("@9_7", svar.Item(55))
            sqlSendSvar.Parameters.AddWithValue("@9_8", svar.Item(56))
            sqlSendSvar.Parameters.AddWithValue("@9_9", svar.Item(57))
            sqlSendSvar.Parameters.AddWithValue("@9_10", svar.Item(58))
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
            MsgBox(ex)
        Finally
            connection.Close()
        End Try
        Return fornavn
    End Function
End Class
