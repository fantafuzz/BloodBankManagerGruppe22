Imports MySql.Data.MySqlClient
Public Class BrukerLabSvar

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim sql As New SQL_hookup()

    Private Sub labSvar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim labsvar As New DataTable()
        labsvar = sql.getLabSvar(Logginn.currentuser)
        If Not labsvar Is Nothing Then
            GridSvar.DataSource = labsvar
        Else
            labsvar.Columns.Add("Ingen tester er utført")
        End If

    End Sub

    Private Sub Button_tilbake_fra_lab_svar_Click(sender As Object, e As EventArgs) Handles Button_tilbake_fra_lab_svar.Click
        BrukerMinSide.Show()
        Me.Close()
    End Sub
End Class