Imports MySql.Data.MySqlClient
Public Class BrukerLabSvar

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand



    Private Sub labSvar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=mysql.stud.iie.ntnu.no; database=g_oops_22; Uid=g_oops_22; password=BtUDpVoR"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from g_oops_22.lab_svar"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("svar")
                ListBox1.Items.Add(sName)
            End While
            MysqlConn.Close()
        Catch ex As Exception

        End Try

        'INSERT INTO `lab_svar`(`svar_id`, `test_utfort`, `svar`, `svar_bruker_id`) VALUES ('1','Ja','Ditt blod er godkjent for donasjon.','2')



    End Sub

    Private Sub Button_tilbake_fra_lab_svar_Click(sender As Object, e As EventArgs) Handles Button_tilbake_fra_lab_svar.Click
        BrukerMinSide.Show()
        Me.Close()
    End Sub
End Class