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

    Public Sub logInn(ByVal brukernavn As String, ByVal passord As String, ByVal type As String)
        Dim b = brukernavn
        Dim p = hash(passord, salt)

    End Sub

    Public Sub registrerNy(ByVal fornavn As String, ByVal etternavn As String, ByVal epost As String, ByVal passord As String, ByVal fodselsdato As String, ByVal personnummer As String, ByVal adresse As String, ByVal postnummer As Integer, ByVal poststed As String, ByVal telefonnummerEn As String, ByVal telefonnummerTo As String, ByVal kjonn As String, ByVal blodtype As Integer, ByVal blodgivningLokasjon As String, ByVal blodbefore As Boolean, ByVal hvilkenBlodbank As String, ByVal samtykke As Boolean, ByVal infoRodekors As Boolean)


        Try
            connection.Open()
            Dim sqlAddBruker As New MySqlCommand("INSERT INTO bruker (fornavn, etternavn, epost, passord) values (@fornavn, @etternavn, @epost, @passord)", connection)
            sqlAddBruker.Parameters.AddWithValue("@fornavn", fornavn)
            sqlAddBruker.Parameters.AddWithValue("@etternavn", etternavn)
            sqlAddBruker.Parameters.AddWithValue("@epost", epost)
            sqlAddBruker.Parameters.AddWithValue("@passord", passord)
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

        Catch exception As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & exception.Message)
        Finally
            connection.Close()
        End Try
    End Sub


End Class
