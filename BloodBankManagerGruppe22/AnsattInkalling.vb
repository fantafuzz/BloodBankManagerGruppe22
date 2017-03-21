Imports MySql.Data.MySqlClient

Public Class AnsattInkalling
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub minSideAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"




        FilterData("")

    End Sub
    Public Sub FilterData(valueToSeach As String)



        Dim searchQuery As String = "SELECT bruker.bruker_id, bruker.fornavn, bruker.etternavn, bruker.epost, blodgiver.personnummer FROM bruker, blodgiver WHERE bruker.bruker_id = blodgiver.blodgiver_bruker_id AND CONCAT(bruker_id,fornavn, etternavn, epost) like '%" & valueToSeach & "%';"

        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        GridBrukere.DataSource = table


    End Sub

    Private Sub ButtonLogUt_Click(sender As Object, e As EventArgs) Handles ButtonLogUt.Click
        Logginn.Show()
        Me.Close()
    End Sub 'logg ut





    Private Sub ButtonInnkall_Click(sender As Object, e As EventArgs) Handles ButtonInnkall.Click
        Dim bruker_id As Integer
        Dim fornavn As String = ""
        Dim etternavn As String = ""
        Dim epost As String = ""
        Dim personnummer As String = ""
        Dim currDate As Date = Date.Now
        Dim currDateString As String = currDate.ToString("yyyy-MM-dd")
        Dim info As String = "Dette var en test"

        If Not GridBrukere.CurrentRow Is Nothing Then
            bruker_id = GridBrukere.CurrentRow.Cells("bruker_id").Value
            fornavn = GridBrukere.CurrentRow.Cells("fornavn").Value
            etternavn = GridBrukere.CurrentRow.Cells("etternavn").Value
            epost = GridBrukere.CurrentRow.Cells("epost").Value
            personnummer = GridBrukere.CurrentRow.Cells("personnummer").Value
        End If

        MsgBox(bruker_id & " " & fornavn & " " & etternavn & " " & epost & " " & personnummer)

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into g_oops_22.time_bestilling(bestilling_bruker_id, dato, info) values ('" & bruker_id & "', '" & currDateString & "', '" & info & "')"
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

    Private Sub ButtonSok_Click(sender As Object, e As EventArgs) Handles ButtonSok.Click
        Dim sokeValue As String = ""
        sokeValue = TextBoxSok.Text
        FilterData(sokeValue)
    End Sub
End Class