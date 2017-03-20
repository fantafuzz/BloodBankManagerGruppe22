Public Class AnsattMinSide
    Private Sub Bestill_Ny_BlodTime_Click(sender As Object, e As EventArgs) Handles Bestill_Ny_BlodTime.Click
        AnsattInkalling.Show()
    End Sub

    Private Sub Logg_ut_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        Me.Close()
        Logginn.Show()
    End Sub

    Private Sub Statistikk_Click(sender As Object, e As EventArgs) Handles Statistikk.Click

    End Sub
End Class