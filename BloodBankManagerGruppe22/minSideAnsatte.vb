Imports MySql.Data.MySqlClient

Public Class minSideAnsatte
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub minSideAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=;Database=;Uid=;Pwd="




        FilterData("")

    End Sub
    Public Sub FilterData(valueToSeach As String)


        'SELECT * FROM bruker WHERE CONCAT(bruker_id, brukernavn, passord)
        'Dim searchQuery As String = "SELECT * FROM bruker WHERE CONCAT(bruker_id, brukernavn, passord) like '%" & valueToSeach & "%'"
        Dim searchQuery As String = "SELECT bruker.bruker_id, bruker.fornavn, bruker.etternavn, blodgiver.personnummer FROM bruker, blodgiver WHERE bruker.bruker_id = blodgiver.blodgiver_bruker_id;"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hovedForside_Innlogging.Show()
        Me.Close()
    End Sub 'logg ut



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FilterData(TextBox1.Text)
    End Sub
End Class