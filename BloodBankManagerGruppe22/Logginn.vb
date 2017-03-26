
Imports MySql.Data.MySqlClient

Public Class Logginn

    Public currentuser As Integer = -1
    Public currentuserType As Integer = -1
    Dim sql As New SQL_hookup("g_oops_22", "BtUDpVoR", "g_oops_22", "mysql.stud.iie.ntnu.no")

    Private Sub ButtonLogInn_Click(sender As Object, e As EventArgs) Handles ButtonLogInn.Click
        Dim sjekkLog As Tuple(Of Integer, String) = sql.logInn(TextBoxEpost.Text, TextBoxPassword.Text, "bruker")
        currentuser = sjekkLog.Item1
        If currentuser = -1 Then
            MsgBox("Feil brukernavn eller passord", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        Else
            Me.Hide()
            BrukerMinSide.Show()
        End If
    End Sub

    Private Sub ButtonRegistrer_Click(sender As Object, e As EventArgs) Handles ButtonRegistrer.Click
        Registrering.Show()
        Me.Hide()
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

    Private Sub ButtonLogInnAnsatt_Click(sender As Object, e As EventArgs) Handles ButtonLogInnAnsatt.Click
        Dim sjekkLog As Tuple(Of Integer, String) = sql.logInn(TextBoxEpost.Text, TextBoxPassword.Text, "ansatt")
        currentuser = sjekkLog.Item1
        currentuserType = CInt(sjekkLog.Item2)
        If currentuser = -1 Then
            MsgBox("Feil brukernavn eller passord", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        Else
            Me.Hide()
            AnsattMinSide.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        BrukerMinSide.Show()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'live time update
        Label8.Text = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss tt")
    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        AnsattMinSide.Show()

    End Sub

    Private Sub hovedForside_Innlogging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        'setting standard form size
        'format:(width,height)
        AnsattMinSide.Size = New System.Drawing.Size(775, 425)
        BrukerMinSide.Size = New System.Drawing.Size(775, 425)
        AnsattBlodProdukter.Size = New System.Drawing.Size(775, 425)
        AnsattInkalling.Size = New System.Drawing.Size(775, 425)
        AnsattStatistikkNy.Size = New System.Drawing.Size(775, 425)
        BrukerAllInfo.Size = New System.Drawing.Size(775, 425)
        BrukerBestill.Size = New System.Drawing.Size(775, 425)
        BrukerLabSvar.Size = New System.Drawing.Size(775, 425)
        egenSkjemaBolk1.Size = New System.Drawing.Size(775, 425)
        Registrering.Size = New System.Drawing.Size(1200, 700)
        'Logginn.Size = New System.Drawing.Size(1200, 700)

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
        AnsattInkalling.Show()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        AnsattMinSide.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        BrukerMinSide.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        egenSkjemaBolk1.Show()
    End Sub

    Private Sub HvaSkjerNårDuGirBlodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HvaSkjerNårDuGirBlodToolStripMenuItem.Click
        hvaSkjerNårDuGirBlod.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        egenSkjemaTempStorage.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class



