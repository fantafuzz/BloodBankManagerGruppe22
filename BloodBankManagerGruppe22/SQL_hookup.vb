Imports MySql.Data.MySqlClient
'This class is used for all SQL-interaction.
'Spørsmål? Skal vi bruke en "public" versjon av denne, som vi lager i form1? Eller skal vi konstruere en egen i hver?
Public Class SQL_hookup
    Private username As String
    Private password As String
    Private databasename As String
    Private server As String

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
    Public Function Query(ByVal sql As String) As DataTable
        'Denne tar hvilken som helst SQL-query, og returnerer en "DataTable" som inneholder tabellen med resultatet av queryen. Den kan også brukes for å legge inn info, men er usikker på hva som returneres. Det er ikke så viktig.
        'Ikke bruk denne om du skal ha bruker-input i SQL-queryen. Denne skal kun brukes der hele queryen er hardkodet.
        'Dette er for å unngå SQL-injection
        Dim table As New DataTable
        Try
            connection.Open()

            ' Do the query, and fill a table with data

            Dim command As New MySqlCommand(sql, connection)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            da.Fill(table)

            connection.Close()

        Catch ex As MySqlException
            MsgBox("En feil oppstått i 'Public Function Query', i 'SQL-hookub.vb' klassen")
        End Try
        Return table
    End Function

    'Public Function logInQuery(ByVal)
    '    '    Public Function QueryRead(ByVal whatToGet As String, ByVal fromTable As String, wherewhat As String) As DataTable
    '    '   Dim returntable As New DataTable
    '    '  Try
    '    ' Dim command As New MySqlCommand("SELECT ")
    '    '        command.CommandType = CommandType.StoredProcedure
    '    '       command.Parameters.Add(New SqlParameter("@CustomerName", CustomerName.Text))
    '    'Dim reader As SqlDataReader = command.ExecuteReader()
    '    'Catch se As SqlException
    '    '       MsgBox("En feil oppstått i 'Public function QueryRead', i 'SQL-hookub.vb' klassen")
    '    'End Try
    '    'Return returntable
    'End Function
End Class
