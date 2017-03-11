Public Class registeringAvNyeBlodgivere
    Public blodgivningLokasjon As String = ComboBox1.Text
    Public fornavn As String = TextBox1.Text
    Public etternavn As String = TextBox2.Text
    Public fødselsdato As Integer = TextBox3.Text  'skal vi deklare fødselsdato datatype som en date, eller en vanlig integer?
    Public personnummer As Integer = TextBox4.Text
    Public adresse As String = TextBox5.Text   'her legger jeg adresse som en string, er dette riktig? siden adressen også inneholder tall
    Public postnummer As Integer = TextBox6.Text
    Public poststed As String = TextBox7.Text
    Public telefonnummerEn As Integer = TextBox9.Text
    Public telefonnummerTo As Integer = TextBox8.Text
    Public epost As String = TextBox10.Text
    Public blodBefore As String = CheckBox1.Text
    Public hvilkenBlodbank As String = TextBox11.Text
    Public samtykke As String = CheckBox2.Text
    Public infoRodekors As String = CheckBox3.Text


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click











        egenSkjemaBolk1.Show()
        Me.Close()
    End Sub
End Class