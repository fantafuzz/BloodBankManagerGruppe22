
Imports MySql.Data.MySqlClient

Public Class hovedForside_Innlogging

    Public currentuser As Integer
    Private salt As String = "detteErEnVeldigLangHashSomGjorAtVaarePassordBlirMyeSikrere"
    Private username As String = ""
    Private password As String = ""
    Private databasename As String = ""
    Private server As String = ""
    Private userinfo As New DataTable

    Private connstring As String
    Private connection As New MySqlConnection()

    Private Sub loadLogInfo()
        connstring = "Server=" & server & ";" & "Database=" & databasename & ";" & "Uid=" & username & ";" & "Pwd=" & password & ";"
        connection.ConnectionString = connstring
        userinfo = Query("SELECT bruker_id, epost, passord FROM bruker")

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
            If row("epost") = inputname And row("passord") = hashedpword Then
                gotmatch = True
                currentuser = row("bruker_id")
            End If
        Next
        If gotmatch = True Then
            MessageBox.Show("Du er logget inn. Velkommen til blodbanken.")
            MINSIDENAVIGASJONbrukere.Show()
        ElseIf gotmatch = False Then
            MessageBox.Show("Feil brukernavn eller passord.")
        End If



    End Sub

    Private Sub ButtonRegistrer_Click(sender As Object, e As EventArgs) Handles ButtonRegistrer.Click
        registeringAvNyeBlodgivere.Show()


    End Sub


    Private Sub OmOssToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OmOssToolStripMenuItem.Click
        MessageBox.Show("Blodbanken produserer blodprodukt og utfører transfusjonsmedisinske analyser. I tillegg blir det utført en rekke immunologiske analyser, diagnostikk av blodkreft og stamcelletransplantasjoner. Det finst ingen erstatning for blod. Blod er et levende materiale, og selv med moderne og avansert teknologi kan ikke blod framstillest kunstig. Det kan heller ikke lagres lenge. Derfor trenger vi jevnt påfyll for at Blodbanken ikke ​skal gå tom. Blodet frå blodgiverene våre blir bearbeidet og delt i ulike blodprodukt; røde blodceller, blodplater og plasma. Blodbank Register Applikasjonen er utviklet av Charlotte Halmrast, Marius Myhre og Naren Yogarajah.")
        'Huske å programmere i objekt orientert form.

    End Sub

    Private Sub OmBlodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OmBlodToolStripMenuItem.Click
        MessageBox.Show("Blodet består av...

Røde blodlegemer

De røde blodlegemene transporterer surstoff rundt i kroppen

Hvite blodlegmer

Det er disse som bekjemper infeksjoner i kroppen

Blodplater

Blodplatene stopper blødninger

Plasma

Dette er væsken som blodlegemene og blodplatene flyter i. Plasma inneholder blant annet livsviktige proteiner og stoffer som er nødvendige for å stanse blødninger.    ")
    End Sub

    Private Sub RetningslinjerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetningslinjerToolStripMenuItem.Click
        MessageBox.Show("Reglene for å bli blodgiver i Norge finnes i  Veileder for transfusjonstjenesten i Norge (se Retningslinjer / Dokumenter) som er utarbeidet av Helsedirektoratet i Norge).

Transfusjonstjenesten omfatter blodbankene og alt arbeid rundt blod og blodprodukter ved norske sykehus.

Transfusjonstjenesten har et ansvar overfor de som melder seg som blodgivere, at disse behandles med respekt, at eventuelle funn som blir gjort blir håndtert til blodgiverens beste, og at selve blodgivningen gjennomføres under trygge forhold. 

Transfusjonstjenesten har et overordnet ansvar overfor blodmottakere, at behandling med blod og blodprodukter er trygt og hensiktsmessig.

Kriteriene for utvelgelse av blodgivere og en rekke av de laboratorieundersøkelser som anbefales, har til hensikt å beskytte både blodgiveren om han/hun heller burde beholde blodet sitt selv, og blodmottakerne mot infeksjonssykdommer som kan overføres med blod eller blodprodukter.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gotmatch As Boolean = False
        Dim inputname As String = TextBoxUsername.Text
        Dim inputpword As String = TextBoxPassword.Text
        Dim hashedpword As String = hash(inputpword, salt)

        loadLogInfo()

        For Each row As DataRow In userinfo.Rows
            If row("epost") = inputname And row("passord") = hashedpword Then
                gotmatch = True
                currentuser = row("bruker_id")
            End If
        Next
        If gotmatch = True Then
            MessageBox.Show("Du er logget inn. Velkommen til blodbanken.")
            minSideAnsatte.Show()
        ElseIf gotmatch = False Then
            MessageBox.Show("Feil brukernavn eller passord.")
        End If






    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MINSIDENAVIGASJONbrukere.Show()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'live time update
        Label8.Text = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss tt")
    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        egenSkjemaBolk1.Show()

    End Sub

    Private Sub hovedForside_Innlogging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ÅpninstiderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÅpninstiderToolStripMenuItem.Click
        MessageBox.Show("Mandag:	0730 - 1530
Tirsdag:	0730 - 1530
Onsdag:	0730 - 1530
Torsdag:	0730 - 1530
Fredag:	0730 - 1530
")
    End Sub

    Private Sub KontaktOssToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KontaktOssToolStripMenuItem.Click
        MessageBox.Show("
St. Olavs Hospital, Universitetssykehuset i Trondheim


Besøksadresse:
Blodbanken, Laboratoriesenteret, Erling Skjalgssons gt. 1
7006 Trondheim

Telefon:
72 57 31 00


E-post:
blodgiver@stolav.no


Url:
www.stolav.no/blodgiver

")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        minSideAnsatte.Show()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        minSideNavigasjonansatte.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        MINSIDENAVIGASJONbrukere.Show()
    End Sub
End Class



