Imports MySql.Data.MySqlClient

Public Class AnsattInkalling
    Dim sql As New SQL_hookup()
    Private Sub minSideAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridBrukere.DataSource = sql.FilterData("")

        Dim column As DataGridViewColumn = GridBrukere.Columns(0)
        column.Width = 160

        Dim column1 As DataGridViewColumn = GridBrukere.Columns(1)
        column1.Width = 160

        Dim column2 As DataGridViewColumn = GridBrukere.Columns(2)
        column2.Width = 160

    End Sub
    Private Sub ButtonInnkall_Click(sender As Object, e As EventArgs) Handles ButtonInnkall.Click
        Dim bruker_id As Integer
        Dim fornavn As String = ""
        Dim etternavn As String = ""
        Dim epost As String = ""
        Dim personnummer As String = ""
        Dim currDate As Date = Date.Now
        Dim currDateString As String = currDate.ToString("yyyy-MM-dd")
        Dim info As String = "Dette var en test"

        If Not GridBrukere.CurrentRow Is Nothing Then
            bruker_id = GridBrukere.CurrentRow.Cells("bruker_id").Value
            fornavn = GridBrukere.CurrentRow.Cells("fornavn").Value
            etternavn = GridBrukere.CurrentRow.Cells("etternavn").Value
            epost = GridBrukere.CurrentRow.Cells("epost").Value
            'personnummer = GridBrukere.CurrentRow.Cells("personnummer").Value
        End If

        MsgBox(bruker_id & " " & fornavn & " " & etternavn & " " & epost & " " & personnummer)

        sql.bestillTime(bruker_id, info)

        'her legger vi inn måndekalender value i databasen vår ved hjelp av sql syntax.


    End Sub

    Private Sub ButtonTilbake_Click(sender As Object, e As EventArgs) Handles ButtonTilbake.Click
        AnsattNavigasjon.Show()
        Me.Hide()
    End Sub
End Class