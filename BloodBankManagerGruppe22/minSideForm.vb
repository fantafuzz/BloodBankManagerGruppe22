Imports MySql.Data.MySqlClient
Public Class minSideForm
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub minSideForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'her har jeg lagt inn bestilling av ny time til blodgiver. Det fungerer, men vi må legge merke til at vi:
        'må legge til en if/else dersom en dato+(tid) er allerede opptatt i tilegg til, må vi legge til en if/else:
        'hvor brukeren ikke kan bestille time før det har gått 3 måneder siden siste blodgivning.
        'for å legge in dato, må vi deklarere kolonnens datatype i mysql som en DATE, og tror den tar inn bare data på slik format: yyyy-MM-dd
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "Server=;Database=;Uid=;Pwd="
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO g_oops_22.minsideNy(nesteTime) values ('" & DateTimePicker1_nesteTime.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader



            MessageBox.Show("Data er lagret.")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim fornavn As String = TextBox1.Text
        'Dim etternavn As String = TextBox2.Text
        'Dim fødselsdato As String = TextBox3.Text
        'Dim personnummer As Integer = TextBox4.Text
        'Dim adresse As String = TextBox5.Text
        'Dim postnummer As Integer = TextBox6.Text
        'Dim poststed As String = TextBox7.Text
        'Dim tlfEn As Integer = TextBox9.Text
        'Dim tlfTo As Integer = TextBox8.Text
        'Dim epost As String = TextBox10.Text
        'Dim sistBlodgiv As String = TextBox11.Text

        'Skal vi lage nye variabler til minsideform, eller skal vi hente inn variabler som er sendt i registeringAvNyeBlodgivere form?




    End Sub
End Class