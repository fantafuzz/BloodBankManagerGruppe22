Public Class egenSkjemaBolk9
    'Bolk 9: Besvar også
    'Public bruktNarkotikaDeSisteTolvMåneder As Boolean = CheckBox1.Text
    'Public hattCJD As Boolean = CheckBox2.Text
    'Public storbritaniaOpphold As Boolean = CheckBox3.Text
    'Public områdeMalariaTreÅr As Boolean = CheckBox4.Text
    'Public områdeMalariaSeksMåneder As Boolean = CheckBox8.Text
    'Public afrikaOppholdMerEnnFemår As Boolean = CheckBox7.Text
    'Public fødtISørForUSA As Boolean = CheckBox6.Text
    'Public annonymisertePrøverForskning As Boolean = CheckBox5.Text
    'Public medikamentForsøk As Boolean = CheckBox11.Text
    'Public mittPlasmaUtAvNorgeLegemiddelproduksjon As Boolean = CheckBox10.Text


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

    Public svar As Boolean()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_FINAL_REGISTER.Click



        Me.Close()
        egenSkjemaBolk10.Show()
    End Sub

    Private Sub egenSkjemaBolk9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = spm50.getText
        Label2.Text = spm51.getText
        Label3.Text = spm52.getText
        Label4.Text = spm53.getText
        Label5.Text = spm54.getText
        Label6.Text = spm55.getText
        Label8.Text = spm56.getText
        Label8.Text = spm57.getText
        Label9.Text = spm58.getText
        Label10.Text = spm59.getText


    End Sub


    Private Sub ButtonNeste_Click(sender As Object, e As EventArgs) Handles Button_FINAL_REGISTER.Click
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
    Private Sub RadioButtonChanged(sender As Object, e As EventArgs) Handles RadioButtonJ1.CheckedChanged, RadioButtonJ2.CheckedChanged, RadioButtonJ3.CheckedChanged, RadioButtonJ4.CheckedChanged, RadioButtonJ5.CheckedChanged, RadioButtonJ6.CheckedChanged, RadioButtonJ7.CheckedChanged, RadioButtonJ8.CheckedChanged, RadioButtonJ9.CheckedChanged, RadioButtonJ10.CheckedChanged, RadioButtonN1.CheckedChanged, RadioButtonN2.CheckedChanged, RadioButtonN3.CheckedChanged, RadioButtonN4.CheckedChanged, RadioButtonN5.CheckedChanged, RadioButtonN6.CheckedChanged, RadioButtonN7.CheckedChanged, RadioButtonN8.CheckedChanged, RadioButtonN9.CheckedChanged, RadioButtonN10.CheckedChanged
        changeToDefault(sender.Tag)
    End Sub
    'Denne kopier ▲
End Class