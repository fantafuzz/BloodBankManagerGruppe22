Public Class egenSkjemaBolk2
    ''Bolk 2: Har du i løpet av de siste fire uker
    'Public bruktMedisiner As Boolean = CheckBox1.Text
    'Public værtSykEllerHattFeber As Boolean = CheckBox2.Text
    'Public hattLøsAvføring As Boolean = CheckBox3.Text
    'Public fåttVaksine As Boolean = CheckBox4.Text
    'Public værtHosTannlegeEllerTannpleier As Boolean = CheckBox5.Text

    Dim spm7 As New Sporsmaal("brukt medisiner", "2_1")
    Dim spm8 As New Sporsmaal("vært sykt eller hatt feber", "2_2")
    Dim spm9 As New Sporsmaal("hatt løs avføring", "2_3")
    Dim spm10 As New Sporsmaal("fått vaksine", "2_4")
    Dim spm11 As New Sporsmaal("vært hos tannlege eller tannpleier", "2_5")
    Public svar(60) As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim feil As Boolean = valider()
        If feil Then
            LabelFeilMelding.Visible = True
            Exit Sub
        End If

        mellomLagre()

        egenSkjemaBolk3.svar = svar
        For Each item In svar
            MsgBox(item)
        Next
    End Sub

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

    Private Sub egenSkjemaBolk2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = spm7.getText
        Label2.Text = spm8.getText
        Label3.Text = spm9.getText
        Label4.Text = spm10.getText
        Label5.Text = spm11.getText
    End Sub
End Class