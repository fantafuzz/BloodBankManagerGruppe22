Imports MySql.Data.MySqlClient
Public Class BrukerStatistikk
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub hvorMyeBlodGitt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=mysql.stud.iie.ntnu.no; database=g_oops_22; Uid=g_oops_22; password=BtUDpVoR"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from g_oops_22.statistikk"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            'While READER.Read
            '    Dim sName = READER.GetString("beholdningstype_mengde")
            '    ListBox1.Items.Add(sName)
            'End While
            MysqlConn.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button_tilbake_fra_lab_svar_Click(sender As Object, e As EventArgs) Handles Button_tilbake_fra_lab_svar.Click
        BrukerMinSide.Show()
        Me.Close()
    End Sub
End Class