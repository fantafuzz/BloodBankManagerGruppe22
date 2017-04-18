Imports MySql.Data.MySqlClient
Public Class helseSjekkBlodgiver
    Public MysqlConn As MySqlConnection
    Public COMMAND As MySqlCommand

    Private Sub helseSjekkBlodgiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR"

        FilterData("")

    End Sub

    Public Sub FilterData(valueToSearch As String)
        'sql id kan endres slik at brukerid = blodgiver bruker id //tror det er litt feil i sql syntax forsatt
        Dim searchQuery As String = "select * from helsesjekk"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Logginn.Show()
        Me.Close()
    End Sub

    Private Sub Logg_ut_Click(sender As Object, e As EventArgs) Handles Logg_ut.Click
        BrukerMinSide.Show()
        Me.Close()
    End Sub
End Class