Public Class egenSkjemaBolk4

    'Bolk 4: Har du i løpet av de siste seks måneder
    Public akupunktur As Boolean = CheckBox1.Text
    Public stukketEllerSåretDegPåGjenstanderSomVarForurensetMedBlodEllerKropsvæske As Boolean = CheckBox2.Text
    Public boddISammeHusstandSomEnPersonSomHarHepatittB As Boolean = CheckBox3.Text
    Public fåttBlodsølPåSlimhinnerEllerSkadetHud As Boolean = CheckBox4.Text
    Public harBlittBittAvFlått As Boolean = CheckBox5.Text
    Public hattSeksuellPartnerVestEuropa As Boolean = CheckBox10.Text
    Public hattSeksuellPartnerAfrika As Boolean = CheckBox9.Text
    Public hattSeksuellKontaktBlodEllerBlodprodukterUtenforNorden As Boolean = CheckBox8.Text
    Public hattNySeksuellPartner As Boolean = CheckBox7.Text
    Public værtUtenforVestEuropa As Boolean = CheckBox6.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        egenSkjemaBolk5.Show()
    End Sub
End Class