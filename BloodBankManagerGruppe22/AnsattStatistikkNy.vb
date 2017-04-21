Imports MySql.Data.MySqlClient
Public Class AnsattStatistikkNy
    Dim sql As New SQL_hookup()
    Private Sub hvorMyeBlodGitt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dSource As DataTable = sql.FilterData("")

        Dim s As New DataVisualization.Charting.Series
        s.ChartType = DataVisualization.Charting.SeriesChartType.Line
        s.Points.AddXY(10, 10)
        s.Points.AddXY(20, 20)
        s.Points.AddXY(30, 10)

        chartStat.Series.Add(s)





    End Sub



    Private Sub Button_tilbake_fra_lab_svar_Click(sender As Object, e As EventArgs) Handles Button_tilbake_fra_lab_svar.Click
        AnsattNavigasjon.Show()
        Me.Hide()
    End Sub
End Class