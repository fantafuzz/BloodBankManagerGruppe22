Public Class AdminPanel
    Dim sql As New SQL_hookup()
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Hide()
        AnsattNavigasjon.Show()
    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridAnsatt.DataSource = sql.getAnsatte("")
    End Sub

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim value As String = tbSok.Text
        If value <> "" Then
            gridAnsatt.DataSource = sql.getAnsatte(value)
        End If
    End Sub

    Private Sub btnFjern_Click(sender As Object, e As EventArgs) Handles btnFjern.Click
        Dim bruker_id As Integer
        If Not gridAnsatt.CurrentRow Is Nothing Then
            bruker_id = gridAnsatt.CurrentRow.Cells("bruker_id").Value
            Dim forsikring As Integer = MsgBox("Er du sikker på at du vil fjerne denne ansattbrukeren?", MsgBoxStyle.YesNo, MsgBoxStyle.Critical)
            If forsikring = DialogResult.Yes Then
                sql.fjernAnsatt(bruker_id)
            End If
        End If
        gridAnsatt.DataSource = sql.getAnsatte()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If tbFornavn.Text <> "" And tbEtternavn.Text <> "" And tbEpost.Text <> "" And tbPassord.Text <> "" Then
            Dim fornavn As String = tbFornavn.Text
            Dim etternavn As String = tbEtternavn.Text
            Dim epost As String = tbEpost.Text
            Dim passord As String = tbPassord.Text
            Dim ansatt_type As Integer = -1
            If rbAnsatt.Checked Then
                ansatt_type = 0
            ElseIf rbAdmin.Checked Then
                ansatt_type = 1
            End If
            sql.registrerAnsatt(fornavn, etternavn, epost, passord, ansatt_type)
            MsgBox("Ansatt er registrert")
            gridAnsatt.DataSource = sql.getAnsatte("")
        Else
            MsgBox("Vennligst skriv inn alt av informasjon i tekstboksene før du trykker registrer.")
        End If
    End Sub
End Class