Public Class Sporsmaal
    Private spmText As String
    Private spmNr As String

    Public Function getText() As String
        Return spmText
    End Function

    Public Function getNr() As String
        Return spmNr
    End Function
    Public Sub New(ByVal nr As String)
        spmText = getSporsmalText(nr)
        spmNr = nr
    End Sub

    Public Sub New()
        spmText = "placeholder"
        spmNr = "-1_-1"
    End Sub

    Public Function getAnySpm(ByVal spmnummer As String) As String
        Return getSporsmalText(spmnummer)
    End Function

    Public Function getListofSpmNr() As ArrayList
        Dim spmTable As Hashtable = getSporsmalTable()
        Dim returnTable As New ArrayList
        For Each item In spmTable
            returnTable.Add(item.key)
        Next
        Return returnTable
    End Function

    Private Function getSporsmalText(ByVal spmnummer As String) As String
        Dim spmTable As Hashtable = getSporsmalTable()
        If Not spmTable(spmnummer) Is Nothing Then
            Return spmTable(spmnummer)
        Else
            Return "Error"
        End If
    End Function

    Private Function getSporsmalTable() As Hashtable
        Dim spmTable As Hashtable = New Hashtable
        spmTable.Add("1_1", "Har du fått informasjon om blodgivning?")
        spmTable.Add("1_2", "Føler du deg frisk nå?")
        spmTable.Add("1_3", "Hvis du har gitt blod tidligere, har du vært frisk i perioden fra forrige blodgivning og til nå?")
        spmTable.Add("1_4", "Veier du 50kg eller mer?")
        spmTable.Add("1_5", "Har du åpne sår, eksem eller hudsykdom?")
        spmTable.Add("1_6", "Har du piercing i slimhinne?")
        spmTable.Add("2_1", "Brukt medisiner")
        spmTable.Add("2_2", "Vært sykt eller hatt feber")
        spmTable.Add("2_3", "Hatt løs avføring")
        spmTable.Add("2_4", "Fått vaksine")
        spmTable.Add("2_5", "Vært hos tannlege eller tannpleier")
        spmTable.Add("3_1", "Vært til legeundersøkelse eller på sykehus, eller fått behandling for noen sykdom?")
        spmTable.Add("3_2", "Fått behandling med sprøyter?")
        spmTable.Add("3_3", "Hatt kjønnssykdom, eller fått behandling for kjønnssykdom?")
        spmTable.Add("3_4", "Hatt seksuell kontakt med person med HIV-infeksjon eller hepatitt B eller hepatitt C, eller med person som har hatt positiv test for en av disse sykdommene?")
        spmTable.Add("3_5", "Hatt seksuell kontakt med person som bruker eller har brukt dopingmidler eller narkotiske midler som sprøyter eller ved sniffing?")
        spmTable.Add("3_6", "Hatt seksuell kontakt med prostituerte eller tidligere prostituerte?")
        spmTable.Add("3_7", "Blitt tatovert, fått piercing eller tatt hull i ørene?")
        spmTable.Add("4_1", "Fått akupunktur")
        spmTable.Add("4_2", "Stukket eller skåret deg på gjenstander som var forurenset med blod eller kroppsvæsker")
        spmTable.Add("4_3", "Bodd i samme husstand som en person som har hepatitt B")
        spmTable.Add("4_4", "Fått blodsøl på slimhinner eller skadet hud")
        spmTable.Add("4_5", "Blitt bitt av flått")
        spmTable.Add("4_6", "Hatt seksualpartner som har bodd mer enn ett år sammenhengende utenfor Vest-Europa")
        spmTable.Add("4_7", "Hatt seksualpartner som har vært i Afrika")
        spmTable.Add("4_8", "Hatt seksuell kontakt med en person som har fått blod eller blodprodukter utenfor Norden")
        spmTable.Add("4_9", "Hatt ny seksualpartner")
        spmTable.Add("4_10", "Vært utenfor Vest-Europa")
        spmTable.Add("5_1", "Hatt sjeldne eller alvorlige infeksjonssykdommer")
        spmTable.Add("6_1", "Hatt, hjerte-, lever-, eller lungesykdom")
        spmTable.Add("6_2", "Hatt kreft")
        spmTable.Add("6_3", "Hatt blødningstendens")
        spmTable.Add("6_4", "Hatt allergi mot mat eller medisiner")
        spmTable.Add("6_5", "Hatt malaria")
        spmTable.Add("6_6", "Hatt tropesykdommer")
        spmTable.Add("6_7", "Hatt hepatitt (gulsott), HIV infeksjon eller AIDS")
        spmTable.Add("6_8", "Hatt positiv prøve for hepatitt (gulsott) eller HIVinfeksjon")
        spmTable.Add("6_9", "Fått blodoverføring")
        spmTable.Add("6_10", "Fått veksthormoner")
        spmTable.Add("6_11", "Fått hornhinnetransplantat")
        spmTable.Add("6_12", "Hatt syfilis")
        spmTable.Add("6_13", "Hatt alvorlig sykdom som ikke er nevnt her")
        spmTable.Add("6_14", "Brukt dopingmidler eller narkotiske midler som sprøyter eller ved sniffing")
        spmTable.Add("6_15", "Mottat penger eller narkotika som gjenytelse for sex")
        spmTable.Add("7_1", "Er du gravid?")
        spmTable.Add("7_2", "Har du vært gravid i løpet av de siste tolv måneder, eller ammer du nå")
        spmTable.Add("7_3", "Hvis du har gitt blod tidligere, har du vært gravid siden forrige blodgivning")
        spmTable.Add("7_4", "Har du i løpet av de siste seks måneder hatt seksuell kontakt med en mann som du vet har hatt seksuell kontakt med andre menn")
        spmTable.Add("8_1", "Har eller har du hatt seksuell kontakt med andre menn")
        spmTable.Add("9_1", "Har du brukt narkotika en eller flere ganger de siste 12 måneder")
        spmTable.Add("9_2", "Har du eller noen i familien hatt Creutzfeldt-Jakob sykdom eller variant CJD")
        spmTable.Add("9_3", "Har du oppholdt deg i Storbritannia i mer enn ett år til sammen i perioden mellom 1980 og 1996")
        spmTable.Add("9_4", "Har du i løpet av de siste tre år vært i område der malaria forekommer")
        spmTable.Add("9_5", "Har du oppholdt deg sammenhengende i minst seks måneder i områder der malaria forekommer")
        spmTable.Add("9_6", "Har du oppholdt deg i Afrika i mer enn fem år til sammen")
        spmTable.Add("9_7", "Er du eller din mor født i Amerika sør for USA")
        spmTable.Add("9_8", "Godtar du at anonymiserte prøver av ditt blod kan brukes til forskning? Du er like velkommen som blodgiver enten du svarer ja eller nei. Blodbanken kan gi informasjon om aktuelle forskningsprosjekter")
        spmTable.Add("9_9", "Har du deltatt i medikamentforsøk de siste 12 måneder")
        spmTable.Add("9_10", "Jeg samtykker til at mitt plasma føres ut av Norge for legemiddelproduksjon")
        spmTable.Add("tillat_epost", "Samtykker du til epost-forbindelse")
        spmTable.Add("tillat_sms", "Samtykker du til sms-forbindelse")
        spmTable.Add("evt_info", "evt")
        Return spmTable
    End Function
End Class
