Imports MySql.Data.MySqlClient
Public Class BrukerAllInfo
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'oppdaterer personalia
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=mysql.stud.iie.ntnu.no;database=g_oops_22; Uid=g_oops_22; password=BtUDpVoR;"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "update g_oops_22.bruker set bruker_id='" & TextBox_Brukerid.Text & "',fornavn='" & TextBox_fornavn.Text & "', etternavn='" & TextBox_etternavn.Text & "',epost='" & TextBox_epost.Text & "' where bruker_id ='" & TextBox_Brukerid.Text & "'"



            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Personalia er oppdatert.")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub BrukerAllInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=mysql.stud.iie.ntnu.no;database=g_oops_22; Uid=g_oops_22; password=BtUDpVoR;"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query1 As String


            Query1 = "select bruker.bruker_id, bruker.fornavn, bruker.etternavn, bruker.epost, bruker.passord, blodgiver.adresse,blodgiver.postnr,blodgiver.poststed,blodgiver.telefon_1,blodgiver.telefon_2 from g_oops_22.bruker,g_oops_22.blodgiver where bruker.bruker_id=blodgiver.blodgiver_bruker_id and bruker.bruker_id = @id "

            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_Brukerid.Text = READER.GetInt32("bruker_id")
                TextBox_fornavn.Text = READER.GetString("fornavn")
                TextBox_adresse.Text = READER.GetString("adresse")
                TextBox_postnr.Text = READER.GetInt32("postnr")
                TextBox_poststed.Text = READER.GetString("poststed")
                TextBox_Tlf1.Text = READER.GetInt32("telefon_1")
                TextBox_tlf2.Text = READER.GetInt32("telefon_2")
                TextBox_etternavn.Text = READER.GetString("etternavn")
                TextBox_epost.Text = READER.GetString("epost")
            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        'Dim epost As String
        'Dim adresse As String
        'Try
        '    mysqlConn.Open()
        '    Dim sqlLogInn As New MySqlCommand("SELECT blogiver.adresse, bruker.epost FROM bruker, blodgiver WHERE blogiver.bruker_id = bruker.bruker_id AND bruker.bruker_id = @id", connection)
        '    sqlLogInn.Parameters.AddWithValue("@id", 27)
        '    Dim reader As MySqlDataReader = sqlLogInn.ExecuteReader
        '    If reader.HasRows Then
        '        reader.Read()
        '        epost = reader("epost")
        '        adresse = reader("adresse")
        '    End If
        'Catch ex As MySqlException
        '    MsgBox(ex)
        'Finally
        '    mysqlConn.Close()
        'End Try

    End Sub
End Class