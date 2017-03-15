Public Class egenSkjemaBolk1
    'Bolk 1: Vennligst besvar
    ''Public infoBlodgivning As Boolean = CheckBox19.Text
    'Public følerFrisk As Boolean = CheckBox18.Text
    'Public friskForrigeperiode As Boolean = CheckBox17.Text
    'Public femtiKgEllerMer As Boolean = CheckBox16.Text
    'Public sårEksemHudsykdom As Boolean = CheckBox15.Text
    'Public piercingSlimhinne As Boolean = CheckBox14.Text

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim spm1 As New Sporsmaal("Har du fått informasjon om blodgivning?", "1_1")
        Dim spm2 As New Sporsmaal("Føler du deg frisk nå?", "1_2")
        Dim spm3 As New Sporsmaal("Hvis du har gitt blod tidligere, har du vært frisk i perioden fra forrige blodgivning og til nå?", "1_3")
        Dim spm4 As New Sporsmaal("Veier du 50kg eller mer?", "1_4")
        Dim spm5 As New Sporsmaal("Har du åpne sår, eksem eller hudsykdom?", "1_5")
        Dim spm6 As New Sporsmaal("Har du piercing i slimhinne?", "1_6")

        Me.Close()
        egenSkjemaBolk2.Show()

    End Sub


End Class