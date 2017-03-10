Public Class egenSkjemaBolk9
    'Bolk 9: Besvar også
    Public bruktNarkotikaDeSisteTolvMåneder As Boolean = CheckBox1.Text
    Public hattCJD As Boolean = CheckBox2.Text
    Public storbritaniaOpphold As Boolean = CheckBox3.Text
    Public områdeMalariaTreÅr As Boolean = CheckBox4.Text
    Public områdeMalariaSeksMåneder As Boolean = CheckBox8.Text
    Public afrikaOppholdMerEnnFemår As Boolean = CheckBox7.Text
    Public fødtISørForUSA As Boolean = CheckBox6.Text
    Public annonymisertePrøverForskning As Boolean = CheckBox5.Text
    Public medikamentForsøk As Boolean = CheckBox11.Text
    Public mittPlasmaUtAvNorgeLegemiddelproduksjon As Boolean = CheckBox10.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Close()
        egenSkjemaBolk10.Show()
    End Sub
End Class