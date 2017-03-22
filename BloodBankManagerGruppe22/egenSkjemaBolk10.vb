Imports MySql.Data.MySqlClient
Public Class egenSkjemaBolk10
    'Bolk 10: Eventuelle andre opplysninger
    'Public eventuelleAndreOpplysninger As String = CheckBox1.Text
    'Public tillatelseBlodgiverEpostSms As String = TextBox1.Text

    Dim spm60 As New Sporsmaal("Samtykker du til epost-forbindelse", "tillat_epost")
    Dim spm61 As New Sporsmaal("Samtykker du til sms-forbindelse", "tillat_sms")
    Dim spm62 As New Sporsmaal("evt", "evt_info")
    Public svar(60) As Boolean
    Dim sql As New SQL_hookup()
    Dim evt As String = ""
    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        svar(59) = CheckBoxEpost.CheckState
        svar(60) = CheckBoxSms.CheckState
        evt = TextBoxEvt.Text
        sql.SendSvar(27, svar, evt)
        Me.Close()
    End Sub
    Private Sub egenSkjemaBolk10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBoxEpost.Text = spm60.getText
        CheckBoxSms.Text = spm61.getText
    End Sub
End Class