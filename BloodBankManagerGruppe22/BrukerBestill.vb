Imports MySql.Data.MySqlClient
Public Class BrukerBestill
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_bestill_ny_time_blod_bruker_blodgiver.Click




        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into g_oops_22.test(test1,test2) values (1, '" & MonthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd") & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader



            MessageBox.Show("Ny time er bestilt.")
            MessageBox.Show("Tusen Takk for din interesse til blod donasjon. Vi i blodbanken setter stor pris på ditt bidrag og håper du forsetter med det!")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub kalender_bestilling_blodgiver_tilbake__Click(sender As Object, e As EventArgs) Handles kalender_bestilling_blodgiver_tilbake_.Click
        BrukerMinSide.Show()
        Me.Close()
    End Sub
End Class