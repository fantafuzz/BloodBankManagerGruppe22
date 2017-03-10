Public Class egenSkjemaBolk3
    'Bolk 3: Har du i løpet av de siste seks måneder
    'Public legeUndersøkelseEllerBehandlingForSykdom As Boolean = CheckBox1.Text
    'Public behandlingMedSprøyter As Boolean = CheckBox2.Text
    'Public kjønnsykdomEllerfåttBehandlingForKjønnsykdom As Boolean = CheckBox3.Text
    'Public kjønnsykdomSeksuellKontaktHivHepatittBEllerC = CheckBox4.Text
    'Public kjønnsykdomSeksuellKontaktDopingmidlerNarkotiskemidler As Boolean = CheckBox5.Text
    'Public hattSeksuellKontaktMedProstituerteEllerTidligereProstituerte As Boolean = CheckBox10.Text
    'Public tattHullIØretFåttPiercing As Boolean = CheckBox9.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Close()
        egenSkjemaBolk4.Show()
    End Sub
End Class