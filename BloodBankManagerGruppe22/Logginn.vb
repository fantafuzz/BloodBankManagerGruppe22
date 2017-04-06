
Imports MySql.Data.MySqlClient

Public Class Logginn

    Public currentuser As Integer = -1
    Public currentuserType As Integer = -1
    Dim sql As New SQL_hookup("g_oops_22", "BtUDpVoR", "g_oops_22", "mysql.stud.iie.ntnu.no") 'Tilkobling til vår gruppe 22 database

    Private Sub ButtonLogInn_Click(sender As Object, e As EventArgs) Handles ButtonLogInn.Click
        Dim sjekkLog As Tuple(Of Integer, String) = sql.logInnSql(TextBoxEpost.Text, TextBoxPassword.Text, "bruker")
        currentuser = sjekkLog.Item1


        If currentuser = -1 Then
                MsgBox("Feil brukernavn eller passord", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
            Else
                Me.Hide()
                BrukerMinSide.Show()
            End If


    End Sub



    Private Sub ButtonRegistrer_Click(sender As Object, e As EventArgs) Handles ButtonRegistrer.Click
        Registrering.Show() 'Ved klikking av registering knappen så blir registering formen vist frem og denne formen vi er nå blir lukket.
        Me.Hide()
    End Sub


    Private Sub OmOssToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OmOssToolStripMenuItem.Click
        MessageBox.Show("Blodbanken produserer blodprodukt og utfører transfusjonsmedisinske analyser. I tillegg blir det utført en rekke immunologiske analyser, diagnostikk av blodkreft og stamcelletransplantasjoner. Det finst ingen erstatning for blod. Blod er et levende materiale, og selv med moderne og avansert teknologi kan ikke blod framstillest kunstig. Det kan heller ikke lagres lenge. Derfor trenger vi jevnt påfyll for at Blodbanken ikke ​skal gå tom. Blodet frå blodgiverene våre blir bearbeidet og delt i ulike blodprodukt; røde blodceller, blodplater og plasma. Blodbank Register Applikasjonen er utviklet av Charlotte Halmrast, Marius Myhre og Naren Yogarajah.")
        'Her har vi brukt Menustrip, ved hjelp av dette når brukeren klikker på den aktuelle delmenyen skal det vises ulike informasjoner.

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

        'Her har vi brukt Menustrip, ved hjelp av dette når brukeren klikker på den aktuelle delmenyen skal det vises ulike informasjoner.
    End Sub

    Private Sub RetningslinjerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetningslinjerToolStripMenuItem.Click
        MessageBox.Show("Reglene for å bli blodgiver i Norge finnes i  Veileder for transfusjonstjenesten i Norge (se Retningslinjer / Dokumenter) som er utarbeidet av Helsedirektoratet i Norge).

Transfusjonstjenesten omfatter blodbankene og alt arbeid rundt blod og blodprodukter ved norske sykehus.

Transfusjonstjenesten har et ansvar overfor de som melder seg som blodgivere, at disse behandles med respekt, at eventuelle funn som blir gjort blir håndtert til blodgiverens beste, og at selve blodgivningen gjennomføres under trygge forhold. 

Transfusjonstjenesten har et overordnet ansvar overfor blodmottakere, at behandling med blod og blodprodukter er trygt og hensiktsmessig.

Kriteriene for utvelgelse av blodgivere og en rekke av de laboratorieundersøkelser som anbefales, har til hensikt å beskytte både blodgiveren om han/hun heller burde beholde blodet sitt selv, og blodmottakerne mot infeksjonssykdommer som kan overføres med blod eller blodprodukter.")

        'Her har vi brukt Menustrip i toolbox, ved hjelp av dette når brukeren klikker på den aktuelle delmenyen skal det vises ulike informasjoner.
    End Sub

    Private Sub ButtonLogInnAnsatt_Click(sender As Object, e As EventArgs) Handles ButtonLogInnAnsatt.Click
        Dim sjekkLog As Tuple(Of Integer, String) = sql.logInnSql(TextBoxEpost.Text, TextBoxPassword.Text, "ansatt")
        currentuser = sjekkLog.Item1
        currentuserType = CInt(sjekkLog.Item2)
        If currentuser = -1 Then
            MsgBox("Feil brukernavn eller passord", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        Else
            Me.Hide()
            AnsattNavigasjon.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        BrukerMinSide.Show()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'live time update
        Label8.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt")

        'Her har vi en label som printer ut live dato og tid ved hjelp av en timer som er deklarert i logginn form load.
    End Sub



    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        AnsattNavigasjon.Show()



    End Sub

    Private Sub hovedForside_Innlogging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        'her er den aktuelle timeren deklarert til den aktuelle labelen som printer ut live dato og tid.

    End Sub
    Public Sub InitMyForm()
        StartPosition = FormStartPosition.CenterScreen
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

        'Her har vi brukt Menustrip i toolbox, ved hjelp av dette når brukeren klikker på den aktuelle delmenyen skal det vises ulike informasjoner.
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        AnsattInkalling.Show()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        AnsattNavigasjon.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        BrukerMinSide.Show()
    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    egenSkjemaBolk1.Show()
    'End Sub

    Private Sub HvaSkjerNårDuGirBlodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HvaSkjerNårDuGirBlodToolStripMenuItem.Click
        hvaSkjerNårDuGirBlod.Show()

        'Her har vi brukt Menustrip i toolbox, ved hjelp av dette når brukeren klikker på den aktuelle delmenyen skal det vises ulike informasjoner.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() 'test knapp
        egenSkjemaTempStorage.Show()
    End Sub

    Private Sub HarDuNettoppGittBlodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HarDuNettoppGittBlodToolStripMenuItem.Click
        MessageBox.Show("Dersom du etter blodgivningen kommer på viktig informasjon som du har glemt å gi, er det viktig at du tar kontakt med blodbanken og informerer om dette. Gi beskjed så fort som mulig, helst innen 48 timer etter blodgivning, om du skulle bli syk med enten oppkast, diaré eller høy feber.

Du kan når som helst ringe blodbanken og gi beskjed om at blodet ikke skal brukes uten å oppgi årsak.")

        'Her har vi brukt Menustrip i toolbox, ved hjelp av dette når brukeren klikker på den aktuelle delmenyen skal det vises ulike informasjoner.
    End Sub

    Private Sub NårKanDuIkkeGiBlodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NårKanDuIkkeGiBlodToolStripMenuItem.Click
        MessageBox.Show("For at du ikke skal komme forgjeves til blodbanken, vil vi minne om følgende:

Bruk av medikamenter inkludert reseptfrie kan gi karantene
Bruker du medisiner/smertestillende, kan det hende du ikke kan gi blod. Det vil i de fleste tilfeller være avhengig av hva som er årsaken til at du bruker medisiner. I andre tilfeller er det legemidlet i seg selv som er avgjørende. Om du kan gi blod må derfor vurderes konkret i den enkelte situasjon. Ved bruk av p-piller eller andre hormonpreparat, kan du vanligvis gi. Ved sporadisk bruk av smertestillende kan du også vanligvis gi, men etter langvarig bruk må du vanligvis vente i 14 dager. 
Bruker du antibiotika, kan du ikke gi blod. Da må du vente 14 dager etter avsluttet behandling (gjelder ikke lave doser av tetracykliner til behandling av acne).

Sprøyter
Personer som har fått behandling med sprøyter/injeksjoner må vente minst seks måneder med å gi blod, med mindre det er brukt sterilt engangsutstyr.

Infeksjonssykdom
Du må vente med å gi blod hvis du har hatt en infeksjonssykdom som for eksempel:

Influensa, forkjølelse, bronkitt eller sår hals (se også nedenfor)
Forkjølelsessår (Herpes Simplex). Åpne eller infiserte sår
Diaré, omgangssyke eller urinveisinfeksjon
Soppinfeksjon (behandling med tabletter eller vagitorier)
Selv etter relativt ubetydelige infeksjoner må du ha vært frisk i to uker før du gir blod

Du må også vente med å gi blod i 6 mnd. hvis du har:
Byttet seksualpartner
Fått tatovering
Fått piercing. Dersom det er satt hull i slimhinner (nese, munn, leppe og kjønnsorganer), skal man som hovedregel ikke gi blod før en måned etter at nålen er tatt ut.
Forkjølelse og sår hals
Har du vært forkjølet, men ikke hatt feber, må du vente en uke etter at du er blitt frisk og symptomfri.
Har du hatt sår hals, men ikke hatt feber, må du vente en uke etter at du er blitt frisk og symptomfri.
MERK: Ved feber må du vente 14 dager etter at du er blitt frisk og symptomfri.

Akupunktur
Årsaken til at blodgiveren har fått akupunkturbehandling er viktig. Dersom årsaken er av slik art at den i seg selv ikke har betydning for blodgivningen, gjelder følgende regel: Hvis utført av autorisert helsepersonell i Norge og med engangsnåler/sterile nåler: Kan gi blod. Hvis ikke: Karantene i 6 måneder. 

Tannlege
Du skal ikke gi blod de første 24 timene etter tannlegebesøk. Ved rotfylling må du vente en uke etter avsluttet behandlingen før du kan gi blod. Ved ukomplisert tanntrekking må du også vente en uke.

Flåttbitt
Blodbanken har karantene på 4 uker etter et ukomplisert flåttbitt. Har du fått utslett eller reaksjoner vil karantenetiden være 6 måneder. Etter behandling for flåttbitt vil karantenetiden også være 6 måneder.

Graviditet
Du skal ikke gi blod når du er gravid. Etter en fødsel skal kvinnen vente minst 12 måneder før hun gir blod igjen.

Allergier
Er du allergiker, kan du gi blod når du er symptomfri. Det er kun alvorlige allergiske reaksjoner som utelukker for blodgivning. Er du i tvil – ta kontakt med blodbanken.

Opphold i Storbritannia
Har du oppholdt deg i Storbritannia i mer enn 1 år til sammen i perioden mellom 1980 og 1996 kan du ikke være blodgiver. Dette skyldes faren for smitte ifm Creutzfeldt-Jakob.

Opphold i USA eller Canada
Har du oppholdt deg i USA eller Canada i tidsrommet 1.4.-30.11., kan du ikke gi blod. Du får da 1 måneds karantene fra du forlot USA/Canada.

Munnsår
Har du munnsår, skal du ikke gi blod.

Åpne sår
Du skal ikke gi blod dersom du har åpne sår, dvs. sår som blør eller væsker. Sår skal være tørre og ikke infiserte. Dersom du har blødende hemoroider, regnes det som åpent sår.

Vaksinasjon
Enkelte vaksinasjoner kan gi 4 uker karantene. Hepatitt-B-vaksine, Hepatitt A + B vaksine (combo) gir 4 ukers karantene. Ved tvil, kontakt blodbanken

Narkotika
Personer som har hatt sporadisk/engangsbruk av narkotiske midler som ikke injiseres: Ett års karantene. 
Personer som har brukt narkotiske midler via sprøyter kan ikke være blodgivere.

Er du i tvil om regelverket, ikke nøl med å kontakte blodbanken!

Telefon  72 57 31 00 eller 72 57 31 05")

        'Her har vi brukt Menustrip i toolbox, ved hjelp av dette når brukeren klikker på den aktuelle delmenyen skal det vises ulike informasjoner.
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.facebook.com/blodbanken")

        'her har vi valgt å koble den aktuelle sosial media knappen til blodbankens sosiale medier 
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://stolav.no/fag-og-forskning/lab/blodgiver")

        'her har vi valgt å koble den aktuelle sosial media til hjemmesiden til blodbanken og st.olavs hospital.
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://twitter.com/giblod")

        'her har vi valgt å koble den aktuelle sosial media knappen til blodbankens sosiale medier 
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://www.instagram.com/giblod/")

        'her har vi valgt å koble den aktuelle sosial media knappen til blodbankens sosiale medier 
    End Sub






End Class



