Imports MySql.Data.MySqlClient
Public Class BrukerAllInfo
    Dim sql As New SQL_hookup()

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click

    End Sub

    Private Sub BrukerAllInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userinfo As DataRow = sql.getAllinfo(Logginn.currentuser)

        tbFornavn.Text = userinfo.Item("fornavn")
        tbEtternavn.Text = userinfo.Item("etternavn")
        tbID.Text = userinfo.Item("bruker_id")
        tbEpost.Text = userinfo.Item("epost")
        tbAdr.Text = userinfo.Item("adresse")
        tbPostnr.Text = userinfo.Item("postnr")
        tbPoststed.Text = userinfo.Item("poststed")
        tbTlf1.Text = userinfo.Item("telefon_1")
        tbTlf2.Text = userinfo.Item("telefon_2")

    End Sub

    Private Sub endreInfo(ByVal hvaSkalEndres As String, ByVal nyVerdi As String)
        sql.endreSingleBruker(Logginn.currentuser, hvaSkalEndres, nyVerdi)
    End Sub

    Private Sub btnEndreFornavn_Click(sender As Object, e As EventArgs) Handles btnEndreFornavn.Click
        If Not tbFornavn.ReadOnly And tbFornavn.Text <> "" Then
            endreInfo("fornavn", tbFornavn.Text)
        End If
        tbFornavn.ReadOnly = Not tbFornavn.ReadOnly
    End Sub

    Private Sub btnEndreEtternavn_Click(sender As Object, e As EventArgs) Handles btnEndreEtternavn.Click
        tbEtternavn.ReadOnly = Not tbEtternavn.ReadOnly
        If Not tbEtternavn.ReadOnly And tbEtternavn.Text <> "" Then
            endreInfo("etternavn", tbEtternavn.Text)
        End If
    End Sub

    Private Sub btnEndreAdresse_Click(sender As Object, e As EventArgs) Handles btnEndreAdresse.Click
        tbAdr.ReadOnly = Not tbAdr.ReadOnly
        If Not tbAdr.ReadOnly And tbAdr.Text <> "" Then
            endreInfo("adresse", tbAdr.Text)
        End If
    End Sub

    Private Sub btnEndrePostnr_Click(sender As Object, e As EventArgs) Handles btnEndrePostnr.Click
        tbPostnr.ReadOnly = Not tbPostnr.ReadOnly
        tbPoststed.ReadOnly = Not tbPoststed.ReadOnly
        If Not tbPostnr.ReadOnly And tbPostnr.Text <> "" And tbPoststed.Text <> "" Then
            endreInfo("postnr", tbPostnr.Text)
            endreInfo("poststed", tbPoststed.Text)
        End If
    End Sub

    Private Sub btnEndreTelefon_Click(sender As Object, e As EventArgs) Handles btnEndreTelefon.Click
        tbTlf1.ReadOnly = Not tbTlf1.ReadOnly
        tbTlf2.ReadOnly = Not tbTlf2.ReadOnly
        If Not tbTlf1.ReadOnly And tbTlf1.Text <> "" And IsNumeric(tbTlf1.Text) Then
            endreInfo("telefon_1", tbTlf1.Text)
            If tbTlf2.Text <> "" And IsNumeric(tbTlf2.Text) Then
                endreInfo("telefon_2", tbTlf2.Text)
            End If
        End If
    End Sub

    Private Sub btnEndreEpost_Click(sender As Object, e As EventArgs) Handles btnEndreEpost.Click
        tbEpost.ReadOnly = Not tbEpost.ReadOnly
        If Not tbEpost.ReadOnly And tbEpost.Text <> "" Then
            endreInfo("epost", tbEpost.Text)
        End If
    End Sub
End Class