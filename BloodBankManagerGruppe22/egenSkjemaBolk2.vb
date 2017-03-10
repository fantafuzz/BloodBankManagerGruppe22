Public Class egenSkjemaBolk2
    'Bolk 2: Har du i løpet av de siste fire uker
    Public bruktMedisiner As Boolean = CheckBox1.Text
    Public værtSykEllerHattFeber As Boolean = CheckBox2.Text
    Public hattLøsAvføring As Boolean = CheckBox3.Text
    Public fåttVaksine As Boolean = CheckBox4.Text
    Public værtHosTannlegeEllerTannpleier As Boolean = CheckBox5.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Me.Close()
        egenSkjemaBolk3.Show()

    End Sub
End Class