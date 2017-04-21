Imports MySql.Data.MySqlClient
Public Class AnsattBlodProdukter
    Dim mengde As Integer
    Dim sql As New SQL_hookup()
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Close()
        AnsattNavigasjon.Show()
    End Sub

    Private Sub AnsattBlodProdukter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGridProdukt.DataSource = sql.getBlodprodukter()

        Dim column As DataGridViewColumn = dataGridProdukt.Columns(0)
        column.Width = 160

        Dim column1 As DataGridViewColumn = dataGridProdukt.Columns(1)
        column1.Width = 160

        Dim column2 As DataGridViewColumn = dataGridProdukt.Columns(2)
        column2.Width = 160

        pnlLager.Hide()
        pnlMottak.Hide()
        pnlUtlever.Hide()
        btnTilbakeSame.Hide()
    End Sub



    Private Sub btnUtlever_Click(sender As Object, e As EventArgs) Handles btnUtlever.Click
        Dim beholdningstype_id As Integer
        Dim current_mengde As Integer

        If Not dataGridProdukt.CurrentRow Is Nothing Then
            beholdningstype_id = dataGridProdukt.CurrentRow.Cells("id").Value
            current_mengde = dataGridProdukt.CurrentRow.Cells("Mengde").Value
        Else
            Exit Sub
        End If

        If IsNumeric(tbUtlever.Text) Then
            If CInt(tbUtlever.Text) > 0 Then
                mengde = tbUtlever.Text
            Else
                tbUtlever.Text = ""
                MsgBox("Skriv inn en positiv mengde.")
            End If
        Else
            tbUtlever.Text = ""
            MsgBox("Skriv inn mengden Ml du vil utlevere")
            Exit Sub
        End If

        If mengde > current_mengde Then
            MsgBox("Mengden du har skrevet inn er større enn mengden vi har på lager.")
            Exit Sub
        End If
        tbUtlever.Text = ""
        sql.MottaUtleverBlod(-mengde, beholdningstype_id)
        dataGridProdukt.DataSource = sql.getBlodprodukter()
        MsgBox("Endring er registrert")
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Not dataGridProdukt.CurrentRow Is Nothing Then
            tbUtlever.Text = dataGridProdukt.CurrentRow.Cells("Mengde").Value
        End If
    End Sub

    Private Sub btnMottak_Click(sender As Object, e As EventArgs) Handles btnMottak.Click
        Dim beholdningstype_id As Integer
        Dim current_mengde As Integer

        If Not dataGridProdukt.CurrentRow Is Nothing Then
            beholdningstype_id = dataGridProdukt.CurrentRow.Cells("id").Value
            current_mengde = dataGridProdukt.CurrentRow.Cells("Mengde").Value
        Else
            Exit Sub
        End If

        If IsNumeric(tbMottak.Text) Then
            If CInt(tbMottak.Text) > 0 Then
                mengde = tbMottak.Text
            Else
                tbMottak.Text = ""
                MsgBox("Skriv inn en positiv mengde.")
            End If
        Else
            tbMottak.Text = ""
            MsgBox("Skriv inn mengden Ml du vil utlevere")
            Exit Sub
        End If
        tbMottak.Text = ""
        sql.MottaUtleverBlod(mengde, beholdningstype_id)
        dataGridProdukt.DataSource = sql.getBlodprodukter()
        MsgBox("Endring er registrert")
    End Sub

    Private Sub btnTilMottak_Click(sender As Object, e As EventArgs) Handles btnTilMottak.Click
        pnlNav.Hide()
        pnlLager.Show()
        pnlMottak.Show()
        btnTilbakeSame.Show()
        btnTilbake.Hide()
    End Sub

    Private Sub btnTilUtlevering_Click(sender As Object, e As EventArgs) Handles btnTilUtlevering.Click
        pnlNav.Hide()
        pnlLager.Show()
        pnlUtlever.Show()
        btnTilbakeSame.Show()
        btnTilbake.Hide()
    End Sub

    Private Sub btnTilbakeSame_Click(sender As Object, e As EventArgs) Handles btnTilbakeSame.Click
        pnlNav.Show()
        pnlLager.Hide()
        pnlUtlever.Hide()
        pnlMottak.Hide()
        btnTilbakeSame.Hide()
    End Sub
End Class