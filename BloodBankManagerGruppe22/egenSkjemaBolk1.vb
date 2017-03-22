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
            LabelFeilMelding.Visible = True
            Exit Sub
        End If

        mellomLagre()

        Me.Close()
        egenSkjemaBolk2.svar = svar
        egenSkjemaBolk2.Show()

    End Sub
    ' ▲ Ta med denne men gjør den om slik at den passer 

    ' Alt inni her skal kopieres ▼
    Private Sub mellomLagre()
        For Each ctrl As Control In Me.Controls
            If ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then
                Dim mellomlagerPoints As Point
                Dim checkedRadios = From radio In ctrl.Controls.OfType(Of RadioButton)()
                                    Where radio.Checked
                                    Select radio.Location
                For Each item In checkedRadios
                    mellomlagerPoints = item
                Next
                If mellomlagerPoints = New Point(0, 6) Then
                    svar(ctrl.Tag - 1) = True
                ElseIf mellomlagerPoints = New Point(52, 6) Then
                    svar(ctrl.Tag - 1) = False
                End If
            End If
        Next
    End Sub

    Private Function valider() As Boolean
        Dim anyError As Boolean = False
        Dim errors As New ArrayList

        For Each ctrl As Control In Me.Controls
            If ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then
                Dim uncheckedRadios = From radio In ctrl.Controls.OfType(Of RadioButton)()
                                      Where Not radio.Checked
                                      Select radio.Name
                Dim anyUnchecked As Integer = uncheckedRadios.Count
                If anyUnchecked > 1 Then
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

        Return anyError
    End Function

    Private Sub changeToDefault(ByVal tag As Integer)
        For Each ctrl As Control In Me.Controls
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