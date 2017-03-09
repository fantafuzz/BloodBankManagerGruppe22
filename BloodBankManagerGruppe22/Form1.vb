Imports MySql.Data.MySqlClient
Public Class Form1

    Public Class Form1
        Public currentuser As Integer
        Private salt As String = "detteErEnVeldigLangHashSomGjorAtVaarePassordBlirMyeSikrere"
        Private username As String
        Private password As String
        Private databasename As String
        Private server As String
        Private userinfo As New DataTable

        Private connstring As String
        Private connection As New MySqlConnection()

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

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            connstring = "Server=" & server & ";" & "Database=" & databasename & ";" & "Uid=" & username & ";" & "Pwd=" & password & ";"
            connection.ConnectionString = connstring
            userinfo = Query("SELECT bruker_id, brukernavn, passord FROM bruker")
            For Each row As DataRow In userinfo.Rows
                ListBox1.Items.Add(row("bruker_id") & " " & row("brukernavn") & " " & row("passord"))
            Next
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim gotmatch As Boolean = False
            Dim inputname As String = TextBoxUsername.Text
            Dim inputpword As String = TextBoxPassword.Text
            Dim hashedpword As String = hash(inputpword, salt)

            For Each row As DataRow In userinfo.Rows
                If row("brukernavn") = inputname And row("passord") = hashedpword Then
                    gotmatch = True
                    currentuser = row("bruker_id")
                End If
            Next
            If gotmatch Then
                MsgBox(currentuser)
            End If
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Dim inputname As String = TextBoxRegUsername.Text
            Dim inputpword As String = TextBoxRegPword.Text
            inputpword = hash(inputpword, salt)
            MsgBox(inputpword)

            If inputname <> "" And inputpword <> "" Then
                Query("INSERT INTO `login_form_forside`(`brukernavn`, `passord`) VALUES ('" & inputname & "','" & inputpword & "');")


            End If
        End Sub




        Query("INSERT INTO `login_form_forside`(`brukernavn`, `passord`) VALUES ('ola','hallo')")

            Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim tabell As New DataTable
            ListBox1.Items.Clear()
            tabell = Sporring("SELECT * FROM person ORDER BY fornavn")
            For Each rad As DataRow In tabell.Rows
                ListBox1.Items.Add(rad("person_id") & " " & rad("fornavn") & " " & rad("etternavn") & rad("epost") & rad("dato"))
            Next
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Dim tabell As New DataTable
            ListBox1.Items.Clear()
            tabell = Sporring("SELECT * FROM person WHERE fornavn='" & txtPerson.Text & "' OR etternavn='" & txtPerson.Text & "';")
            For Each rad As DataRow In tabell.Rows
                ListBox1.Items.Add(rad("person_id") & " " & rad("fornavn") & " " & rad("etternavn") & " " & rad("epost") & " " & rad("dato"))
            Next
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Dim tabell As New DataTable
            ListBox1.Items.Clear()
            tabell = Sporring("SELECT * FROM person WHERE epost LIKE '%" & txtEpost.Text & "%';")
            For Each rad As DataRow In tabell.Rows
                ListBox1.Items.Add(rad("person_id") & " " & rad("fornavn") & " " & rad("etternavn") & " " & rad("epost") & " " & rad("dato"))
            Next
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        egenerklæringForm.Show() 'legge inn opplysninger om den aktuelle blodgiver i en annen som først blir linket når denne knappen klikkes, eks:fornavn,etternavn,fødselsdato osv.. deretter en annen form(egenerklæringform),
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        minSideForm.Show()
    End Sub

    Private Sub OmOssToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OmOssToolStripMenuItem.Click
        MsgBox("Blodbank Register Applikasjonen er utviklet av Charlotte Halmrast, Marius Myhre og Naren Yogarajah.")
    End Sub
End Class
