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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Me.Close()
        egenSkjemaBolk7.Show()
    End Sub

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
End Class