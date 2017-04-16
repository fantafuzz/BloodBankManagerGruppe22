Imports MySql.Data.MySqlClient
Public Class BrukerBestill
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_bestill_ny_time_blod_bruker_blodgiver.Click

        'under deklarer vi tilkoblingen til databasen vår til MySQL.




        'vi må fikse sql syntaxen under


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            'under legger vi inn month calender verdien som blir valgt inn i databasen vår ved hjelp av SQL Syntax.
            Query = "insert into g_oops_22.time_bestilling(bestilling_id,dato) values (1, '" & MonthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd") & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader




            MysqlConn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub kalender_bestilling_blodgiver_tilbake__Click(sender As Object, e As EventArgs) Handles kalender_bestilling_blodgiver_tilbake_.Click

        'her kan man navigere seg tilbake til minside for brukere. Og da blir automatisk kalender bestilling blodgiver formen avsluttet.
        BrukerMinSide.Show()
        Me.Close()
    End Sub

End Class