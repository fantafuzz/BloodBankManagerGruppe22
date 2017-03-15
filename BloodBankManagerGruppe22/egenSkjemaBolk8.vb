Public Class egenSkjemaBolk8
    'Bolk 8: Besvares av menn
    'Public harEllerHarDuHattSeksuellKontaktMedAndreMenn As Boolean = CheckBox1.Text

    Dim spm49 As New Sporsmaal("Har eller har du hatt seksuell kontakt med andre menn", "8_1")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Me.Close()
        egenSkjemaBolk9.Show()
    End Sub

    Private Sub egenSkjemaBolk8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = spm49.getText
    End Sub
End Class