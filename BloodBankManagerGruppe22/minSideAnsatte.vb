Imports MySql.Data.MySqlClient

Public Class minSideAnsatte
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub minSideAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server= ;Database=;Uid=;Pwd="




        FilterData("")

    End Sub
    Public Sub FilterData(valueToSeach As String)



        Dim searchQuery As String = "SELECT bruker.bruker_id, bruker.fornavn, bruker.etternavn, bruker.epost, blodgiver.personnummer FROM bruker, blodgiver WHERE bruker.bruker_id = blodgiver.blodgiver_bruker_id AND CONCAT(bruker_id,fornavn, etternavn, epost) like '%" & valueToSeach & "%';"

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not DataGridView1.CurrentRow Is Nothing Then
            Dim bruker_id As Integer = DataGridView1.CurrentRow.Cells("bruker_id").Value
            Dim fornavn As String = DataGridView1.CurrentRow.Cells("fornavn").Value
            Dim etternavn As String = DataGridView1.CurrentRow.Cells("etternavn").Value
            Dim epost As String = DataGridView1.CurrentRow.Cells("epost").Value
            Dim personnummer As Integer = DataGridView1.CurrentRow.Cells("personnummer").Value
        End If

        Dim READER As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String
            Query = "insert into g_oops_22.time_bestilling(bestilling_bruker_id, dato) values ('" & DataGridView1.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader



                MessageBox.Show("Ny time er bestilt.")
                MysqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try


    End Sub
End Class