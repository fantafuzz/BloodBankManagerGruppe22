Public Class egenSkjemaBolk7

    'Bolk 7: Besvares av kvinner
    'Public erDuGravid As Boolean = CheckBox1.Text
    'Public værtGravidEllerAmmer As Boolean = CheckBox2.Text
    'Public værtGravidSidenSisteBlodgivning As Boolean = CheckBox3.Text
    'Public seksuellKontaktMedMannSomHarHattSeksuellKontaktMedAndreMenn As Boolean = CheckBox4.Text

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Me.Close()
        egenSkjemaBolk8.Show()
    End Sub
End Class