Imports MySql.Data.MySqlClient

Public Class AnsattHelseSjekk
    Dim bruker_id As Integer
    Dim fornavn As String
    Dim etternavn As String
    Dim personnummer As String
    Dim siste_egenerklaering As DataRow

    Dim sql As New SQL_hookup()
    Dim spm As New Sporsmaal()

    Private Sub AnsattHelseSjekk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridBruker.DataSource = sql.FilterData("") 'Henter data fra databasen via SQL_hookup

        Dim column As DataGridViewColumn = gridBruker.Columns(0)
        column.Width = 100

        Dim column1 As DataGridViewColumn = gridBruker.Columns(1)
        column1.Width = 100

        Dim column2 As DataGridViewColumn = gridBruker.Columns(2)
        column2.Width = 100

        Dim column3 As DataGridViewColumn = gridBruker.Columns(3)
        column3.Width = 100

    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        AnsattNavigasjon.Show()
        Me.Close()
    End Sub

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click 'Oppdaterer datagrid til å kun vise brukere som matcher søket.
        Dim value As String = tbSok.Text
        If value <> "" Then
            gridBruker.DataSource = sql.FilterData(value)
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

    Private Sub byttModus() 'Bytter visible-propertien til panelene
        PanelUtfor.Visible = Not (PanelUtfor.Visible)
        PanelVelg.Visible = Not (PanelVelg.Visible)
    End Sub

    Private Sub fyllInn() 'Fyller inn listview med alle spørsmål som bør forklares. Spørsmål som ikke følger standarden "ja = dårlig" eller "nei = bra" er hardkodet inn.
        tbFornavn.Text = fornavn
        tbEtternavn.Text = etternavn
        tbSisteE.Text = siste_egenerklaering.Item("dato").ToString.Substring(0, 10)
        ListView1.Clear()
        ListView1.Columns.Add("Spørsmål", 700)
        ListView1.Columns.Add("Svar", 50)

        For Each spmnr In spm.getListofSpmNr 'Går gjennom alle spørsmålsnummerene til spørsmålene som er lagt inn i sporsmal-klassen.
            If spmnr Like "?_?" Then 'Vi er kun interesert i spørsmålene som har nummer som er formatert ?_?
                If siste_egenerklaering.Item(spmnr) = True Then 'Sjekker om brukeren svarte ja på spørsmålet, i sin siste egenerklæring
                    If spmnr <> "1_1" And spmnr <> "1_2" And spmnr <> "1_3" And spmnr <> "1_4" And spmnr <> "9_8" And spmnr <> "9_10" Then 'utelukker noen spørsmål som det ikke er et problem om de svarte ja på.
                        Dim LVitem As ListViewItem = New ListViewItem(spm.getAnySpm(spmnr))
                        LVitem.SubItems.Add("Ja")
                        ListView1.Items.Add(LVitem)
                    End If
                ElseIf siste_egenerklaering.Item(spmnr) = False Then 'Om brukeren svarte nei på disse
                    If spmnr = "1_3" Or spmnr = "1_4" Then 'Og det er et av disse spørsmålene, er det et problem.
                        Dim LVitem As ListViewItem = New ListViewItem(spm.getAnySpm(spmnr))
                        LVitem.SubItems.Add("Nei")
                        ListView1.Items.Add(LVitem)
                    End If
                End If
            End If
        Next


    End Sub

    Private Sub ButtonVelgNy_Click(sender As Object, e As EventArgs) Handles btnVelgNy.Click
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