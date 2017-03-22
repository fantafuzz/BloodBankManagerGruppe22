Public Class egenSkjemaBolk5
    'Bolk 5: Har du i løpet av de siste to år
    'Public hattSjeldenEllerAlvorligeInfeksjonssykdommer As Boolean = CheckBox1.Text
    Public svar(60) As Boolean
    Dim spm29 As New Sporsmaal("hatt sjeldne eller alvorlige infeksjonssykdommer", "5_1")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_nesteBolk6.Click


        Me.Close()
        egenSkjemaBolk6.Show()
    End Sub

    Private Sub egenSkjemaBolk5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = spm29.getText
    End Sub
    Private Sub ButtonNeste_Click(sender As Object, e As EventArgs) Handles Button_nesteBolk6.Click

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


    'denne kopier ▼
    Private Sub RadioButtonChanged(sender As Object, e As EventArgs) Handles RadioButtonJ1.CheckedChanged, RadioButtonN1.CheckedChanged
        changeToDefault(sender.Tag)
    End Sub
    'Denne kopier ▲

End Class