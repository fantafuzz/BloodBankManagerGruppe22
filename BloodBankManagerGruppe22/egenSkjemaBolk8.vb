Public Class egenSkjemaBolk8
    'Bolk 8: Besvares av menn
    'Public harEllerHarDuHattSeksuellKontaktMedAndreMenn As Boolean = CheckBox1.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim spm49 As New Sporsmaal("Har eller har du hatt seksuell kontakt med andre menn", "8_1")


        Me.Close()
        egenSkjemaBolk9.Show()
    End Sub


End Class