Imports MySql.Data.MySqlClient

Public Class registeringAvNyeBlodgivere


    Dim tilkobling As MySqlConnection



    'Update: Har nå lagt til en del tilkoblinger til databasen med de ulike objektene i minside form. Har forsatt en del å legge til, har oprettet en ny minSide tabell
    ' i databasen. Jeg tenkte vi kunne ha en hel minside tabell i databasen hvor vi sender opplysninger fra vb.net minside form til denne tabell. Hva tenker dere om det?

    'får ikke konvertert integer som en string, og når jeg prøver å kjøre får jeg en melding om dette.




    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click

        If ComboBoxLok.SelectedIndex = -1 Then
            LabelFeilMelding.Text = "Du må velge avdeling du ønsker å gi blod hos"
            LabelFeilMelding.Location = New Point(163, 20)
            ComboBoxLok.Focus()
            Exit Sub
        ElseIf comboBoxBlodType.SelectedIndex = -1 Then
            LabelFeilMelding.Text = "Du må velge blodtype. Om du er usikker, spør en ansatt"
            LabelFeilMelding.Location = New Point(623, 39)
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
        ElseIf TextBoxPassord.Text = "" Then
            LabelFeilMelding.Text = "Du må skrive inn ønsket passord"
            LabelFeilMelding.Location = New Point(733, 105)
            TextBoxPassord.Focus()
            Exit Sub
        ElseIf RadioButtonMann.Checked = False And RadioButtonKvinne.Checked = False Then
            LabelFeilMelding.Text = "Du må velge et kjønn"
            LabelFeilMelding.Location = New Point(458, 93)
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
        Dim kjonn As String
        If RadioButtonKvinne.Checked Then
            kjonn = "kvinne"
        ElseIf RadioButtonMann.Checked Then
            kjonn = "mann"
        Else
            kjonn = ":("
        End If
        Dim blodtype As String = ComboBoxBlodType.SelectedIndex
        Dim blodBefore As Boolean = False
        Dim hvilkenBlodbank As String = ""
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
        Dim passord As String = TextBoxPassord.Text



        Dim sqlAddBruker As New MySqlCommand("INSERT INTO bruker (fornavn, etternavn, epost, passord) values (@fornavn, @etternavn, @epost, @passord)", tilkobling) 'skal vi legge til denne data i samme tabell som minside for mer oversikt? Nei, for det fjerner integriteten til tabellen.
        sqlAddBruker.Parameters.AddWithValue("@fornavn", fornavn)
        sqlAddBruker.Parameters.AddWithValue("@etternavn", etternavn)
        sqlAddBruker.Parameters.AddWithValue("@epost", epost)
        sqlAddBruker.Parameters.AddWithValue("@passord", passord)
        sqlAddBruker.ExecuteNonQuery()

        '      Dim sqlGetBrukerId As New MySqlCommand("SELECT bruker_id FROM bruker WHERE fornavn = @fornavn AND etternavn = @etternavn AND epost = @epost AND passord = @passord")
        '      Dim brukerid As Integer
        '       sqlGetBrukerId.Parameters.AddWithValue("@fornavn", fornavn)
        '      sqlGetBrukerId.Parameters.AddWithValue("@etternavn", etternavn)
        '      sqlGetBrukerId.Parameters.AddWithValue("@epost", epost)
        '      sqlGetBrukerId.Parameters.AddWithValue("@passord", passord)
        '       Dim reader = sqlGetBrukerId.ExecuteReader()
        '          brukerid = reader("bruker_id")
        '       End While
        Dim sqlAddBlodgiver As New MySqlCommand("INSERT INTO blodgiver (blodgiver_bruker_id, fodselsdato, personnummer, adresse, , postnr, poststed, telefon_1, telefon_2, epost, kjonn, blodgiver_blodtype_id, onkset_lok, gitt_for, hvor_gitt, samtykke_for, modta_rode_kors) values ((SELECT bruker_id FROM bruker WHERE @fornavn AND etternavn = @etternavn AND epost = @epost AND passord = @passord), @personnummer, @adresse, @telefonnummerEn, @telefonnummerTo, @epost, @kjonn, (SELECT blodtype_id FROM blodtype WHERE blodtype_id = @blodtype), @onsket_lok, @gitt_for, @hvor_gitt, @samtykke_for, @modta_rode_kors)", tilkobling)
        sqlAddBlodgiver.Parameters.AddWithValue("@fornavn", fornavn)
        sqlAddBlodgiver.Parameters.AddWithValue("@etternavn", etternavn)
        sqlAddBlodgiver.Parameters.AddWithValue("@epost", epost)
        sqlAddBlodgiver.Parameters.AddWithValue("@passord", passord)
        sqlAddBlodgiver.Parameters.AddWithValue("@personnummer", personnummer)
        sqlAddBlodgiver.Parameters.AddWithValue("@adresse", adresse)
        sqlAddBlodgiver.Parameters.AddWithValue("@telefonnummerEn", telefonnummerEn)
        sqlAddBlodgiver.Parameters.AddWithValue("@telefonnummerTo", telefonnummerTo)
        sqlAddBlodgiver.Parameters.AddWithValue("@epost", epost)
        sqlAddBlodgiver.Parameters.AddWithValue("@kjonn", kjonn)
        sqlAddBlodgiver.Parameters.AddWithValue("@blodtype", blodtype)
        sqlAddBlodgiver.Parameters.AddWithValue("@onsket_lok", blodgivningLokasjon)
        sqlAddBlodgiver.Parameters.AddWithValue("@gitt_for", blodBefore)
        sqlAddBlodgiver.Parameters.AddWithValue("@hvor_gitt", hvilkenBlodbank)
        sqlAddBlodgiver.Parameters.AddWithValue("@samtykke_for", samtykke)
        sqlAddBlodgiver.Parameters.AddWithValue("@modta_rode_kors", infoRodekors)
        sqlAddBlodgiver.ExecuteNonQuery()

        egenSkjemaBolk1.Show()
        Me.Close()
    End Sub

    Private Sub registeringAvNyeBlodgivere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=;Database=;Uid=;Pwd=")
        tilkobling.Open()
    End Sub
End Class


