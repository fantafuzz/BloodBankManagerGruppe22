Imports MySql.Data.MySqlClient

Public Class registeringAvNyeBlodgivere
    Dim sql As New SQL_hookup("g_oops_22", "BtUDpVoR", "g_oops_22", "mysql.stud.iie.ntnu.no")

    'dim tilkobling as new mysqlconnection()

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click

        If ComboBoxLok.SelectedIndex = -1 Then
            LabelFeilMelding.Text = "Du må velge avdeling du ønsker å gi blod hos"
            LabelFeilMelding.Location = New Point(163, 20)
            ComboBoxLok.Focus()
            Exit Sub
        ElseIf comboBoxBlodType.SelectedIndex = -1 Then
            LabelFeilMelding.Text = "Du må velge blodtype. Om du er usikker, spør en ansatt"
            LabelFeilMelding.Location = New Point(623, 39)
            Exit Sub
        ElseIf TextBoxFirstName.Text = "" Or TextBoxLastName.Text = "" Then
            LabelFeilMelding.Text = "Du må skrive inn fornavn og etternavn"
            LabelFeilMelding.Location = New Point(386, 93)
            TextBoxFirstName.Focus()
            Exit Sub
        ElseIf TextBoxDoB.Text = "" Then
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
        ElseIf TextBoxPostNr.Text = "" Or IsNumeric(TextBoxPostNr.Text) = False Or TextBoxPostSt.Text = "" Then
            LabelFeilMelding.Text = "Du må skrive inn gyldig postnummer og poststed"
            LabelFeilMelding.Location = New Point(355, 253)
            TextBoxPostNr.Focus()
            Exit Sub
        ElseIf TextBoxPhone1.Text = "" Or IsNumeric(TextBoxPhone1.Text) = False Then
            LabelFeilMelding.Text = "Du må skrive inn et gyldig telefonnummer"
                LabelFeilMelding.Location = New Point(376, 295)
                TextBoxPhone1.Focus()
            Exit Sub
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
        Dim personnummer As String = TextBoxPersonNum.Text
        Dim adresse As String = TextBoxAdr.Text   'String er alle tegn, som "!#"%&/321426asdfasdfa" er en godkjent string.
        Dim postnummer As Integer = CInt(TextBoxPostNr.Text)
        Dim poststed As String = TextBoxPostSt.Text
        Dim telefonnummerEn As String = TextBoxPhone1.Text
        Dim telefonnummerTo As String = ""
        If TextBoxPhone2.Text <> "" Then
            telefonnummerTo = CInt(TextBoxPhone2.Text)
        End If
        Dim epost As String = TextBoxEmail.Text
        Dim kjonn As String
        If RadioButtonKvinne.Checked Then
            kjonn = "kvinne"
        ElseIf RadioButtonMann.Checked Then
            kjonn = "mann"
        Else
            kjonn = ":("
        End If
        Dim blodtype As Integer = ComboBoxBlodType.SelectedIndex
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

        sql.registrerNy(fornavn, etternavn, epost, passord, fodselsdato, personnummer, adresse, postnummer, poststed, telefonnummerEn, telefonnummerTo, kjonn, blodtype, blodgivningLokasjon, blodBefore, hvilkenBlodbank, samtykke, infoRodekors)

        egenSkjemaBolk1.Show()
        Me.Close()
    End Sub

    '  Private Sub registeringAvNyeBlodgivere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '       tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_22;Uid=g_oops_22;Pwd=BtUDpVoR")
    '       tilkobling.Open()
    '   End Sub

    Private Sub TextBoxPhone1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPhone1.TextChanged
        If TextBoxPhone1.Text = "" Then
            TextBoxPhone2.Enabled = False
        ElseIf TextBoxPhone1.Text <> "" Then
            TextBoxPhone2.Enabled = True
        End If
    End Sub
End Class


