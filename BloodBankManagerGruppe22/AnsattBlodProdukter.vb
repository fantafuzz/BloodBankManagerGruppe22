Imports MySql.Data.MySqlClient
Public Class AnsattBlodProdukter
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Statistikk_Click(sender As Object, e As EventArgs) Handles Button_Tilbake_AnsattMinSide.Click
        Me.Close()
        AnsattMinSide.Show()
    End Sub

    Private Sub AnsattBlodProdukter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"



        FilterData("")

    End Sub
    Public Sub FilterData(valueToSearch As String)

        Dim searchQuery As String = "SELECT blodbeholdning.beholdningstype_id, blodbeholdning.blodbeholdning_navn, blodbeholdning.blodbeholdning_mengde, blodbeholdning_endring.endring_aarsak, FROM blodbeholdning, blodbeholdning_endring WHERE blodbeholdning.beholdningstype_id = blodbeholdning_endring.endring_blodbeholdning_id AND CONCAT(beholdningstype_id,beholdningstype_navn,beholdningstype_mengde) like '%" & valueToSearch & "%';"

        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub



    Private Sub Button_utlevering_av_blodprodukter_Click_1(sender As Object, e As EventArgs) Handles Button_utlevering_av_blodprodukter.Click
        Dim beholdningstype_id As Integer
        Dim beholdningstype_navn As String = ""
        Dim beholdningstype_mengde As String = ""

        If Not DataGridView1.CurrentRow Is Nothing Then
            beholdningstype_id = DataGridView1.CurrentRow.Cells("beholdningstype_id").Value
            beholdningstype_navn = DataGridView1.CurrentRow.Cells("beholdningstype_navn").Value
            beholdningstype_mengde = DataGridView1.CurrentRow.Cells("beholdningstype_mengde").Value
        End If

        MessageBox.Show(beholdningstype_id & " " & beholdningstype_navn & " " & beholdningstype_mengde)

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into g_oops_22.test(test1,test2,test3) values ('" & beholdningstype_id & "', '" & beholdningstype_navn & "', '" & beholdningstype_mengde & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Bestilt blodprodukt")

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


    End Sub

    Private Sub ButtonSok_Click(sender As Object, e As EventArgs) Handles ButtonSok.Click
        Dim sokeValue As String = ""
        sokeValue = TextBoxSok.Text
        FilterData(sokeValue)
    End Sub
End Class