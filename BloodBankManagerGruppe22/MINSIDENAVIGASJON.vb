﻿Imports MySql.Data.MySqlClient
Public Class MINSIDENAVIGASJON
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Endre_mine_opplysninger.Click
        minSideForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bestill_Ny_BlodTime.Click
        kalender_bestilling.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        hovedForside_Innlogging.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Lab_Svar.Click
        labSvar.Show()
    End Sub

    Private Sub Statistikk_Click(sender As Object, e As EventArgs) Handles Statistikk.Click
        Statistikk.Show()
    End Sub
End Class