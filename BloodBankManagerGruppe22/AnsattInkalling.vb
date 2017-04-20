﻿Imports MySql.Data.MySqlClient

Public Class AnsattInkalling
    Dim bruker_id As Integer
    Dim fornavn As String = ""
    Dim etternavn As String = ""
    Dim epost As String = ""
    Dim personnummer As String = ""
    Dim info As String = "Dette var en test"
    Dim sql As New SQL_hookup()
    Private Sub minSideAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brukerData As DataTable = sql.FilterData("")
        If Not brukerData Is Nothing Then
            GridBrukere.DataSource = brukerData
            Dim column As DataGridViewColumn = GridBrukere.Columns(0)
            column.Width = 160

            Dim column1 As DataGridViewColumn = GridBrukere.Columns(1)
            column1.Width = 160

            Dim column2 As DataGridViewColumn = GridBrukere.Columns(2)
            column2.Width = 160
        End If



    End Sub
    Private Sub ButtonInnkall_Click(sender As Object, e As EventArgs) Handles ButtonInnkall.Click


        If Not GridBrukere.CurrentRow Is Nothing Then
            bruker_id = GridBrukere.CurrentRow.Cells("bruker_id").Value
            fornavn = GridBrukere.CurrentRow.Cells("fornavn").Value
            etternavn = GridBrukere.CurrentRow.Cells("etternavn").Value
        End If

        sql.bestillTime(bruker_id, info)

        'her legger vi inn måndekalender value i databasen vår ved hjelp av sql syntax.


    End Sub

    Private Sub ButtonTilbake_Click(sender As Object, e As EventArgs) Handles ButtonTilbake.Click
        AnsattNavigasjon.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim value As String = tbSok.Text
        If value <> "" Then
            GridBrukere.DataSource = sql.FilterData(value)
        End If
    End Sub
    '21.04.2017
    Private Sub GridBrukere_SelectionChanged(sender As Object, e As EventArgs) Handles GridBrukere.SelectionChanged
        If Not GridBrukere.CurrentRow Is Nothing Then
            bruker_id = GridBrukere.CurrentRow.Cells("bruker_id").Value
            fornavn = GridBrukere.CurrentRow.Cells("fornavn").Value
            etternavn = GridBrukere.CurrentRow.Cells("etternavn").Value

            Dim datestring As String = sql.getSisteBlodgivning(bruker_id)
            If datestring <> "" Then
                Dim d As String = datestring.Substring(0, 2)
                Dim m As String = datestring.Substring(3, 2)
                Dim y As String = datestring.Substring(6, 4)
                Dim sisteDato As DateTime = New DateTime(CInt(y), CInt(m), CInt(d))
                Dim forsteDato As DateTime = sisteDato.AddMonths(3)
                Kalender1.MinDate = forsteDato
            Else
                Kalender1.MinDate = DateTime.Today
            End If
        End If
    End Sub

    Private Sub Button_inkall_inn_til_time_Click(sender As Object, e As EventArgs) Handles Button_inkall_inn_til_time.Click

    End Sub
End Class