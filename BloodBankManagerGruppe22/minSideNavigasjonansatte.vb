Public Class minSideNavigasjonansatte
    Private Sub Bestill_Ny_BlodTime_Click(sender As Object, e As EventArgs) Handles Bestill_Ny_BlodTime.Click
        minSideAnsatte.Show()
    End Sub

    Private Sub Logg_ut_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        Me.Close()
        hovedForside_Innlogging.Show()
    End Sub
End Class