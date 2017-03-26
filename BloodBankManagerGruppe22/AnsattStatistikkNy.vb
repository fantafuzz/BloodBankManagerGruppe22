Imports MySql.Data.MySqlClient
Public Class AnsattStatistikkNy
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub hvorMyeBlodGitt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"




        FilterData("")


        'Dim column As DataGridViewColumn = DataGridView1.Columns(0)
        'column.Width = 160

        Dim column1 As DataGridViewColumn = DataGridView1.Columns(0)
        column1.Width = 255

        Dim column2 As DataGridViewColumn = DataGridView1.Columns(1)
        column2.Width = 255
    End Sub
    Public Sub FilterData(valueToSearch As String)




        Dim searchQuery As String = "SELECT Year, Blodgivere FROM statistikk;"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub


End Class