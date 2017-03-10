Public Class egenSkjemaBolk1
    'Bolk 1: Vennligst besvar
    Private infoBlodgivning As Boolean = CheckBox19.Text
    Private følerFrisk As Boolean = CheckBox18.Text
    Private friskForrigeperiode As Boolean = CheckBox17.Text
    Private femtiKgEllerMer As Boolean = CheckBox16.Text
    Private sårEksemHudsykdom As Boolean = CheckBox15.Text
    Private piercingSlimhinne As Boolean = CheckBox14.Text

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Me.Close()
        egenSkjemaBolk2.Show()

    End Sub
End Class