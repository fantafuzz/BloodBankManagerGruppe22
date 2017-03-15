Public Class egenSkjemaBolk1
    'Bolk 1: Vennligst besvar
    ''Public infoBlodgivning As Boolean = CheckBox19.Text
    'Public følerFrisk As Boolean = CheckBox18.Text
    'Public friskForrigeperiode As Boolean = CheckBox17.Text
    'Public femtiKgEllerMer As Boolean = CheckBox16.Text
    'Public sårEksemHudsykdom As Boolean = CheckBox15.Text
    'Public piercingSlimhinne As Boolean = CheckBox14.Text

    Dim spm1 As New Sporsmaal("Har du fått informasjon om blodgivning?", "1_1")
    Dim spm2 As New Sporsmaal("Føler du deg frisk nå?", "1_2")
    Dim spm3 As New Sporsmaal("Hvis du har gitt blod tidligere, har du vært frisk i perioden fra forrige blodgivning og til nå?", "1_3")
    Dim spm4 As New Sporsmaal("Veier du 50kg eller mer?", "1_4")
    Dim spm5 As New Sporsmaal("Har du åpne sår, eksem eller hudsykdom?", "1_5")
    Dim spm6 As New Sporsmaal("Har du piercing i slimhinne?", "1_6")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uncheckedradios = From radio In Me.Panel2.Controls.OfType(Of RadioButton)()
                              Where Not radio.Checked
                              Select radio.Name
        Dim anyunchecked As Integer = uncheckedradios.Count

        If anyunchecked <> 1 Then
            Dim uncheckedNames = String.Join(",", uncheckedradios)
            MessageBox.Show("Please check all radio-buttons, these are not checked: " & uncheckedNames, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Me.Close()
        egenSkjemaBolk2.Show()

    End Sub
    Private Function valider(ByVal panel As String)
        Dim uncheckedradios = From radio In Me.Panel2.Controls.OfType(Of RadioButton)()
                              Where Not radio.Checked
                              Select radio.Name
        Dim anyunchecked As Integer = uncheckedradios.Count

        If anyunchecked <> 1 Then
            Dim uncheckedNames = String.Join(",", uncheckedradios)
            MessageBox.Show("Please check all radio-buttons, these are not checked: " & uncheckedNames, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Me.Close()
        egenSkjemaBolk2.Show()
    End Function



    Private Sub egenSkjemaBolk1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = spm1.getText
        Label2.Text = spm2.getText
        Label3.Text = spm3.getText
        Label4.Text = spm4.getText
        Label5.Text = spm5.getText
        Label6.Text = spm6.getText
    End Sub
End Class