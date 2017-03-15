Public Class egenSkjemaBolk7

    'Bolk 7: Besvares av kvinner
    'Public erDuGravid As Boolean = CheckBox1.Text
    'Public værtGravidEllerAmmer As Boolean = CheckBox2.Text
    'Public værtGravidSidenSisteBlodgivning As Boolean = CheckBox3.Text
    'Public seksuellKontaktMedMannSomHarHattSeksuellKontaktMedAndreMenn As Boolean = CheckBox4.Text

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim spm45 As New Sporsmaal("er du gravid?", "7_1")
        Dim spm46 As New Sporsmaal("Har du vært gravid i løpet av de siste tolv måneder, eller ammer du nå", "7_2")
        Dim spm47 As New Sporsmaal("Hvis du har gitt blod tidligere, har du vært gravid siden forrige blodgivning", "7_3")
        Dim spm48 As New Sporsmaal("Har du i løpet av de siste seks måneder hatt seksuell kontakt med en mann som du vet har hatt seksuell kontakt med andre menn", "7_4")


        Me.Close()
        egenSkjemaBolk8.Show()
    End Sub
End Class