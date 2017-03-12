Imports MySql.Data.MySqlClient

Public Class registeringAvNyeBlodgivere


    Dim tilkobling As MySqlConnection



    'Update: Har nå lagt til en del tilkoblinger til databasen med de ulike objektene i minside form. Har forsatt en del å legge til, har oprettet en ny minSide tabell
    ' i databasen. Jeg tenkte vi kunne ha en hel minside tabell i databasen hvor vi sender opplysninger fra vb.net minside form til denne tabell. Hva tenker dere om det?

    'får ikke konvertert integer som en string, og når jeg prøver å kjøre får jeg en melding om dette.




    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click

        If ComboBoxLok.SelectedIndex = -1 Then
            LabelFeilMelding.Text = "Du må velge avdeling du ønsker å gi blod hos"
            LabelFeilMelding.Location = New Point(249, 39)
            ComboBoxLok.Focus()
            Exit Sub
        ElseIf TextBoxFirstName.Text = "" Or TextBoxLastName.Text = "" Then
            LabelFeilMelding.Text = "Du må skrive inn fornavn og etternavn"
            LabelFeilMelding.Location = New Point(386, 93)
            TextBoxFirstName.Focus()
            Exit Sub
        ElseIf TextBoxDoB.Text = "" Or IsNumeric(TextBoxDoB.Text) = False Then
            LabelFeilMelding.Text = "Du må skrive inn gyldig fødselsdato"
            LabelFeilMelding.Location = New Point(292, 140)
            TextBoxDoB.Focus()
            Exit Sub
        ElseIf TextBoxPersonNum.Text = "" Or IsNumeric(TextBoxPersonNum.Text) = False Then
            LabelFeilMelding.Text = "Du må skrive inn gyldig personnummer"
            LabelFeilMelding.Location = New Point(205, 175)
            TextBoxPersonNum.Focus()
            Exit Sub
        ElseIf TextBoxAdr.Text = "" Then
            LabelFeilMelding.Text = "Du må skrive inn en adresse"
            LabelFeilMelding.Location = New Point(386, 211)
            TextBoxAdr.Focus()
            Exit Sub
        ElseIf TextBoxPostNr.Text = "" Or IsNumeric(TextBoxPostNr.Text) Or TextBoxPostSt.Text = "" = False Then
            LabelFeilMelding.Text = "Du må skrive inn gyldig postnummer og poststed"
            LabelFeilMelding.Location = New Point(355, 253)
            TextBoxPostNr.Focus()
            Exit Sub
        ElseIf TextBoxPhone1.Text = "" Or IsNumeric(TextBoxPhone1.Text) = False Then
            If TextBoxPhone2.Text = "" Or IsNumeric(TextBoxPhone2.Text) = False Then
                LabelFeilMelding.Text = "Du må skrive inn et gyldig telefonnummer"
                LabelFeilMelding.Location = New Point(376, 295)
                TextBoxPhone1.Focus()
                Exit Sub
            Else
                TextBoxPhone1.Text = TextBoxPhone2.Text
                TextBoxPhone2.Text = ""
            End If
        ElseIf TextBoxEmail.Text = "" Then
            LabelFeilMelding.Text = "Du må skrive inn en gyldig epostadresse"
            LabelFeilMelding.Location = New Point(386, 332)
            TextBoxEmail.Focus()
            Exit Sub
        ElseIf TextBoxBrukernavn.Text = "" Then
            LabelFeilMelding.Text = "Du må skrive inn et ønsket brukernavn"
            LabelFeilMelding.Location = New Point(733, 79)
            TextBoxBrukernavn.Focus()
            Exit Sub
        ElseIf TextBoxPassord.Text = "" Then
            LabelFeilMelding.Text = "Du må skrive inn ønsket passord"
            LabelFeilMelding.Location = New Point(733, 105)
            TextBoxPassord.Focus()
            Exit Sub
        End If

        Dim blodgivningLokasjon As String = ComboBoxLok.Text
        Dim fornavn As String = TextBoxFirstName.Text
        Dim etternavn As String = TextBoxLastName.Text
        Dim fodselsdato As String = TextBoxDoB.Text  'Har bare daten som en string, siden du kan legge inn en date som en riktig formatert string.
        Dim personnummer As Integer = (TextBoxPersonNum.Text)
        Dim adresse As String = TextBoxAdr.Text   'String er alle tegn, som "!#"%&/321426asdfasdfa" er en godkjent string.
        Dim postnummer As Integer = CInt(TextBoxPostNr.Text)
        Dim poststed As String = TextBoxPostSt.Text
        Dim telefonnummerEn As Integer = CInt(TextBoxPhone1.Text)
        Dim telefonnummerTo As Integer = CInt(TextBoxPhone2.Text)
        Dim epost As String = TextBoxEmail.Text
        Dim blodBefore As Boolean = False
        Dim hvilkenBlodbank As String
        Dim samtykke As Boolean = False
        If CheckBoxGiveBefore.Checked Then
            blodBefore = True
            If TextBoxPrevBank.Text = "" Then
                LabelFeilMelding.Text = "Du må skrive inn hvilken blodbank du var i før"
                LabelFeilMelding.Location = New Point(327, 413)
                TextBoxPrevBank.Focus()
                Exit Sub
            Else
                hvilkenBlodbank = TextBoxPrevBank.Text
            End If
            samtykke = CheckBoxGetInfo.Checked
        End If
        Dim infoRodekors As Boolean = CheckBoxGetInfo.Checked
        Dim brukernavn As String = TextBoxBrukernavn.Text
        Dim passord As String = TextBoxPassord.Text




        Dim sql As New MySqlCommand("INSERT INTO bruker (fornavn, etternavn, brukernavn, passord) values (@fornavn, @etternavn, @brukernavn, @passord)", tilkobling) 'skal vi legge til denne data i samme tabell som minside for mer oversikt? Nei, for det fjerner integriteten til tabellen.
        sql.Parameters.AddWithValue("@fornavn", fornavn)
        sql.Parameters.AddWithValue("@etternavn", etternavn)
        sql.Parameters.AddWithValue("@brukernavn", brukernavn)
        sql.Parameters.AddWithValue("@passord", passord)
        sql.ExecuteNonQuery()

        Dim sql1 As New MySqlCommand("INSERT INTO blodgiver (fodselsdato, personnummer, adresse, , postnr, poststed, telefon_1, telefon_2, epost, kjonn, ) values (@personnummer, @adresse, @telefonnummerEn, @telefonnummerTo, @epost, @hvilkenBlodbank)", tilkobling)
        'sql1.Parameters.AddWithValue("@birthdate", fødselsdato) ' JEG KOM HIT I GÅR SØNDAG LUL
        sql1.Parameters.AddWithValue("@personnummer", personnummer)
        sql1.Parameters.AddWithValue("@adresse", adresse)
        sql1.Parameters.AddWithValue("@telefonnummerEn", telefonnummerEn)
        sql1.Parameters.AddWithValue("@telefonnummerTo", telefonnummerTo)
        sql1.Parameters.AddWithValue("@epost", epost)
        sql1.Parameters.AddWithValue("@hvilkenBlodbank", hvilkenBlodbank)
        sql1.ExecuteNonQuery()


        If CheckBoxGiveBefore.Checked Then 'har du gitt blod før - checkbox
            Dim sql2 As New MySqlCommand("INSERT INTO minsideNy(gittBlodFør) values(@gittBlodFør)", tilkobling)
            sql2.Parameters.AddWithValue("@gittBlodFør", blodBefore)
            sql2.ExecuteNonQuery()
        End If

        If CheckBoxPrevGet.Checked Then 'samtykke av blodgiver
            Dim sql3 As New MySqlCommand("INSERT INTO minsideNy(samtykke) values(@samtykke)", tilkobling)
            sql3.Parameters.AddWithValue("@samtykke", samtykke)
            sql3.ExecuteNonQuery()
        End If

        If CheckBoxGetInfo.Checked Then 'vil du motta informasjon fra Røde kors
            Dim sql4 As New MySqlCommand("INSERT INTO minsideNy(rødekorsInfo) values(@rødekorsInfo)", tilkobling)
            sql4.Parameters.AddWithValue("@rødekorsInfo", infoRodekors)
            sql4.ExecuteNonQuery()
        End If



        egenSkjemaBolk1.Show()
        Me.Close()
    End Sub

    Private Sub registeringAvNyeBlodgivere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=;Database=;Uid=;Pwd=")
        tilkobling.Open()
    End Sub
End Class


