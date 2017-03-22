Public Class egenSkjemaBolk4

    'Bolk 4: Har du i løpet av de siste seks måneder
    'Public akupunktur As Boolean = CheckBox1.Text
    'Public stukketEllerSåretDegPåGjenstanderSomVarForurensetMedBlodEllerKropsvæske As Boolean = CheckBox2.Text
    'Public boddISammeHusstandSomEnPersonSomHarHepatittB As Boolean = CheckBox3.Text
    'Public fåttBlodsølPåSlimhinnerEllerSkadetHud As Boolean = CheckBox4.Text
    'Public harBlittBittAvFlått As Boolean = CheckBox5.Text
    'Public hattSeksuellPartnerVestEuropa As Boolean = CheckBox10.Text
    'Public hattSeksuellPartnerAfrika As Boolean = CheckBox9.Text
    'Public hattSeksuellKontaktBlodEllerBlodprodukterUtenforNorden As Boolean = CheckBox8.Text
    'Public hattNySeksuellPartner As Boolean = CheckBox7.Text
    'Public værtUtenforVestEuropa As Boolean = CheckBox6.Text

    Dim spm19 As New Sporsmaal("fått akupunktur", "4_1")
    Dim spm20 As New Sporsmaal("stukket eller skåret deg på gjenstander som var forurenset med blod eller kroppsvæsker", "4_2")
    Dim spm21 As New Sporsmaal("bodd i samme husstand som en person som har hepatitt B", "4_3")
    Dim spm22 As New Sporsmaal("fått blodsøl på slimhinner eller skadet hud", "4_4")
    Dim spm23 As New Sporsmaal("blitt bitt av flått", "4_5")
    Dim spm24 As New Sporsmaal("hatt seksualpartner som har bodd mer enn ett år sammenhengende utenfor Vest-Europa ", "4_6")
    Dim spm25 As New Sporsmaal("hatt seksualpartner som har vært i Afrika", "4_7")
    Dim spm26 As New Sporsmaal("hatt seksuell kontakt med en person som har fått blod eller blodprodukter utenfor Norden", "4_8")
    Dim spm27 As New Sporsmaal("hatt ny seksualpartner", "4_9")
    Dim spm28 As New Sporsmaal("vært utenfor Vest-Europa", "4_10")
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
        egenSkjemaBolk5.svar = svar
        egenSkjemaBolk5.Show()

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


    Private Sub egenSkjemaBolk4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = spm19.getText
        Label2.Text = spm20.getText
        Label3.Text = spm21.getText
        Label4.Text = spm22.getText
        Label5.Text = spm23.getText
        Label6.Text = spm24.getText
        Label7.Text = spm25.getText
        Label8.Text = spm26.getText
        Label9.Text = spm27.getText
        Label10.Text = spm28.getText

    End Sub
    'denne kopier ▼
    Private Sub RadioButtonChanged(sender As Object, e As EventArgs) Handles RadioButtonJ1.CheckedChanged, RadioButtonJ2.CheckedChanged, RadioButtonJ3.CheckedChanged, RadioButtonJ4.CheckedChanged, RadioButtonJ5.CheckedChanged, RadioButtonJ6.CheckedChanged, RadioButtonJ7.CheckedChanged, RadioButtonJ8.CheckedChanged, RadioButtonJ9.CheckedChanged, RadioButtonJ10.CheckedChanged, RadioButtonN1.CheckedChanged, RadioButtonN2.CheckedChanged, RadioButtonN3.CheckedChanged, RadioButtonN4.CheckedChanged, RadioButtonN5.CheckedChanged, RadioButtonN6.CheckedChanged, RadioButtonN7.CheckedChanged, RadioButtonN8.CheckedChanged, RadioButtonN9.CheckedChanged, RadioButtonN10.CheckedChanged
        changeToDefault(sender.Tag)
    End Sub
    'Denne kopier ▲
End Class