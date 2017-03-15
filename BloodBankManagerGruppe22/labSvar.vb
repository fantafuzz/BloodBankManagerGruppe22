Imports MySql.Data.MySqlClient
Public Class labSvar

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub labSvar_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString =
        '    "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"


        'Dim command As New SqlCommand("select * from lab_svar")
        'command.Connection = connection

        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()

        'adapter.Fill(table)

        'ListBox1.DataSource = table

        'ListBox1.DisplayMember = "svar"
        'ListBox1.ValueMember = "svar_id"

    End Sub

    Private Sub print_resultat_Click(sender As Object, e As EventArgs) Handles print_resultat.Click

    End Sub
End Class