Imports MySql.Data.MySqlClient
Public Class AnsattStatistikkNy
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub hvorMyeBlodGitt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"




        FilterData("")


        Dim column As DataGridViewColumn = DataGridView1.Columns(0)
        column.Width = 160

        Dim column1 As DataGridViewColumn = DataGridView1.Columns(1)
        column1.Width = 160

        Dim column2 As DataGridViewColumn = DataGridView1.Columns(2)
        column2.Width = 160
    End Sub
    Public Sub FilterData(valueToSearch As String)




        Dim searchQuery As String = "Select * from statistikk"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub

    Private Sub Button_tilbake_fra_lab_svar_Click(sender As Object, e As EventArgs) Handles Button_tilbake_fra_lab_svar.Click
        BrukerMinSide.Show()
        Me.Close()
    End Sub
End Class