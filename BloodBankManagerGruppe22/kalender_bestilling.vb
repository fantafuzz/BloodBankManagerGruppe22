﻿Imports MySql.Data.MySqlClient
Public Class kalender_bestilling
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=;Database=;Uid=;Pwd="
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into g_oops_22.time_bestilling(bestilling_bruker_id, bestilling_dato) values (27, '" & MonthCalendar1.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader



            MessageBox.Show("Ny time er bestilt.")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class