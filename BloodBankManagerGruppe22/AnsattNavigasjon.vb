Public Class AnsattNavigasjon

    Private Sub Bestill_Ny_BlodTime_Click(sender As Object, e As EventArgs) Handles Bestill_Ny_BlodTime.Click
        AnsattInkalling.Show()
        Me.Hide()

        'her navigerer man seg fram til ansattinnkalling form og avslutter ansatt navigasjon
    End Sub

    Private Sub Logg_ut_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        Me.Close()
        Logginn.Show()

        'her har man muligheten til å logge ut og dermed navigerer man seg fram til logginn form
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_blodprodukter.Click
        Me.Close()
        AnsattBlodProdukter.Show()
        'her viderekobler man seg til blodprodukter ansatt form og avslutter ansatt navigasjon form
    End Sub



    Private Sub Statistikk_Click(sender As Object, e As EventArgs) Handles Statistikk.Click
        AnsattStatistikkNy.Show()
        Me.Hide()

        'her viderekobler man seg til statistikk ansatt form og avslutter ansatt navigasjon form
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        AnsattTapping.Show()
        Me.Close()
        'her viderekobler man seg til tapping ansatt form og avslutter ansatt navigasjon form
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_tapping_blod.Click
        AnsattTapping.Show()
        Me.Close()

        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Button_helsesjekk_Click_(sender As Object, e As EventArgs) Handles Button_helsesjekk.Click
        AnsattHelseSjekk.Show()
        Me.Close()

        'her viderekobler man seg til ansatt helsesjekk form og avslutter ansatt navigasjon form
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        AdminPanel.Show()
    End Sub

    Private Sub AnsattNavigasjon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Logginn.currentuserType = 0 Then
            btnAdmin.Hide()
        ElseIf Logginn.currentusertype = 1 Then
            btnAdmin.Show()
        End If
    End Sub
End Class