Imports MySql.Data.MySqlClient
Public Class mottaBestillinger

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub mottaBestillinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"


        FilterData("")

        Dim column As DataGridViewColumn = motta_bestillinger_grid.Columns(0)
        column.Width = 150

        Dim column1 As DataGridViewColumn = motta_bestillinger_grid.Columns(1)
        column1.Width = 190

        Dim column2 As DataGridViewColumn = motta_bestillinger_grid.Columns(2)
        column2.Width = 150

        Dim column3 As DataGridViewColumn = motta_bestillinger_grid.Columns(3)
        column3.Width = 150
    End Sub
    Public Sub FilterData(valueToSearch As String)




        Dim searchQuery As String = "Select * from motta_bestillinger"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        motta_bestillinger_grid.DataSource = table


    End Sub

    Private Sub Button_tilbake_fra_lab_svar_Click(sender As Object, e As EventArgs) Handles Button_tilbake_fra_motta_bestillinger.Click
        Me.Close()
        AnsattNavigasjon.Show()
    End Sub
End Class