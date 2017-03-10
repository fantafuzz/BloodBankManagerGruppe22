Public Class egenSkjemaBolk1
    'Bolk 1: Vennligst besvar
    Public infoBlodgivning As Boolean = CheckBox19.Text
    Public følerFrisk As Boolean = CheckBox18.Text
    Public friskForrigeperiode As Boolean = CheckBox17.Text
    Public femtiKgEllerMer As Boolean = CheckBox16.Text
    Public sårEksemHudsykdom As Boolean = CheckBox15.Text
    Public piercingSlimhinne As Boolean = CheckBox14.Text

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Me.Close()
        egenSkjemaBolk2.Show()

    End Sub
End Class