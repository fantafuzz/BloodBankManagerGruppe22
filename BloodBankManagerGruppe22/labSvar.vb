﻿Imports MySql.Data.MySqlClient
Public Class labSvar

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand



    Private Sub labSvar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=; database=; Uid=; password="
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



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class