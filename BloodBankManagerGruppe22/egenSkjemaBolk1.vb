Public Class egenSkjemaBolk1
    Dim spm1 As New Sporsmaal("Har du fått informasjon om blodgivning?", "1_1")
    Dim spm2 As New Sporsmaal("Føler du deg frisk nå?", "1_2")
    Dim spm3 As New Sporsmaal("Hvis du har gitt blod tidligere, har du vært frisk i perioden fra forrige blodgivning og til nå?", "1_3")
    Dim spm4 As New Sporsmaal("Veier du 50kg eller mer?", "1_4")
    Dim spm5 As New Sporsmaal("Har du åpne sår, eksem eller hudsykdom?", "1_5")
    Dim spm6 As New Sporsmaal("Har du piercing i slimhinne?", "1_6")
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
        egenSkjemaBolk2.svar = svar
        egenSkjemaBolk2.Show()

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
    Private Sub egenSkjemaBolk1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelSpm1.Text = spm1.getText
        LabelSpm2.Text = spm2.getText
        LabelSpm3.Text = spm3.getText
        LabelSpm4.Text = spm4.getText
        LabelSpm5.Text = spm5.getText
        LabelSpm6.Text = spm6.getText
    End Sub

    'denne kopier ▼
    Private Sub RadioButtonChanged(sender As Object, e As EventArgs) Handles RadioButtonJ1.CheckedChanged, RadioButtonJ2.CheckedChanged, RadioButtonJ3.CheckedChanged, RadioButtonJ4.CheckedChanged, RadioButtonJ5.CheckedChanged, RadioButtonJ6.CheckedChanged, RadioButtonN1.CheckedChanged, RadioButtonN2.CheckedChanged, RadioButtonN3.CheckedChanged, RadioButtonN4.CheckedChanged, RadioButtonN5.CheckedChanged, RadioButtonN6.CheckedChanged
        changeToDefault(sender.Tag)
    End Sub
    'Denne kopier ▲
End Class