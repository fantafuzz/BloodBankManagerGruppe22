Public Class egenSkjemaBolk2
    ''Bolk 2: Har du i løpet av de siste fire uker
    'Public bruktMedisiner As Boolean = CheckBox1.Text
    'Public værtSykEllerHattFeber As Boolean = CheckBox2.Text
    'Public hattLøsAvføring As Boolean = CheckBox3.Text
    'Public fåttVaksine As Boolean = CheckBox4.Text
    'Public værtHosTannlegeEllerTannpleier As Boolean = CheckBox5.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim spm7 As New Sporsmaal("brukt medisiner", "2_1")
        Dim spm8 As New Sporsmaal("vært sykt eller hatt feber", "2_2")
        Dim spm9 As New Sporsmaal("hatt løs avføring", "2_3")
        Dim spm10 As New Sporsmaal("fått vaksine", "2_4")
        Dim spm11 As New Sporsmaal("vært hos tannlege eller tannpleier", "2_5")



        Me.Close()
        egenSkjemaBolk3.Show()

    End Sub
End Class