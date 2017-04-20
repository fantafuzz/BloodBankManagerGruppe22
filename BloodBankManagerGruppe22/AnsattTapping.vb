Imports MySql.Data.MySqlClient
Public Class AnsattTapping

    Dim sql As New SQL_hookup()
    Private Sub AnsattTapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridBruker.DataSource = sql.FilterData("")


        Dim column As DataGridViewColumn = GridBruker.Columns(0)
        column.Width = 100

        Dim column1 As DataGridViewColumn = GridBruker.Columns(1)
        column1.Width = 100

        Dim column2 As DataGridViewColumn = GridBruker.Columns(2)
        column2.Width = 100
    End Sub
    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim value As String = tbSok.Text
        If value <> "" Then
            GridBruker.DataSource = sql.FilterData(value)
        End If
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        AnsattNavigasjon.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        Dim bruker_id As Integer
        If Not GridBruker.CurrentRow Is Nothing Then
            If Not GridBruker.CurrentRow.Cells("bruker_id").Value.GetType Is GetType(DBNull) Then
                bruker_id = GridBruker.CurrentRow.Cells("bruker_id").Value
            End If
        End If

        sql.tapping(bruker_id)
    End Sub
End Class