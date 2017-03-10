'forside ligger inne
'test1
Imports MySql.Data.MySqlClient
Public Class hovedForside_Innlogging
    Public currentuser As Integer
    Private salt As String = "detteErEnVeldigLangHashSomGjorAtVaarePassordBlirMyeSikrere"
    Private username As String
    Private password As String
    Private databasename As String
    Private server As String
    Private userinfo As New DataTable

    Private connstring As String
    Private connection As New MySqlConnection()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLogInfo()




    End Sub

    Private Sub loadLogInfo()
        connstring = "Server=" & server & ";" & "Database=" & databasename & ";" & "Uid=" & username & ";" & "Pwd=" & password & ";"
        connection.ConnectionString = connstring
        userinfo = Query("SELECT bruker_id, brukernavn, passord FROM bruker")
        'For Each row As DataRow In userinfo.Rows
        '    ListBox1.Items.Add(row("bruker_id") & " " & row("brukernavn") & " " & row("passord"))
        'Next
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
    Private Function Query(ByVal sql As String) As DataTable
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
            MessageBox.Show("En feil oppstått - " & ex.Message)
        End Try
        Return table
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gotmatch As Boolean = False
        Dim inputname As String = TextBoxUsername.Text
        Dim inputpword As String = TextBoxPassword.Text
        Dim hashedpword As String = hash(inputpword, salt)

        loadLogInfo()

        For Each row As DataRow In userinfo.Rows
            If row("brukernavn") = inputname And row("passord") = hashedpword Then
                gotmatch = True
                currentuser = row("bruker_id")
            End If
        Next
        If gotmatch = True Then
            MessageBox.Show("Du er logget inn. Velkommen til blodbanken.")
            minSideForm.Show()
        ElseIf gotmatch = False Then
            MessageBox.Show("Feil brukernavn eller passord.")
        End If
        'Etter at du har registrert deg første gang, fungerer det ikke å logge inn med det aktuelle brukernavnet og passordet.
        'Men etter at du har registrert deg og avsluttet applikasjonen og starter på nytt, fungerer det å få logget inn i applikasjonen. Vi må finne ut av hva som er årsaken til dette.
        'SVAR: Det er på grunn av måten jeg skrev den første koden, den henter inn all login-informasjon når formen lastes. Kan kjøre en kjapp fiks nå

    End Sub

    Private Sub ButtonRegistrer_Click(sender As Object, e As EventArgs) Handles ButtonRegistrer.Click
        registeringAvNyeBlodgivere.Show()


    End Sub


    Private Sub OmOssToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OmOssToolStripMenuItem.Click
        MessageBox.Show("Blodbanken produserer blodprodukt og utfører transfusjonsmedisinske analyser. I tillegg blir det utført en rekke immunologiske analyser, diagnostikk av blodkreft og stamcelletransplantasjoner. Det finst ingen erstatning for blod. Blod er et levende materiale, og selv med moderne og avansert teknologi kan ikke blod framstillest kunstig. Det kan heller ikke lagres lenge. Derfor trenger vi jevnt påfyll for at Blodbanken ikke ​skal gå tom. Blodet frå blodgiverene våre blir bearbeidet og delt i ulike blodprodukt; røde blodceller, blodplater og plasma. Blodbank Register Applikasjonen er utviklet av Charlotte Halmrast, Marius Myhre og Naren Yogarajah.")
        'Huske å programmere i objekt orientert form.

    End Sub


End Class



