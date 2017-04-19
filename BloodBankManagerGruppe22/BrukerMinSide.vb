Imports MySql.Data.MySqlClient
Public Class BrukerMinSide
    Dim sql As New SQL_hookup()
    Private Sub ButtonEndre_Click(sender As Object, e As EventArgs) Handles ButtonEndre.Click
        BrukerAllInfo.Show()
    End Sub

    Private Sub ButtonBestill_Click(sender As Object, e As EventArgs) Handles ButtonBestill.Click
        BrukerBestill.Show()

    End Sub

    Private Sub ButtonLoggut_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        Logginn.Show()
        Me.Close()
    End Sub

    Private Sub ButtonLabSvar_Click(sender As Object, e As EventArgs) Handles ButtonLabSvar.Click
        BrukerLabSvar.Show()
        Me.Hide()
    End Sub



    Private Sub brukerMinSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim navn As String = sql.getNavn(Logginn.currentuser)
        LabelOverskrift.Text = "Velkommen " & navn & "!"
    End Sub

    Private Sub ButtonEgenerklering_Click(sender As Object, e As EventArgs) Handles ButtonEgenerklering.Click
        Me.Hide()
        BrukerEgenskjema.Show()
        'Brukeregenskjema formen blir vist fram. Minside bruker blir avsluttet.

    End Sub
End Class