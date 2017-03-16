Public Class egenSkjemaBolk5
    'Bolk 5: Har du i løpet av de siste to år
    'Public hattSjeldenEllerAlvorligeInfeksjonssykdommer As Boolean = CheckBox1.Text
    Dim spm29 As New Sporsmaal("hatt sjeldne eller alvorlige infeksjonssykdommer", "5_1")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Close()
        egenSkjemaBolk6.Show()
    End Sub

    Private Sub egenSkjemaBolk5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = spm29.getText
    End Sub
End Class