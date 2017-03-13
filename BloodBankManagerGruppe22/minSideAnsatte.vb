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


        'UPDATE: Vi må bruke nedenfor lagt seachQuery for å få søke knappen til fungere slik at den kan søke seg rundt i databasen.
        Dim searchQuery As String = "SELECT * FROM bruker WHERE CONCAT(bruker_id, fornavn, etternavn, epost) like '%" & valueToSeach & "%'"

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



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FilterData(TextBox1.Text)
    End Sub
End Class