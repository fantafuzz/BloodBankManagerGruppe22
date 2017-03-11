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
        Dim personnummer As Integer = TextBox4.Text.ToString
        Dim adresse As String = TextBox5.Text   'her legger jeg adresse som en string, er dette riktig? siden adressen også inneholder tall
        Dim postnummer = TextBox6.Text
        Dim poststed As String = TextBox7.Text
        Dim telefonnummerEn As Integer = TextBox9.Text
        Dim telefonnummerTo As Integer = TextBox8.Text
        Dim epost As String = TextBox10.Text
        Dim blodBefore As String = CheckBox1.Text
        Dim hvilkenBlodbank As String = TextBox11.Text
        Dim samtykke As String = CheckBox2.Text
        Dim infoRodekors As String = CheckBox3.Text



        Dim sql As New MySqlCommand("insert into bruker (Fornavn, Etternavn) values (@fornavn, @etternavn)", tilkobling)
        sql.Parameters.AddWithValue("@fornavn", fornavn)
        sql.Parameters.AddWithValue("@etternavn", etternavn)
        sql.ExecuteNonQuery()

        Dim sql1 As New MySqlCommand("insert into minsideNy (personnummer, adresse, telefonnummerEn, telefonnummerTo, epost) values (@personnummer, @adresse, @telefonnummerEn, @telefonnummerTo, @epost)", tilkobling)
        'sql1.Parameters.AddWithValue("@birthdate", fødselsdato)
        sql1.Parameters.AddWithValue("@personnummer", personnummer)
        sql1.Parameters.AddWithValue("@adresse", adresse)
        sql1.Parameters.AddWithValue("@telefonnummerEn", telefonnummerEn)
        sql1.Parameters.AddWithValue("@telefonnummerTo", telefonnummerTo)
        sql1.Parameters.AddWithValue("@epost", epost)
        sql1.ExecuteNonQuery()






        egenSkjemaBolk1.Show()
        Me.Close()
    End Sub

    Private Sub registeringAvNyeBlodgivere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=;Database=;Uid=;Pwd=")
        tilkobling.Open()
    End Sub
End Class