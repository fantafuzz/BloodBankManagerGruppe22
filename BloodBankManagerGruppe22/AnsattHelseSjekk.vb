Imports MySql.Data.MySqlClient

Public Class AnsattHelseSjekk
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim bruker_id As Integer
    Dim fornavn As String
    Dim etternavn As String
    Dim personnummer As String
    Dim siste_egenerklaering As DataRow

    Dim sql As New SQL_hookup()
    Dim spm As New Sporsmaal()

    Private Sub AnsattHelseSjekk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"


        'Her får vi deklarert vår database detaljer slik at man får tilkoblet seg til databasen via applikasjonen

        FilterData("")

        Dim column As DataGridViewColumn = gridBruker.Columns(0)
        column.Width = 100

        Dim column1 As DataGridViewColumn = gridBruker.Columns(1)
        column1.Width = 100

        Dim column2 As DataGridViewColumn = gridBruker.Columns(2)
        column2.Width = 100

        Dim column3 As DataGridViewColumn = gridBruker.Columns(3)
        column3.Width = 100

    End Sub
    Public Sub FilterData(valueToSearch As String)



        Dim searchQuery As String = "SELECT bruker.bruker_id, bruker.fornavn, bruker.etternavn, blodgiver.personnummer FROM bruker, blodgiver WHERE bruker.bruker_id = blodgiver.blodgiver_bruker_id AND CONCAT(bruker_id,fornavn, etternavn, personnummer, epost) like '%" & valueToSearch & "%';"

        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        gridBruker.DataSource = table
    End Sub

    Private Sub Logg_ut_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        AnsattNavigasjon.Show()
        Me.Close()

        'her kan man navigere seg tilbake til navigasjonform ansatte
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Logginn.Show()
        Me.Close()
        'her kan man logge ut av ansatthelsesjekk
    End Sub

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim value As String = tbSok.Text
        If value <> "" Then
            FilterData(value)
        End If
    End Sub

    Private Sub btnVelg_Click(sender As Object, e As EventArgs) Handles btnVelg.Click
        If Not gridBruker.CurrentRow Is Nothing Then
            bruker_id = gridBruker.CurrentRow.Cells("bruker_id").Value
            fornavn = gridBruker.CurrentRow.Cells("fornavn").Value
            etternavn = gridBruker.CurrentRow.Cells("etternavn").Value
            personnummer = gridBruker.CurrentRow.Cells("personnummer").Value
            siste_egenerklaering = sql.getSisteEgenerklaering(bruker_id)
            byttModus()
            fyllInn()
        Else
            MsgBox("Velg blodgiveren du utfører helsesjekk på.")
        End If
    End Sub

    Private Sub byttModus()
        PanelUtfor.Visible = Not (PanelUtfor.Visible)
        PanelVelg.Visible = Not (PanelVelg.Visible)
    End Sub

    Private Sub fyllInn()
        tbFornavn.Text = fornavn
        tbEtternavn.Text = etternavn
        tbSisteE.Text = siste_egenerklaering.Item("dato").ToString.Substring(0, 10)
        ListView1.Clear()
        ListView1.Columns.Add("Spørsmål", 700)
        ListView1.Columns.Add("Svar", 50)
        ListView1.LabelWrap = True

        For Each spmnr In spm.getListofSpmNr
            If spmnr Like "?_?" Then
                If siste_egenerklaering.Item(spmnr) = True Then
                    If spmnr <> "1_1" And spmnr <> "1_2" And spmnr <> "1_3" And spmnr <> "1_4" And spmnr <> "9_8" And spmnr <> "9_10" Then
                        Dim LVitem As ListViewItem = New ListViewItem(spm.getAnySpm(spmnr))
                        LVitem.SubItems.Add("Ja")
                        ListView1.Items.Add(LVitem)
                    End If
                ElseIf siste_egenerklaering.Item(spmnr) = False Then
                    If spmnr = "1_3" Or spmnr = "1_4" Then
                        Dim LVitem As ListViewItem = New ListViewItem(spm.getAnySpm(spmnr))
                        LVitem.SubItems.Add("Nei")
                        ListView1.Items.Add(LVitem)
                    End If
                End If
            End If
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        byttModus()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Dim status As Boolean
        If rbGodkjent.Checked Then
            status = True
        ElseIf rbIkkeGodkjent.Checked Then
            status = False
        Else
            Exit Sub
        End If
        sql.sendHelsesjekk(bruker_id, status)
    End Sub
End Class