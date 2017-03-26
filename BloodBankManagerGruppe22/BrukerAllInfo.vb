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

            'endre sql syntax slik at man får mottatt data fra både blodgivere tabell og bruker tabell
            'nå fungerer det å motta bruker data fra bruker tabell i brukerAllinfoform. Det går i tilegg ann å oppdatere infoen.
            'endre sql syntax slik at den aktuelle logget bruker får inn sin data i form.

            Query1 = "select * from g_oops_22.bruker"

            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_Brukerid.Text = READER.GetInt32("bruker_id")
                TextBox_fornavn.Text = READER.GetString("fornavn")
                'TextBox_adresse.Text = READER.GetString("adresse")
                'TextBox_postnr.Text = READER.GetInt32("postnr")
                'TextBox_poststed.Text = READER.GetString("poststed")
                'TextBox_Tlf1.Text = READER.GetInt32("telefon_1")
                'TextBox_tlf2.Text = READER.GetInt32("telefon_2")
                TextBox_etternavn.Text = READER.GetString("etternavn")
                TextBox_epost.Text = READER.GetString("epost")
            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class