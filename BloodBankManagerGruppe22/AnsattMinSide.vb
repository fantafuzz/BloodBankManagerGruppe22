Public Class AnsattMinSide
    Private Sub Bestill_Ny_BlodTime_Click(sender As Object, e As EventArgs) Handles Bestill_Ny_BlodTime.Click
        AnsattInkalling.Show()
    End Sub

    Private Sub Logg_ut_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        Me.Close()
        Logginn.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        AnsattBlodProdukter.Show()
    End Sub

    Private Sub AnsattMinSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Statistikk_Click(sender As Object, e As EventArgs) Handles Statistikk.Click
        AnsattStatistikk.Show()
    End Sub
End Class