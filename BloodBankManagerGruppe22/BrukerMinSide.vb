Imports MySql.Data.MySqlClient
Public Class BrukerMinSide
    Dim sql As New SQL_hookup()
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
        Me.Hide()
    End Sub

    Private Sub Statistikk_Click(sender As Object, e As EventArgs)
        AnsattStatistikkNy.Show()
        Me.Close()
    End Sub

    Private Sub MINSIDENAVIGASJON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim navn As String = sql.getNavn(Logginn.currentuser)
        LabelOverskrift.Text = "Velkommen " & navn & "!"
    End Sub

    Private Sub Hvor_Mye_Blod_Har_jeg_gitt_til_blodbanken_Click(sender As Object, e As EventArgs)
        AnsattStatistikkNy.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        egenSkjemaTempStorage.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        helseSjekkBlodgiver.Show()
        Me.Hide()
    End Sub
End Class