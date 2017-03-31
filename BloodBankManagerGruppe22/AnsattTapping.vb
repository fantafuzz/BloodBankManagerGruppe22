Imports MySql.Data.MySqlClient
Public Class AnsattTapping
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub AnsattTapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"

        FilterData("")


        Dim column As DataGridViewColumn = GridBruker.Columns(0)
        column.Width = 100

        Dim column1 As DataGridViewColumn = GridBruker.Columns(1)
        column1.Width = 100

        Dim column2 As DataGridViewColumn = GridBruker.Columns(2)
        column2.Width = 100
    End Sub
    Public Sub FilterData(valueToSearch As String)



        Dim searchQuery As String = "SELECT bruker.bruker_id, bruker.fornavn, bruker.etternavn, blodgiver.personnummer FROM bruker, blodgiver WHERE bruker.bruker_id = blodgiver.blodgiver_bruker_id AND CONCAT(bruker_id,fornavn, etternavn, personnummer, epost) like '%" & valueToSearch & "%';"
        'Dim searchQuery As String = "Select * from bruker"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        GridBruker.DataSource = table


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nyttBlod = 400
        Dim dato As Date = Date.Today

        Dim bruker_id As Integer
        Dim fornavn As String = ""
        Dim etternavn As String = ""
        Dim personnummer As String = ""
        Dim currDate As Date = Date.Now
        Dim currDateString As String = currDate.ToString("yyyy-MM-dd")

        If Not GridBruker.CurrentRow Is Nothing Then
            bruker_id = GridBruker.CurrentRow.Cells("bruker_id").Value
            fornavn = GridBruker.CurrentRow.Cells("fornavn").Value
            etternavn = GridBruker.CurrentRow.Cells("etternavn").Value
            personnummer = GridBruker.CurrentRow.Cells("personnummer").Value
        End If

        SendSvar(bruker_id)


    End Sub

    Public Sub SendSvar(ByVal bruker As Integer)
        Dim currDate As Date = Date.Now
        Dim currDateString As String = currDate.ToString("YYYY-mm-dd")
        Try
            MysqlConn.Open()

            Dim sqlendring As New MySqlCommand("INSERT INTO blodbeholdning_endring (dato, endring_aarsak, endring_mengde, endring_blodbeholdning_id) VALUES (@dato, @aarsak, @mengde, (SELECT blodbeholdning_id FROM blodbeholdning, blodgiver, blodtype WHERE blodbeholdning.beholdningstype_navn = blodtype.blodtype_navn AND blodgiver.blodgiver_blodtype_id = blodtype.blodtype_id AND blodgiver.blodgiver_bruker_id = @bruker))")
            sqlendring.Parameters.AddWithValue("@dato", currDate)
            sqlendring.Parameters.AddWithValue("@aarsak", "Blodtapping")
            sqlendring.Parameters.AddWithValue("@mengde", 400)
            sqlendring.Parameters.AddWithValue("@bruker", bruker)

            Dim sqltapping As New MySqlCommand("INSERT INTO blodtapping (tapping_bruker_id, tapping_endring_id) VALUES ((SELECT bruker_id FROM bruker WHERE bruker_id = @bruker),(SELECT endring_id FROM blodbeholdning_endring WHERE endring_aarsak = @aarsak AND endring_mengde = @mengde AND dato = @dato AND endring_beholdning_id = (SELECT beholdning_id FROM blodbeholdning, blodgiver, blodtype WHERE blodbeholdning.beholdningstype_navn = blodtype.blodtype_navn AND blodgiver.blodgiver_blodtype_id = blodtype.blodtype_id AND blodgiver.blodgiver_bruker_id = @bruker)))")
            sqltapping.Parameters.AddWithValue("@aarsak", "Blodtapping")
            sqltapping.Parameters.AddWithValue("@mengde", 400)
            sqltapping.Parameters.AddWithValue("@dato", currDate)
            sqltapping.Parameters.AddWithValue("@bruker", bruker)

        Catch ex As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & ex.Message)
        Finally
            MysqlConn.Close()
        End Try
    End Sub



End Class