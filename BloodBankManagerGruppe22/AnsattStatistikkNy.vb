Imports MySql.Data.MySqlClient
Public Class AnsattStatistikkNy
    Dim sql As New SQL_hookup()
    Private Sub hvorMyeBlodGitt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridStat.Hide()
    End Sub



    Private Sub Button_tilbake_fra_lab_svar_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        AnsattNavigasjon.Show()
        Me.Hide()
    End Sub

    Private Sub btnTapStat_Click(sender As Object, e As EventArgs) Handles btnTapStat.Click
        gridStat.Show()
        lblHjelp.Hide()
        gridStat.DataSource = sql.getAntallTapp()
    End Sub

    Private Sub btnGiverStat_Click(sender As Object, e As EventArgs) Handles btnGiverStat.Click
        gridStat.Show()
        lblHjelp.Hide()
        gridStat.DataSource = sql.getTappByBlodgiver()
    End Sub
End Class