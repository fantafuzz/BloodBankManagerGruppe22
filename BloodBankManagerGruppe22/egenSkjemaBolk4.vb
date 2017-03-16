Public Class egenSkjemaBolk4

    'Bolk 4: Har du i løpet av de siste seks måneder
    'Public akupunktur As Boolean = CheckBox1.Text
    'Public stukketEllerSåretDegPåGjenstanderSomVarForurensetMedBlodEllerKropsvæske As Boolean = CheckBox2.Text
    'Public boddISammeHusstandSomEnPersonSomHarHepatittB As Boolean = CheckBox3.Text
    'Public fåttBlodsølPåSlimhinnerEllerSkadetHud As Boolean = CheckBox4.Text
    'Public harBlittBittAvFlått As Boolean = CheckBox5.Text
    'Public hattSeksuellPartnerVestEuropa As Boolean = CheckBox10.Text
    'Public hattSeksuellPartnerAfrika As Boolean = CheckBox9.Text
    'Public hattSeksuellKontaktBlodEllerBlodprodukterUtenforNorden As Boolean = CheckBox8.Text
    'Public hattNySeksuellPartner As Boolean = CheckBox7.Text
    'Public værtUtenforVestEuropa As Boolean = CheckBox6.Text

    Dim spm19 As New Sporsmaal("fått akupunktur", "4_1")
    Dim spm20 As New Sporsmaal("stukket eller skåret deg på gjenstander som var forurenset med blod eller kroppsvæsker", "4_2")
    Dim spm21 As New Sporsmaal("bodd i samme husstand som en person som har hepatitt B", "4_3")
    Dim spm22 As New Sporsmaal("fått blodsøl på slimhinner eller skadet hud", "4_4")
    Dim spm23 As New Sporsmaal("blitt bitt av flått", "4_5")
    Dim spm24 As New Sporsmaal("hatt seksualpartner som har bodd mer enn ett år sammenhengende utenfor Vest-Europa ", "4_6")
    Dim spm25 As New Sporsmaal("hatt seksualpartner som har vært i Afrika", "4_7")
    Dim spm26 As New Sporsmaal("hatt seksuell kontakt med en person som har fått blod eller blodprodukter utenfor Norden", "4_8")
    Dim spm27 As New Sporsmaal("hatt ny seksualpartner", "4_9")
    Dim spm28 As New Sporsmaal("vært utenfor Vest-Europa", "4_10")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Close()
        egenSkjemaBolk5.Show()
    End Sub

    Private Sub egenSkjemaBolk4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = spm19.getText
        Label2.Text = spm20.getText
        Label3.Text = spm21.getText
        Label4.Text = spm22.getText
        Label5.Text = spm23.getText
        Label6.Text = spm24.getText
        Label7.Text = spm25.getText
        Label8.Text = spm26.getText
        Label9.Text = spm27.getText
        Label10.Text = spm28.getText

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class