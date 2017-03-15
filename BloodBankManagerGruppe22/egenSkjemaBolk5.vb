Public Class egenSkjemaBolk5
    'Bolk 5: Har du i løpet av de siste to år
    'Public hattSjeldenEllerAlvorligeInfeksjonssykdommer As Boolean = CheckBox1.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim spm29 As New Sporsmaal("hatt sjeldne eller alvorlige infeksjonssykdommer", "5_1")

        Me.Close()
        egenSkjemaBolk6.Show()
    End Sub
End Class