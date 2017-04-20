Imports MySql.Data.MySqlClient
Public Class BrukerAllInfo
    Dim sql As New SQL_hookup()

    Private Sub Button2_Click(sender As Object, e As EventArgs)

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
        If tbFornavn.ReadOnly = False And tbFornavn.Text <> "" Then
            endreInfo("fornavn", tbFornavn.Text)
        End If
        tbFornavn.ReadOnly = Not tbFornavn.ReadOnly
        If Not tbFornavn.ReadOnly Then
            btnEndreFornavn.Text = "Lagre"
        Else
            btnEndreFornavn.Text = "Endre"
        End If
    End Sub

    Private Sub btnEndreEtternavn_Click(sender As Object, e As EventArgs) Handles btnEndreEtternavn.Click
        If tbEtternavn.ReadOnly = False And tbEtternavn.Text <> "" Then
            endreInfo("etternavn", tbEtternavn.Text)
        End If
        tbEtternavn.ReadOnly = Not tbEtternavn.ReadOnly
        If Not tbEtternavn.ReadOnly Then
            btnEndreEtternavn.Text = "Lagre"
        Else
            btnEndreEtternavn.Text = "Endre"
        End If
    End Sub

    Private Sub btnEndreAdresse_Click(sender As Object, e As EventArgs) Handles btnEndreAdresse.Click
        If tbAdr.ReadOnly = False And tbAdr.Text <> "" Then
            endreInfo("adresse", tbAdr.Text)
        End If
        tbAdr.ReadOnly = Not tbAdr.ReadOnly
        If Not tbAdr.ReadOnly Then
            btnEndreAdresse.Text = "Lagre"
        Else
            btnEndreAdresse.Text = "Endre"
        End If
    End Sub

    Private Sub btnEndrePostnr_Click(sender As Object, e As EventArgs) Handles btnEndrePostnr.Click
        If tbPostnr.ReadOnly = False And tbPostnr.Text <> "" And tbPoststed.Text <> "" Then
            endreInfo("postnr", tbPostnr.Text)
            endreInfo("poststed", tbPoststed.Text)
        End If
        tbPostnr.ReadOnly = Not tbPostnr.ReadOnly
        tbPoststed.ReadOnly = Not tbPoststed.ReadOnly
        If Not tbPostnr.ReadOnly Then
            btnEndrePostnr.Text = "Lagre"
        Else
            btnEndrePostnr.Text = "Endre"
        End If
    End Sub

    Private Sub btnEndreTelefon_Click(sender As Object, e As EventArgs) Handles btnEndreTelefon.Click
        If tbTlf1.ReadOnly = False And tbTlf1.Text <> "" And IsNumeric(tbTlf1.Text) Then
            endreInfo("telefon_1", tbTlf1.Text)
            If tbTlf2.Text <> "" And IsNumeric(tbTlf2.Text) Then
                endreInfo("telefon_2", tbTlf2.Text)
            End If
        End If
        tbTlf1.ReadOnly = Not tbTlf1.ReadOnly
        tbTlf2.ReadOnly = Not tbTlf2.ReadOnly
        If Not tbTlf1.ReadOnly Then
            btnEndreTelefon.Text = "Lagre"
        Else
            btnEndreTelefon.Text = "Endre"
        End If
    End Sub

    Private Sub btnEndreEpost_Click(sender As Object, e As EventArgs) Handles btnEndreEpost.Click
        If tbEpost.ReadOnly = False And tbEpost.Text <> "" Then
            endreInfo("epost", tbEpost.Text)
        End If
        tbEpost.ReadOnly = Not tbEpost.ReadOnly
        If Not tbEpost.ReadOnly Then
            btnEndreEpost.Text = "Lagre"
        Else
            btnEndreEpost.Text = "Endre"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        BrukerMinSide.Show()
    End Sub
End Class