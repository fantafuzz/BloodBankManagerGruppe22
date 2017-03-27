Public Class egenSkjemaTempStorage
    Dim spm1 As New Sporsmaal("Har du fått informasjon om blodgivning?", "1_1")
    Dim spm2 As New Sporsmaal("Føler du deg frisk nå?", "1_2")
    Dim spm3 As New Sporsmaal("Hvis du har gitt blod tidligere, har du vært frisk i perioden fra forrige blodgivning og til nå?", "1_3")
    Dim spm4 As New Sporsmaal("Veier du 50kg eller mer?", "1_4")
    Dim spm5 As New Sporsmaal("Har du åpne sår, eksem eller hudsykdom?", "1_5")
    Dim spm6 As New Sporsmaal("Har du piercing i slimhinne?", "1_6")
    Dim spm7 As New Sporsmaal("Brukt medisiner", "2_1")
    Dim spm8 As New Sporsmaal("Vært sykt eller hatt feber", "2_2")
    Dim spm9 As New Sporsmaal("Hatt løs avføring", "2_3")
    Dim spm10 As New Sporsmaal("Fått vaksine", "2_4")
    Dim spm11 As New Sporsmaal("Vært hos tannlege eller tannpleier", "2_5")
    Dim spm12 As New Sporsmaal("Vært til legeundersøkelse eller på sykehus, eller fått behandling for noen sykdom?", "3_1")
    Dim spm13 As New Sporsmaal("Fått behandling med sprøyter? ", "3_2")
    Dim spm14 As New Sporsmaal("Hatt kjønnssykdom, eller fått behandling for kjønnssykdom?", "3_3")
    Dim spm15 As New Sporsmaal("Hatt seksuell kontakt med person med HIV-infeksjon eller hepatitt B eller hepatitt C, eller med person som har hatt positiv test for en av disse sykdommene?", "3_4")
    Dim spm16 As New Sporsmaal("Hatt seksuell kontakt med person som bruker eller har brukt dopingmidler eller narkotiske midler som sprøyter eller ved sniffing?", "3_5")
    Dim spm17 As New Sporsmaal("Hatt seksuell kontakt med prostituerte eller tidligere prostituerte?", "3_6")
    Dim spm18 As New Sporsmaal("Blitt tatovert, fått piercing eller tatt hull i ørene? ", "3_7")
    Dim spm19 As New Sporsmaal("Fått akupunktur", "4_1")
    Dim spm20 As New Sporsmaal("Stukket eller skåret deg på gjenstander som var forurenset med blod eller kroppsvæsker", "4_2")
    Dim spm21 As New Sporsmaal("Bodd i samme husstand som en person som har hepatitt B", "4_3")
    Dim spm22 As New Sporsmaal("Fått blodsøl på slimhinner eller skadet hud", "4_4")
    Dim spm23 As New Sporsmaal("Blitt bitt av flått", "4_5")
    Dim spm24 As New Sporsmaal("Hatt seksualpartner som har bodd mer enn ett år sammenhengende utenfor Vest-Europa ", "4_6")
    Dim spm25 As New Sporsmaal("Hatt seksualpartner som har vært i Afrika", "4_7")
    Dim spm26 As New Sporsmaal("Hatt seksuell kontakt med en person som har fått blod eller blodprodukter utenfor Norden", "4_8")
    Dim spm27 As New Sporsmaal("Hatt ny seksualpartner", "4_9")
    Dim spm28 As New Sporsmaal("Vært utenfor Vest-Europa", "4_10")
    Dim spm29 As New Sporsmaal("Hatt sjeldne eller alvorlige infeksjonssykdommer", "5_1")
    Dim spm30 As New Sporsmaal("Hatt, hjerte-, lever-, eller lungesykdom", "6_1")
    Dim spm31 As New Sporsmaal("Hatt kreft", "6_2")
    Dim spm32 As New Sporsmaal("Hatt blødningstendens", "6_3")
    Dim spm33 As New Sporsmaal("Hatt allergi mot mat eller medisiner", "6_4")
    Dim spm34 As New Sporsmaal("Hatt malaria", "6_5")
    Dim spm35 As New Sporsmaal("Hatt tropesykdommer", "6_6")
    Dim spm36 As New Sporsmaal("Hatt hepatitt (gulsott), HIV infeksjon eller AIDS", "6_7")
    Dim spm37 As New Sporsmaal("Hatt positiv prøve for hepatitt (gulsott) eller HIVinfeksjon", "6_8")
    Dim spm38 As New Sporsmaal("Fått blodoverføring", "6_9")
    Dim spm39 As New Sporsmaal("Fått veksthormoner", "6_10")
    Dim spm40 As New Sporsmaal("Fått hornhinnetransplantat", "6_11")
    Dim spm41 As New Sporsmaal("Hatt syfilis", "6_12")
    Dim spm42 As New Sporsmaal("Hatt alvorlig sykdom som ikke er nevnt her", "6_13")
    Dim spm43 As New Sporsmaal("Brukt dopingmidler eller narkotiske midler som sprøyter eller ved sniffing", "6_14")
    Dim spm44 As New Sporsmaal("Mottat penger eller narkotika som gjenytelse for sex", "6_15")
    Dim spm45 As New Sporsmaal("Er du gravid?", "7_1") 'kvinner
    Dim spm46 As New Sporsmaal("Har du vært gravid i løpet av de siste tolv måneder, eller ammer du nå", "7_2") 'kvinner
    Dim spm47 As New Sporsmaal("Hvis du har gitt blod tidligere, har du vært gravid siden forrige blodgivning", "7_3") 'kvinner
    Dim spm48 As New Sporsmaal("Har du i løpet av de siste seks måneder hatt seksuell kontakt med en mann som du vet har hatt seksuell kontakt med andre menn", "7_4") 'kvinner
    Dim spm49 As New Sporsmaal("Har eller har du hatt seksuell kontakt med andre menn", "8_1") 'menn
    Dim spm50 As New Sporsmaal("Har du brukt narkotika en eller flere ganger de siste 12 måneder", "9_1")
    Dim spm51 As New Sporsmaal("Har du eller noen i familien hatt Creutzfeldt-Jakob sykdom eller variant CJD", "9_2")
    Dim spm52 As New Sporsmaal("Har du oppholdt deg i Storbritannia i mer enn ett år til sammen i perioden mellom 1980 og 1996", "9_3")
    Dim spm53 As New Sporsmaal("Har du i løpet av de siste tre år vært i område der malaria forekommer", "9_4")
    Dim spm54 As New Sporsmaal("Har du oppholdt deg sammenhengende i minst seks måneder i områder der malaria forekommer", "9_5")
    Dim spm55 As New Sporsmaal("Har du oppholdt deg i Afrika i mer enn fem år til sammen", "9_6")
    Dim spm56 As New Sporsmaal("Er du eller din mor født i Amerika sør for USA", "9_7")
    Dim spm57 As New Sporsmaal("Godtar du at anonymiserte prøver av ditt blod kan brukes til forskning? Du er like velkommen som blodgiver enten du svarer ja eller nei. Blodbanken kan gi informasjon om aktuelle forskningsprosjekter", "9_8")
    Dim spm58 As New Sporsmaal("Har du deltatt i medikamentforsøk de siste 12 måneder", "9_9")
    Dim spm59 As New Sporsmaal("Jeg samtykker til at mitt plasma føres ut av Norge for legemiddelproduksjon", "9_10")
    Dim spm60 As New Sporsmaal("Samtykker du til epost-forbindelse", "tillat_epost")
    Dim spm61 As New Sporsmaal("Samtykker du til sms-forbindelse", "tillat_sms")
    Dim spm62 As New Sporsmaal("evt", "evt_info")

    '45-48 KVINNER
    '49 MENN

    Dim sql As New SQL_hookup()


    Private Function valider() As Boolean 'Sjekker at hvert spørsmål er svart på
        Dim anyError As Boolean = False
        Dim errors As New ArrayList
        Dim currentselect = TabControlEgenskjema.SelectedTab 'Setter currentselect til hvilken tab som er valgt
        For Each tab As TabPage In TabControlEgenskjema.TabPages 'Går gjennom alle tabs
            If tab Is currentselect Then 'Hvis tab-en den er på er den valgte
                For Each ctrl As Control In tab.Controls
                    If ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then 'Itererer gjennom hvert panel, og finner ut hvor mange unchecked radioknapper som finnes
                        Dim uncheckedRadios = From radio In ctrl.Controls.OfType(Of RadioButton)()
                                              Where Not radio.Checked
                                              Select radio.Name
                        Dim anyUnchecked As Integer = uncheckedRadios.Count
                        If anyUnchecked > 1 Then ' Om det er mere enn 1 unchecked radioknapp (1 unchecked er bra, 2 er dårlig)
                            anyError = True 'Det er en feil
                            errors.Add(ctrl.Tag) 'Feil-taggen legges i errors-array
                            Select Case ctrl.Tag Mod 2
                                Case 1
                                    ctrl.BackColor = Color.FromArgb(255, 200, 200)
                                Case 0
                                    ctrl.BackColor = Color.FromArgb(255, 225, 225)
                            End Select
                        End If
                    End If
                Next
                For Each ctrl As Control In tab.Controls
                    If ctrl.GetType() Is GetType(System.Windows.Forms.Label) Then 'Itererer gjennom hver label, og ser om tag-en til label er i error-listen
                        If errors.Contains(ctrl.Tag) Then
                            Select Case ctrl.Tag Mod 2
                                Case 1
                                    ctrl.BackColor = Color.FromArgb(255, 200, 200)
                                Case 0
                                    ctrl.BackColor = Color.FromArgb(255, 225, 225)
                            End Select
                        End If
                    End If
                Next
            End If
        Next
        Return anyError 'Returnerer true om det er funnet et spørsmål som ikke er svart på.
    End Function
    Private Sub changeToDefault(ByVal tag As Integer) ' Endrer fargene tilbake til white og whitesmoke når du svarer.
        For Each tab As TabPage In TabControlEgenskjema.TabPages
            For Each ctrl As Control In tab.Controls
                If ctrl.GetType() Is GetType(System.Windows.Forms.Label) Or ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then
                    If ctrl.Tag = tag Then
                        Select Case ctrl.Tag Mod 2
                            Case 1
                                ctrl.BackColor = Color.WhiteSmoke
                            Case 0
                                ctrl.BackColor = Color.White
                        End Select
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub sendInn()
        Dim tillatSms As Integer = CheckBoxSms.Checked
        Dim tillatEpost As Integer = CheckBoxEpost.Checked
        Dim evt As String = TextBoxEvt.Text
        Dim svarArray As New Hashtable()
        Dim sortedArray As New ArrayList
        For Each tab As TabPage In TabControlEgenskjema.TabPages
            For Each ctrl As Control In tab.Controls
                If ctrl.GetType Is GetType(Panel) Then
                    Dim checkedRadios = From radio In ctrl.Controls.OfType(Of RadioButton)()
                                        Where radio.Checked
                                        Select radio.Location.X, radio.Tag
                    For Each item In checkedRadios
                        svarArray.Add(item.Tag, item.X.ToString)
                    Next
                End If
            Next
        Next
        For i = 1 To 59 Step 1
            If svarArray(CStr(i)) = 0 Then
                sortedArray.Add(1)
            ElseIf svarArray(CStr(i)) = 52 Then
                sortedArray.Add(0)
            Else
                sortedArray.Add("Feil hos radioknapp til spm nr: " & i)
            End If
        Next
        sortedArray.Add(tillatEpost)
        sortedArray.Add(tillatSms)
        sql.SendSvar(Logginn.currentuser, sortedArray, evt)
    End Sub
    Private Sub ButtonNeste_Click(sender As Object, e As EventArgs) Handles ButtonNeste.Click
        Dim feil As Boolean = valider()
        If feil Then
            LabelFeilMelding.Show()
        Else
            If TabControlEgenskjema.SelectedIndex < 9 Then
                TabControlEgenskjema.SelectedIndex += 1
            End If
        End If
    End Sub

    Private Sub RadioButtonAll_CheckedChanged(sender As Object, e As EventArgs)
        changeToDefault(DirectCast(sender, RadioButton).Tag)
    End Sub

    Private Sub egenSkjemaTempStorage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 59
            changeToDefault(i)
        Next

        LabelSpm1.Text = spm1.getText
        LabelSpm2.Text = spm2.getText
        LabelSpm3.Text = spm3.getText
        LabelSpm4.Text = spm4.getText
        LabelSpm5.Text = spm5.getText
        LabelSpm6.Text = spm6.getText
        LabelSpm7.Text = spm7.getText
        LabelSpm8.Text = spm8.getText
        LabelSpm9.Text = spm9.getText
        LabelSpm10.Text = spm10.getText
        LabelSpm11.Text = spm11.getText
        LabelSpm12.Text = spm12.getText
        LabelSpm13.Text = spm13.getText
        LabelSpm14.Text = spm14.getText
        LabelSpm15.Text = spm15.getText
        LabelSpm16.Text = spm16.getText
        LabelSpm17.Text = spm17.getText
        LabelSpm18.Text = spm18.getText
        LabelSpm19.Text = spm19.getText
        LabelSpm20.Text = spm20.getText
        LabelSpm21.Text = spm21.getText
        LabelSpm22.Text = spm22.getText
        LabelSpm23.Text = spm23.getText
        LabelSpm24.Text = spm24.getText
        LabelSpm25.Text = spm25.getText
        LabelSpm26.Text = spm26.getText
        LabelSpm27.Text = spm27.getText
        LabelSpm28.Text = spm28.getText
        LabelSpm29.Text = spm29.getText
        LabelSpm30.Text = spm30.getText
        LabelSpm31.Text = spm31.getText
        LabelSpm32.Text = spm32.getText
        LabelSpm33.Text = spm33.getText
        LabelSpm34.Text = spm34.getText
        LabelSpm35.Text = spm35.getText
        LabelSpm36.Text = spm36.getText
        LabelSpm37.Text = spm37.getText
        LabelSpm38.Text = spm38.getText
        LabelSpm39.Text = spm39.getText
        LabelSpm40.Text = spm40.getText
        LabelSpm41.Text = spm41.getText
        LabelSpm42.Text = spm42.getText
        LabelSpm43.Text = spm43.getText
        LabelSpm44.Text = spm44.getText
        LabelSpm45.Text = spm45.getText
        LabelSpm46.Text = spm46.getText
        LabelSpm47.Text = spm47.getText
        LabelSpm48.Text = spm48.getText
        LabelSpm49.Text = spm49.getText
        LabelSpm50.Text = spm50.getText
        LabelSpm51.Text = spm51.getText
        LabelSpm52.Text = spm52.getText
        LabelSpm53.Text = spm53.getText
        LabelSpm54.Text = spm54.getText
        LabelSpm55.Text = spm55.getText
        LabelSpm56.Text = spm56.getText
        LabelSpm57.Text = spm57.getText
        LabelSpm58.Text = spm58.getText
        LabelSpm59.Text = spm59.getText
        CheckBoxEpost.Text = spm60.getText
        CheckBoxSms.Text = spm61.getText

        For Each tab As TabPage In TabControlEgenskjema.TabPages 'Itererer gjennom hver tab
            For Each ctrl As Control In tab.Controls
                If ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then 'For hvert panel i hver tab
                    Dim radios = From radio In ctrl.Controls.OfType(Of RadioButton)() 'Legg alle radioknapper inn i radios
                                 Select radio
                    For Each x In radios 'for hver radioknapp i radios
                        AddHandler DirectCast(x, RadioButton).CheckedChanged, AddressOf RadioButtonAll_CheckedChanged 'Legg til radioknapp.checkedchanged som en eventhandler for radiobuttonall_checkedchanged sub-en
                    Next
                End If
            Next
        Next 'Denne sparer masse skriving, der alternativet er å skriver private sub x(sender as object, e as eventargs) handles radiobutton1, radiobutton2 ... radiobutton 120.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sendInn()
    End Sub
End Class