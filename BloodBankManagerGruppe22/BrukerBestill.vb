Imports MySql.Data.MySqlClient
Public Class BrukerBestill
    Dim sql As New SQL_hookup()
    Private Sub btnBestill_Click(sender As Object, e As EventArgs) Handles btnBestill.Click
        Dim dato As DateTime = kalender1.SelectionRange.Start
        Dim y As Integer = dato.Year
        Dim m As Integer = dato.Month
        Dim d As Integer = dato.Day
        Dim usedate As String = y & "-" & m & "-" & d

        sql.bestillTime(Logginn.currentuser, "Time bestillt av blodgiver", usedate)
        MsgBox("Time er bestilt!")
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        BrukerMinSide.Show()
        Me.Close()
    End Sub

    Private Sub BrukerBestill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datestring As String = sql.getSisteBlodgivning(Logginn.currentuser)
        If datestring <> "" Then
            Dim d As String = datestring.Substring(0, 2)
            Dim m As String = datestring.Substring(3, 2)
            Dim y As String = datestring.Substring(6, 4)
            Dim sisteDato As DateTime = New DateTime(CInt(y), CInt(m), CInt(d))
            Dim forsteDato As DateTime = sisteDato.AddMonths(3)
            kalender1.MinDate = forsteDato
        Else
            kalender1.MinDate = DateTime.Today
        End If
    End Sub
End Class