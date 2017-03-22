Public Class egenSkjemaBolk3
    'Update: 22.03.17 , 17.45
    'Bolk 3: Spørsmål 15 og 16


    'Bolk 3: Har du i løpet av de siste seks måneder
    'Public legeUndersøkelseEllerBehandlingForSykdom As Boolean = CheckBox1.Text
    'Public behandlingMedSprøyter As Boolean = CheckBox2.Text
    'Public kjønnsykdomEllerfåttBehandlingForKjønnsykdom As Boolean = CheckBox3.Text
    'Public kjønnsykdomSeksuellKontaktHivHepatittBEllerC = CheckBox4.Text
    'Public kjønnsykdomSeksuellKontaktDopingmidlerNarkotiskemidler As Boolean = CheckBox5.Text
    'Public hattSeksuellKontaktMedProstituerteEllerTidligereProstituerte As Boolean = CheckBox10.Text
    'Public tattHullIØretFåttPiercing As Boolean =CheckBox9.Text

    Dim spm12 As New Sporsmaal("vært til legeundersøkelse eller på sykehus, eller fått behandling for noen sykdom?", "3_1")
    Dim spm13 As New Sporsmaal("fått behandling med sprøyter? ", "3_2")
    Dim spm14 As New Sporsmaal("hatt kjønnssykdom, eller fått behandling for kjønnssykdom?", "3_3")
    Dim spm15 As New Sporsmaal("hatt seksuell kontakt med person med HIV-infeksjon eller hepatitt B eller hepatitt C, eller med person som har hatt positiv test for en av disse sykdommene?", "3_4")
    Dim spm16 As New Sporsmaal("hatt seksuell kontakt med person som bruker eller har brukt dopingmidler eller narkotiske midler som sprøyter eller ved sniffing?", "3_5")
    Dim spm17 As New Sporsmaal("hatt seksuell kontakt med prostituerte eller tidligere prostituerte?", "3_6")
    Dim spm18 As New Sporsmaal("blitt tatovert, fått piercing eller tatt hull i ørene? ", "3_7")
    Public svar(60) As Boolean

    Private Sub egenSkjemaBolk3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = spm12.getText
        Label2.Text = spm13.getText
        Label3.Text = spm14.getText
        Label4.Text = spm15.getText
        Label5.Text = spm16.getText
        Label6.Text = spm17.getText
        Label7.Text = spm18.getText
    End Sub
    Private Sub ButtonNeste_Click(sender As Object, e As EventArgs) Handles ButtonNeste.Click
        Dim feil As Boolean = valider()
        If feil Then
            LabelFeilMelding.Visible = True
            Exit Sub
        End If

        mellomLagre()

        Me.Close()
        egenSkjemaBolk4.svar = svar
        egenSkjemaBolk4.Show()

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
    Private Sub RadioButtonChanged(sender As Object, e As EventArgs) Handles RadioButtonJ1.CheckedChanged, RadioButtonJ2.CheckedChanged, RadioButtonJ3.CheckedChanged, RadioButtonJ4.CheckedChanged, RadioButtonJ5.CheckedChanged, RadioButtonJ6.CheckedChanged, RadioButtonJ7.CheckedChanged, RadioButtonN1.CheckedChanged, RadioButtonN2.CheckedChanged, RadioButtonN3.CheckedChanged, RadioButtonN4.CheckedChanged, RadioButtonN5.CheckedChanged, RadioButtonN6.CheckedChanged, RadioButtonN7.CheckedChanged
        changeToDefault(sender.Tag)
    End Sub
    'Denne kopier ▲
End Class