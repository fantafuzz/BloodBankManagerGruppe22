﻿Imports MySql.Data.MySqlClient

Public Class Registrering
    Dim sql As New SQL_hookup()

    'dim tilkobling as new mysqlconnection()

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click 'Veldig mye skjemavalidering under
        Dim feil(2) As Boolean
        Dim anyfeil As Boolean = False
        If ComboBoxLok.SelectedIndex = -1 Or ComboBoxBlodType.SelectedIndex = -1 Then
            feil(2) = True
        End If
        If TextBoxFirstName.Text = "" Or TextBoxLastName.Text = "" Or TextBoxDoB.Text = "____-__-__" Or TextBoxPersonNum.Text = "" Or IsNumeric(TextBoxPersonNum.Text) = False Or TextBoxPassord.Text = "" Or ComboBoxKjonn.SelectedIndex = -1 Then
            feil(0) = True
        End If
        If TextBoxAdr.Text = "" Or TextBoxPostNr.Text = "" Or IsNumeric(TextBoxPostNr.Text) = False Or TextBoxPostSt.Text = "" Or TextBoxEmail.Text = "" Or TextBoxPhone1.Text = "" Or IsNumeric(TextBoxPhone1.Text) = False Then
            feil(1) = True
        End If
        If feil(0) = True Then
            anyfeil = True
            LabelFeilPerson.Visible = True
        End If
        If feil(1) = True Then
            anyfeil = True
            LabelFeilKontakt.Visible = True
        End If
        If feil(2) = True Then
            anyfeil = True
            LabelFeilKontakt.Visible = True
        End If
        If anyfeil Then
            Exit Sub
        End If
        Dim blodgivningLokasjon As String = ComboBoxLok.Text
        Dim fornavn As String = TextBoxFirstName.Text
        Dim etternavn As String = TextBoxLastName.Text
        Dim fodselsdato As String = TextBoxDoB.Text
        Dim personnummer As String = TextBoxPersonNum.Text
        Dim adresse As String = TextBoxAdr.Text
        Dim postnummer As Integer = CInt(TextBoxPostNr.Text)
        Dim poststed As String = TextBoxPostSt.Text
        Dim telefonnummerEn As String = TextBoxPhone1.Text
        Dim telefonnummerTo As String = ""
        If TextBoxPhone2.Text <> "" Then
            telefonnummerTo = TextBoxPhone2.Text
        End If
        Dim epost As String = TextBoxEmail.Text
        Dim kjonn As String = ComboBoxKjonn.Text
        Dim blodtype As Integer = ComboBoxBlodType.SelectedIndex
        Dim blodBefore As Boolean = False
        Dim hvilkenBlodbank As String = ""
        Dim samtykke As Boolean = False
        If CheckBoxGiveBefore.Checked Then
            blodBefore = True
            If TextBoxPrevBank.Text = "" Then
                LabelFeilBlod.Visible = True
                Exit Sub
            Else
                hvilkenBlodbank = TextBoxPrevBank.Text
            End If
            samtykke = CheckBoxGetInfo.Checked
        End If
        Dim infoRodekors As Boolean = CheckBoxGetInfo.Checked
        Dim passord As String = TextBoxPassord.Text

        sql.registrerNy(fornavn, etternavn, epost, passord, fodselsdato, personnummer, adresse, postnummer, poststed, telefonnummerEn, telefonnummerTo, kjonn, blodtype, blodgivningLokasjon, blodBefore, hvilkenBlodbank, samtykke, infoRodekors)

        Logginn.Show()
        Me.Close()
    End Sub

    Private Sub TextBoxPhone1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPhone1.TextChanged 'Du kan ikke skrive inn tlf2 før du har skrevet tlf1
        If TextBoxPhone1.Text = "" Then
            TextBoxPhone2.Enabled = False
        ElseIf TextBoxPhone1.Text <> "" Then
            TextBoxPhone2.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxGiveBefore_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxGiveBefore.CheckedChanged 'Ved å si at du har gitt før kan du skrive inn info om hvor du har gitt.
        If CheckBoxGiveBefore.Checked Then
            TextBoxPrevBank.Enabled = True
            CheckBoxPrevGet.Enabled = True
        End If
    End Sub
End Class


