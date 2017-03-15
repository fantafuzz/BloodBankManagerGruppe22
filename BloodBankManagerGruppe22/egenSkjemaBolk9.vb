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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



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
End Class