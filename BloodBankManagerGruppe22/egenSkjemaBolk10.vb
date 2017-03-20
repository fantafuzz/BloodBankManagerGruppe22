Public Class egenSkjemaBolk10
    'Bolk 10: Eventuelle andre opplysninger
    'Public eventuelleAndreOpplysninger As String = CheckBox1.Text
    'Public tillatelseBlodgiverEpostSms As String = TextBox1.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim spm60 As New Sporsmaal("Samtykker du til epost/sms forbindelse", "tillat_epost_sms")
        Dim spm61 As New Sporsmaal("evt", "evt_info")





        MessageBox.Show("Tusen takk for ditt bidrag til blodbanken. Vi setter veldig stor pris på det !")
        BrukerAllInfo.Show()
        Me.Close()
    End Sub
End Class