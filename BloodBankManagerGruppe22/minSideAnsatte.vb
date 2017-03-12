Imports MySql.Data.MySqlClient

'huske å koble hver form og knapper hvor det trengs tilkboling til database, da vil det fungere å hente inn database verdier
Public Class minSideAnsatte
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub minSideAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=;Database=;Uid=;Pwd="
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from g_oops_22.minsideAnsatte" 'henter ut data fra tabell "minsideAnsatte"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim sName = READER.GetString("fornavn")  'her definerer vi hvilken kolonne du vil printe ut i combobox
                ComboBox1.Items.Add(sName) 'legger til ovenfor adressert variabel slik at vi får inn data fra den aktuelle tabellen.
            End While


            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hovedForside_Innlogging.Show()
        Me.Close()
    End Sub 'logg ut

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=;Database=;Uid=;Pwd="
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO g_oops_22.minsideAnsatte(ID,fornavn, etternavn, fødselsdato, personnummer, adresse, postnummer, poststed, telefonnummerEn, telefonnummerTo, epost, DOB) values ('" & TextBox_ID.Text & "','" & TextBox_Fnavn.Text & "','" & TextBox_Enavn.Text & "','" & TextBox_Fdato.Text & "','" & TextBox_Pnummer.Text & "', '" & TextBox_Adresse.Text & "','" & TextBox_PostNr.Text & "','" & TextBox_PostSted.Text & "','" & TextBox_TlfEn.Text & "','" & TextBox_TlfTo.Text & "', '" & TextBox_Epost.Text & "','" & DateTimePicker1_DOB.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader



            MessageBox.Show("Data er lagret.")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub 'save knapp

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=;Database=;Uid=;Pwd="
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update g_oops_22.minsideAnsatte set ID='" & TextBox_ID.Text & "', fornavn='" & TextBox_Fnavn.Text & "',etternavn='" & TextBox_Enavn.Text & "',fødselsdato='" & TextBox_Fdato.Text & "',personnummer='" & TextBox_Pnummer.Text & "',adresse= '" & TextBox_Adresse.Text & "',postnummer='" & TextBox_PostNr.Text & "',poststed='" & TextBox_PostSted.Text & "',telefonnummerEn='" & TextBox_TlfEn.Text & "',telefonnummerTo='" & TextBox_TlfTo.Text & "',epost= '" & TextBox_Epost.Text & "' where ID='" & TextBox_ID.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader



            MessageBox.Show("Data er oppdatert.")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub 'update knapp

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=;Database=;Uid=;Pwd="
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from g_oops_22.minsideAnsatte where ID='" & TextBox_ID.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader



            MessageBox.Show("Data er slettet.")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub 'delete knapp

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'her henter den inn verdier fra databasen til comboboxen, deretter når vi velger det aktuelle navnet/bruker vises informasjon om den aktuelle bruker.
        'her har jeg testet den til å hente inn verdier fra minsideAnsatte tabellen, vi må endre dette til minside brukerne, det er der de aktuelle blodgiverne tilhører.
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=;Database=;Uid=;Pwd="
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from g_oops_22.minsideAnsatte where fornavn='" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                TextBox_ID.Text = READER.GetString("ID")
                TextBox_Fnavn.Text = READER.GetString("fornavn")
                TextBox_Enavn.Text = READER.GetString("etternavn")
                'TextBox_Fdato.Text = READER.GetDateTime("fødselsdato") 'et problem: får ikke konvertert date inn til mysql database fra vb.net
                TextBox_Pnummer.Text = READER.GetString("personnummer")
                TextBox_Adresse.Text = READER.GetString("adresse")
                TextBox_PostNr.Text = READER.GetString("postnummer")
                TextBox_PostSted.Text = READER.GetString("poststed")
                TextBox_TlfEn.Text = READER.GetString("telefonnummerEn")
                TextBox_TlfTo.Text = READER.GetString("telefonnummerTo")
                TextBox_Epost.Text = READER.GetString("epost")

            End While


            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try











    End Sub
End Class