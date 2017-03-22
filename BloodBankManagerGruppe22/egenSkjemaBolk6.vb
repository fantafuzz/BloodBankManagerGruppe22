Public Class egenSkjemaBolk6
    'Bolk 6: Har du på noe tidspunkt gjennom livet
    'Public hjerteLeverLungeSykdom As Boolean = CheckBox1.Text
    'Public hattKreft As Boolean = CheckBox2.Text
    'Public hattBlødningstendens As Boolean = CheckBox3.Text
    'Public hattAllergiMotMatEllerMedisiner As Boolean = CheckBox4.Text
    'Public hattMalaria As Boolean = CheckBox5.Text
    'Public hattTropesykdommer As Boolean = CheckBox10.Text
    'Public hattHepatittHivAids As Boolean = CheckBox9.Text
    'Public positivPrøveHepatittHivinfeksjon As Boolean = CheckBox8.Text
    'Public blodOverføring As Boolean = CheckBox7.Text
    'Public vekstHormon As Boolean = CheckBox6.Text
    'Public hornHinnetransplantant As Boolean = CheckBox15.Text
    'Public syflis As Boolean = CheckBox14.Text
    'Public alvorligSykdomSomIkkeErNevntHer As Boolean = CheckBox13.Text
    'Public bruktDopingmidlerEllernarktoiskeStoffer As Boolean = CheckBox12.Text
    'Public mottatPengerEllerNarkotikaSomGjenytelse As Boolean = CheckBox11.Text

    Dim spm30 As New Sporsmaal("hatt, hjerte-, lever-, eller lungesykdom", "6_1")
    Dim spm31 As New Sporsmaal("hatt kreft", "6_2")
    Dim spm32 As New Sporsmaal("hatt blødningstendens", "6_3")
    Dim spm33 As New Sporsmaal("hatt allergi mot mat eller medisiner", "6_4")
    Dim spm34 As New Sporsmaal("hatt malaria", "6_5")
    Dim spm35 As New Sporsmaal("hatt tropesykdommer", "6_6")
    Dim spm36 As New Sporsmaal("hatt hepatitt (gulsott), HIV infeksjon eller AIDS", "6_7")
    Dim spm37 As New Sporsmaal("hatt positiv prøve for hepatitt (gulsott) eller HIVinfeksjon", "6_8")
    Dim spm38 As New Sporsmaal("fått blodoverføring", "6_9")
    Dim spm39 As New Sporsmaal("fått veksthormoner", "6_10")
    Dim spm40 As New Sporsmaal("fått hornhinnetransplantat", "6_11")
    Dim spm41 As New Sporsmaal("hatt syfilis", "6_12")
    Dim spm42 As New Sporsmaal("hatt alvorlig sykdom som ikke er nevnt her", "6_13")
    Dim spm43 As New Sporsmaal("brukt dopingmidler eller narkotiske midler som sprøyter eller ved sniffing", "6_14")
    Dim spm44 As New Sporsmaal("mottat penger eller narkotika som gjenytelse for sex", "6_15")
    Public svar(60) As Boolean
    ' ▼ Ta med denne men gjør den om slik at den passer.
    Private Sub ButtonNeste_Click(sender As Object, e As EventArgs) Handles ButtonNeste.Click
        Dim feil As Boolean = valider()
        If feil Then
            LabelFeilMelding.Visible = True ' Om valideringsfunksjonen finner en feil, gjør feilmeldingen synlig.
            Exit Sub
        End If

        mellomLagre()

        Me.Close()
        egenSkjemaBolk7.svar = svar
        egenSkjemaBolk7.Show()

    End Sub
    ' ▲ Ta med denne men gjør den om slik at den passer 

    ' Alt inni her skal kopieres ▼
    Private Sub mellomLagre() ' Mellomlagrer svarene i den globale variablen svar()
        For Each ctrl As Control In Me.Controls ' Itererer gjennom hver control vi har
            If ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then ' Om controllen den finner er et panel
                Dim mellomlagerPoints As Point ' Mellomlager for lokasjonen til radioknappene i panelet.
                Dim checkedRadios = From radio In ctrl.Controls.OfType(Of RadioButton)() ' Finner alle checked radiobuttons i panelet, og legger location inne i checkedradios.
                                    Where radio.Checked
                                    Select radio.Location
                For Each item In checkedRadios
                    mellomlagerPoints = item ' Legger inn location til den valgte radioknapp i mellomlagerPoints. Siden det aldri vil være to checked knapper i ett panel, så vil denne alltid være rett.
                Next
                If mellomlagerPoints = New Point(0, 6) Then 'Sjekker om den valgte knappen er på "Ja" plassen. Om den er det, legger vi inn True på plassen i svar() som tilsvarer spørsmålet.
                    svar(ctrl.Tag - 1) = True
                ElseIf mellomlagerPoints = New Point(52, 6) Then 'Sjekker om den valgte knappen er på "Nei" plassen. Om den er det, legger inn False på plassen i svar() som tilsvarer spørsmålet.
                    svar(ctrl.Tag - 1) = False
                End If
            End If
        Next
    End Sub

    Private Function valider() As Boolean 'Sjekker at hvert spørsmål er svart på
        Dim anyError As Boolean = False
        Dim errors As New ArrayList

        For Each ctrl As Control In Me.Controls
            If ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then 'Itererer gjennom hvert panel, og finner ut hvor mange unchecked radioknapper som finnes
                Dim uncheckedRadios = From radio In ctrl.Controls.OfType(Of RadioButton)()
                                      Where Not radio.Checked
                                      Select radio.Name
                Dim anyUnchecked As Integer = uncheckedRadios.Count
                If anyUnchecked > 1 Then ' Om det er mere enn 1 unchecked radioknapp, endres fargen til rød, og anyError blir true.
                    anyError = True
                    errors.Add(ctrl.Tag)
                    Select Case ctrl.Tag Mod 2
                        Case 1
                            ctrl.BackColor = Color.FromArgb(255, 200, 200)
                        Case 0
                            ctrl.BackColor = Color.FromArgb(255, 225, 225)
                    End Select
                End If
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If ctrl.GetType() Is GetType(System.Windows.Forms.Label) Then
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

        Return anyError 'Returnerer true om det er funnet et spørsmål som ikke er svart på.
    End Function

    Private Sub changeToDefault(ByVal tag As Integer) ' Endrer fargene tilbake til white og whitesmoke når du svarer.
        For Each ctrl As Control In Me.Controls 'Itererer gjennom hvert panel og hver label, til den finner en med korrekt tag. Endrer så fargen.
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
    End Sub
    ' Alt over her skal kopieres ▲


    Private Sub egenSkjemaBolk6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = spm30.getText
        Label2.Text = spm31.getText
        Label3.Text = spm32.getText
        Label4.Text = spm33.getText
        Label5.Text = spm34.getText
        Label6.Text = spm35.getText
        Label7.Text = spm36.getText
        Label8.Text = spm37.getText
        Label9.Text = spm38.getText
        Label10.Text = spm39.getText
        Label11.Text = spm40.getText
        Label12.Text = spm41.getText
        Label13.Text = spm42.getText
        Label14.Text = spm43.getText
        Label15.Text = spm44.getText
    End Sub

    'denne kopier ▼
    Private Sub RadioButtonChanged(sender As Object, e As EventArgs) Handles RadioButtonJ1.CheckedChanged, RadioButtonJ2.CheckedChanged, RadioButtonJ3.CheckedChanged, RadioButtonJ4.CheckedChanged, RadioButtonJ5.CheckedChanged, RadioButtonJ6.CheckedChanged, RadioButtonJ7.CheckedChanged, RadioButtonJ8.CheckedChanged, RadioButtonJ9.CheckedChanged, RadioButtonJ10.CheckedChanged, RadioButtonJ11.CheckedChanged, RadioButtonJ12.CheckedChanged, RadioButtonJ13.CheckedChanged, RadioButtonJ14.CheckedChanged, RadioButtonJ15.CheckedChanged, RadioButtonN1.CheckedChanged, RadioButtonN2.CheckedChanged, RadioButtonN3.CheckedChanged, RadioButtonN4.CheckedChanged, RadioButtonN5.CheckedChanged, RadioButtonN6.CheckedChanged, RadioButtonN6.CheckedChanged, RadioButtonN7.CheckedChanged, RadioButtonN8.CheckedChanged, RadioButtonN9.CheckedChanged, RadioButtonN10.CheckedChanged, RadioButtonN11.CheckedChanged, RadioButtonN12.CheckedChanged, RadioButtonN13.CheckedChanged, RadioButtonN14.CheckedChanged, RadioButtonN15.CheckedChanged
        changeToDefault(sender.Tag)
    End Sub
    'Denne kopier ▲
End Class