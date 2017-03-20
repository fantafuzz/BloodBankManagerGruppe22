Imports MySql.Data.MySqlClient
Public Class BrukerMinSide
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Endre_mine_opplysninger.Click
        BrukerAllInfo.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bestill_Ny_BlodTime.Click
        BrukerBestill.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        Logginn.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Lab_Svar.Click
        BrukerLabSvar.Show()
    End Sub

    Private Sub Statistikk_Click(sender As Object, e As EventArgs) Handles Statistikk.Click
        AnsattStatistikk.Show()
    End Sub

    Private Sub MINSIDENAVIGASJON_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Hvor_Mye_Blod_Har_jeg_gitt_til_blodbanken_Click(sender As Object, e As EventArgs) Handles Hvor_Mye_Blod_Har_jeg_gitt_til_blodbanken.Click
        BrukerStatistikk.Show()
    End Sub
End Class