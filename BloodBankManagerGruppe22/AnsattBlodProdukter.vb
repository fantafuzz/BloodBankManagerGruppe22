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
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from g_oops_22.blodbeholdning"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("beholdningstype_navn")
                ListBox_Blodprodukter_Ansatte.Items.Add(sName)
            End While
            MysqlConn.Open()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try



    End Sub

    Private Sub Button_Utlevere_Blodprodukter_Click(sender As Object, e As EventArgs) Handles Button_Utlevere_Blodprodukter.Click

    End Sub
End Class