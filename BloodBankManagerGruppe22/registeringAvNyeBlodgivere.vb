Imports MySql.Data.MySqlClient
Public Class registeringAvNyeBlodgivere
    Dim tilkobling As MySqlConnection

    'Update: Har nå lagt til en del tilkoblinger til databasen med de ulike objektene i minside form. Har forsatt en del å legge til, har oprettet en ny minSide tabell
    ' i databasen. Jeg tenkte vi kunne ha en hel minside tabell i databasen hvor vi sender opplysninger fra vb.net minside form til denne tabell. Hva tenker dere om det?

    'får ikke konvertert integer som en string, og når jeg prøver å kjøre får jeg en melding om dette.




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim blodgivningLokasjon As String = ComboBox1.Text
        Dim fornavn As String = TextBox1.Text
        Dim etternavn As String = TextBox2.Text
        'Dim fødselsdato As Date = TextBox3.Text  'skal vi deklare fødselsdato datatype som en date, eller en vanlig integer?
        Dim personnummer As Integer = (TextBox4.Text)
        Dim adresse As String = TextBox5.Text   'her legger jeg adresse som en string, er dette riktig? siden adressen også inneholder tall
        'Dim postnummer As Integer = (TextBox6.Text)
        'Dim poststed As String = TextBox7.Text
        Dim telefonnummerEn As Integer = CInt(TextBox9.Text) 'konverterer string til int
        Dim telefonnummerTo As Integer = CInt(TextBox8.Text)  'konverterer string til int
        Dim epost As String = TextBox10.Text
        Dim blodBefore As String = CheckBox1.Text
        Dim hvilkenBlodbank As String = TextBox11.Text
        Dim samtykke As String = CheckBox2.Text
        Dim infoRodekors As String = CheckBox3.Text



        Dim sql As New MySqlCommand("INSERT INTO bruker (Fornavn, Etternavn) values (@fornavn, @etternavn)", tilkobling) 'skal vi legge til denne data i samme tabell som minside for mer oversikt?
        sql.Parameters.AddWithValue("@fornavn", fornavn)
        sql.Parameters.AddWithValue("@etternavn", etternavn)
        sql.ExecuteNonQuery()

        Dim sql1 As New MySqlCommand("INSERT INTO minsideNy (personnummer, adresse, telefonnummerEn, telefonnummerTo, epost, hvilkenBlodbank) values (@personnummer, @adresse, @telefonnummerEn, @telefonnummerTo, @epost, @hvilkenBlodbank)", tilkobling)
        'sql1.Parameters.AddWithValue("@birthdate", fødselsdato)
        sql1.Parameters.AddWithValue("@personnummer", personnummer)
        sql1.Parameters.AddWithValue("@adresse", adresse)
        sql1.Parameters.AddWithValue("@telefonnummerEn", telefonnummerEn)
        sql1.Parameters.AddWithValue("@telefonnummerTo", telefonnummerTo)
        sql1.Parameters.AddWithValue("@epost", epost)
        sql1.Parameters.AddWithValue("@hvilkenBlodbank", hvilkenBlodbank)
        sql1.ExecuteNonQuery()


        If CheckBox1.Checked Then 'har du gitt blod før - checkbox
            Dim sql2 As New MySqlCommand("INSERT INTO minsideNy(gittBlodFør) values(@gittBlodFør)", tilkobling)
            sql2.Parameters.AddWithValue("@gittBlodFør", blodBefore)
            sql2.ExecuteNonQuery()
        End If

        If CheckBox2.Checked Then 'samtykke av blodgiver
            Dim sql3 As New MySqlCommand("INSERT INTO minsideNy(samtykke) values(@samtykke)", tilkobling)
            sql3.Parameters.AddWithValue("@samtykke", samtykke)
            sql3.ExecuteNonQuery()
        End If

        If CheckBox3.Checked Then 'vil du motta informasjon fra Røde kors
            Dim sql4 As New MySqlCommand("INSERT INTO minsideNy(rødekorsInfo) values(@rødekorsInfo)", tilkobling)
            sql4.Parameters.AddWithValue("@rødekorsInfo", infoRodekors)
            sql4.ExecuteNonQuery()
        End If


        'DirectCast(ComboBox1.SelectedItem, String)

        egenSkjemaBolk1.Show()
        Me.Close()
    End Sub

    Private Sub registeringAvNyeBlodgivere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR")
        tilkobling.Open()
    End Sub
End Class


