Imports MySql.Data.MySqlClient

Public Class AnsattHelseSjekk
    Public MysqlConn As MySqlConnection
    Public COMMAND As MySqlCommand
    Private Sub AnsattHelseSjekk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"


        'Her får vi deklarert vår database detaljer slik at man får tilkoblet seg til databasen via applikasjonen

        FilterData("")



    End Sub
    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "select * from helsesjekk"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        'I denne koden henter vi ut database verdier med SQL Syntax fra databasen vår
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


    Private Sub HvaErHemoglobinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HvaErHemoglobinToolStripMenuItem.Click
        MessageBox.Show("Hemoglobin er et protein som finnes i de røde blodlegemene i blodet. Tidligere ble dette kalt blodprosent.

 

Hemoglobin måles i antall gram pr 100 ml blod.

Blodbanken har nederste referanseområdet for å gi blod på 12,5 for kvinner og 13,5  for menn.

Disse matvarer inneholder jern og kan anbefales hvis hemoglobinverdien er lav:

Kjøtt
Fisk
Blodpølse og innmat, f. eks lever og torskerogn
Egg
Brød og kornprodukter
Grønnsaker, for eksempel rødbeter, broccoli og grønnkål
Tørket frukt, f. eks rosiner, aprikos og fiken
Frisk frukt, appelsin og kiwi
Jernholdig kost er ikke tilstrekkelig for alle blodgivere. Ved behov får man jerntabletter ved blodbanken.")


        'Dette er informasjon om hva er hemoglobin fra en menstrip som vi har hentet fra toolbox.
    End Sub
End Class