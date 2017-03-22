Public Class egenSkjemaBolk8
    'Bolk 8: Besvares av menn
    'Public harEllerHarDuHattSeksuellKontaktMedAndreMenn As Boolean = CheckBox1.Text

    Dim spm49 As New Sporsmaal("Har eller har du hatt seksuell kontakt med andre menn", "8_1")
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
        egenSkjemaBolk9.svar = svar
        egenSkjemaBolk9.Show()

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


    Private Sub egenSkjemaBolk8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = spm49.getText
    End Sub

    'denne kopier ▼
    Private Sub RadioButtonChanged(sender As Object, e As EventArgs) Handles RadioButtonJ1.CheckedChanged, RadioButtonN1.CheckedChanged
        changeToDefault(sender.Tag)
    End Sub
    'Denne kopier ▲

End Class