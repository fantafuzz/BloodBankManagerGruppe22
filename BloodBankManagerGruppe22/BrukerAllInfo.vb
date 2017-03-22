Imports MySql.Data.MySqlClient
Public Class BrukerAllInfo
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=mysql.stud.iie.ntnu.no;database=g_oops_22; Uid=g_oops_22; password=BtUDpVoR;"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "update g_oops_22.bruker set bruker_id='" & TextBox_Brukerid.Text & "',fornavn='" & TextBox_fornavn.Text & "', etternavn='" & TextBox_etternavn.Text & "',epost='" & TextBox_epost.Text & "' where bruker_id ='" & TextBox_Brukerid.Text & "'"



            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Personalia er oppdatert.")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub BrukerAllInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class