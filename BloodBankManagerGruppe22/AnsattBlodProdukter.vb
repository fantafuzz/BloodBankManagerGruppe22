Imports MySql.Data.MySqlClient
Public Class AnsattBlodProdukter
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Statistikk_Click(sender As Object, e As EventArgs) Handles Button_Tilbake_AnsattMinSide.Click
        Me.Close()
        AnsattNavigasjon.Show()
    End Sub

    Private Sub AnsattBlodProdukter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"



        FilterData("")

        'column size - datagridview
        Dim column As DataGridViewColumn = DataGridView1.Columns(0)
        column.Width = 160

        Dim column1 As DataGridViewColumn = DataGridView1.Columns(1)
        column1.Width = 160

        Dim column2 As DataGridViewColumn = DataGridView1.Columns(2)
        column2.Width = 160
    End Sub
    Public Sub FilterData(valueToSearch As String)

        Dim searchQuery As String = "select * from blodbeholdning"

        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub



    Private Sub Button_utlevering_av_blodprodukter_Click_1(sender As Object, e As EventArgs) Handles Button_utlevering_av_blodprodukter.Click
        Dim beholdningstype_id As Integer
        Dim beholdningstype_navn As String = ""
        Dim current_mengde As Integer

        If Not DataGridView1.CurrentRow Is Nothing Then
            beholdningstype_id = DataGridView1.CurrentRow.Cells("beholdningstype_id").Value
            beholdningstype_navn = DataGridView1.CurrentRow.Cells("beholdningstype_navn").Value
            current_mengde = DataGridView1.CurrentRow.Cells("beholdningstype_mengde").Value
        End If




        Dim mengdeViTar As Integer
        If IsNumeric(TextBox_mengde_blod.Text) Then
            mengdeViTar = current_mengde - mengdeViTar
        End If

        Dim gjenstaaendeMengde As Integer = current_mengde - mengdeViTar
        If gjenstaaendeMengde < 0 Then
            MessageBox.Show("Det er ikke mer tilgjenglig blod.")
        End If

        Dim mengdeViTarNegativ = -mengdeViTar
        Dim dato As Date
        dato = Date.Now
        Dim datostring As String = dato.ToString("YYYY-mm-dd")

        Try
            MysqlConn.Open()
            Dim utleverBlod As New MySqlCommand("INSERT INTO blodbeholdning_endring (endring_aarsak,endring_mengde,endring_blodbeholdning_id,dato) VALUES (@aarsak, @mengde, @dato, (SELECT blodbeholningstype_id FROM blodbeholdning WHERE blodbeholdningstype_id = @beholdningstype))", MysqlConn)

            utleverBlod.Parameters.AddWithValue("@endrmengde", mengdeViTarNegativ)
            utleverBlod.Parameters.AddWithValue("@beholdningstype", beholdningstype_id)
            utleverBlod.Parameters.AddWithValue("@dato", datostring)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        Try
            MysqlConn.Open()
            Dim utleverblod2 As New MySqlCommand("update blodbeholdning set beholdningstype_mengde = @endring where beholdningstype_id = @id")
            utleverblod2.Parameters.AddWithValue("@endring", gjenstaaendeMengde)
            utleverblod2.Parameters.AddWithValue("@id", beholdningstype_id)


            MessageBox.Show("Blodprodukt bestilt.")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub





End Class