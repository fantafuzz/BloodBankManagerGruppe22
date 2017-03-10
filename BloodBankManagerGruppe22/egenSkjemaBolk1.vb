Public Class egenSkjemaBolk1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("1_1: Har du fått informasjon om blodgivning?")
        ListBox1.Items.Add("1_2: Føler du deg frisk nå?")
        ListBox1.Items.Add("1_3: Hvis du har gitt blod tidligere, har du vært frisk i perioden fra forrige blodgivning og til nå?")
    End Sub

    Private Sub egenerklæring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class