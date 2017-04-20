Public Class BrukerEgenskjema
    'her har vi deklarert alle egenskjema spørsmålene i en class som kalles for BrukerEgenskjema.
    Dim spm1 As New Sporsmaal("1_1")
    Dim spm2 As New Sporsmaal("1_2")
    Dim spm3 As New Sporsmaal("1_3")
    Dim spm4 As New Sporsmaal("1_4")
    Dim spm5 As New Sporsmaal("1_5")
    Dim spm6 As New Sporsmaal("1_6")
    Dim spm7 As New Sporsmaal("2_1")
    Dim spm8 As New Sporsmaal("2_2")
    Dim spm9 As New Sporsmaal("2_3")
    Dim spm10 As New Sporsmaal("2_4")
    Dim spm11 As New Sporsmaal("2_5")
    Dim spm12 As New Sporsmaal("3_1")
    Dim spm13 As New Sporsmaal("3_2")
    Dim spm14 As New Sporsmaal("3_3")
    Dim spm15 As New Sporsmaal("3_4")
    Dim spm16 As New Sporsmaal("3_5")
    Dim spm17 As New Sporsmaal("3_6")
    Dim spm18 As New Sporsmaal("3_7")
    Dim spm19 As New Sporsmaal("4_1")
    Dim spm20 As New Sporsmaal("4_2")
    Dim spm21 As New Sporsmaal("4_3")
    Dim spm22 As New Sporsmaal("4_4")
    Dim spm23 As New Sporsmaal("4_5")
    Dim spm24 As New Sporsmaal("4_6")
    Dim spm25 As New Sporsmaal("4_7")
    Dim spm26 As New Sporsmaal("4_8")
    Dim spm27 As New Sporsmaal("4_9")
    Dim spm28 As New Sporsmaal("4_10")
    Dim spm29 As New Sporsmaal("5_1")
    Dim spm30 As New Sporsmaal("6_1")
    Dim spm31 As New Sporsmaal("6_2")
    Dim spm32 As New Sporsmaal("6_3")
    Dim spm33 As New Sporsmaal("6_4")
    Dim spm34 As New Sporsmaal("6_5")
    Dim spm35 As New Sporsmaal("6_6")
    Dim spm36 As New Sporsmaal("6_7")
    Dim spm37 As New Sporsmaal("6_8")
    Dim spm38 As New Sporsmaal("6_9")
    Dim spm39 As New Sporsmaal("6_10")
    Dim spm40 As New Sporsmaal("6_11")
    Dim spm41 As New Sporsmaal("6_12")
    Dim spm42 As New Sporsmaal("6_13")
    Dim spm43 As New Sporsmaal("6_14")
    Dim spm44 As New Sporsmaal("6_15")
    Dim spm45 As New Sporsmaal("7_1")
    Dim spm46 As New Sporsmaal("7_2")
    Dim spm47 As New Sporsmaal("7_3")
    Dim spm48 As New Sporsmaal("7_4")
    Dim spm49 As New Sporsmaal("8_1")
    Dim spm50 As New Sporsmaal("9_1")
    Dim spm51 As New Sporsmaal("9_2")
    Dim spm52 As New Sporsmaal("9_3")
    Dim spm53 As New Sporsmaal("9_4")
    Dim spm54 As New Sporsmaal("9_5")
    Dim spm55 As New Sporsmaal("9_6")
    Dim spm56 As New Sporsmaal("9_7")
    Dim spm57 As New Sporsmaal("9_8")
    Dim spm58 As New Sporsmaal("9_9")
    Dim spm59 As New Sporsmaal("9_10")
    Dim spm60 As New Sporsmaal("tillat_epost")
    Dim spm61 As New Sporsmaal("tillat_sms")
    Dim spm62 As New Sporsmaal("evt_info")

    Dim sql As New SQL_hookup()


    Private Function valider() As Boolean 'Sjekker at hvert spørsmål er svart på
        Dim anyError As Boolean = False
        Dim errors As New ArrayList
        Dim currentselect = TabControlEgenskjema.SelectedTab 'Setter currentselect til hvilken tab som er valgt
        For Each tab As TabPage In TabControlEgenskjema.TabPages 'Går gjennom alle tabs
            If tab Is currentselect Then 'Hvis tab-en den er på er den valgte
                For Each ctrl As Control In tab.Controls
                    If ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then 'Itererer gjennom hvert panel, og finner ut hvor mange unchecked radioknapper som finnes
                        Dim uncheckedRadios = From radio In ctrl.Controls.OfType(Of RadioButton)()
                                              Where Not radio.Checked And radio.Enabled
                                              Select radio.Name
                        Dim anyUnchecked As Integer = uncheckedRadios.Count
                        If anyUnchecked > 1 Then ' Om det er mere enn 1 unchecked radioknapp (1 unchecked er bra, 2 er dårlig)
                            anyError = True 'Det er en feil
                            errors.Add(ctrl.Tag) 'Feil-taggen legges i errors-array
                            Select Case ctrl.Tag Mod 2
                                Case 1
                                    ctrl.BackColor = Color.FromArgb(255, 200, 200)
                                Case 0
                                    ctrl.BackColor = Color.FromArgb(255, 225, 225)
                            End Select
                        End If
                    End If
                Next
                For Each ctrl As Control In tab.Controls
                    If ctrl.GetType() Is GetType(System.Windows.Forms.Label) Then 'Itererer gjennom hver label, og ser om tag-en til label er i error-listen
                        If errors.Contains(ctrl.Tag) Then
                            Select Case ctrl.Tag Mod 2
                                Case 1
                                    ctrl.BackColor = Color.FromArgb(255, 200, 200)
                                Case 0
                                    ctrl.BackColor = Color.FromArgb(255, 225, 225)
                            End Select
                        End If
                    End If
                Next
            End If
        Next
        Return anyError 'Returnerer true om det er funnet et spørsmål som ikke er svart på.
    End Function
    Private Sub kjonnCheck()
        Dim kjonn As String = sql.getKjonn(Logginn.currentuser)
        Select Case kjonn
            Case "Mann"
                RadioButton64.Enabled = False
                RadioButton63.Enabled = False
                RadioButton60.Enabled = False
                RadioButton59.Enabled = False
                RadioButton65.Enabled = False
                RadioButton66.Enabled = False
                RadioButton61.Enabled = False
                RadioButton62.Enabled = False
            Case "Kvinne"
                RadioButton67.Enabled = False
                RadioButton68.Enabled = False
        End Select
    End Sub
    Private Sub changeToDefault(ByVal tag As Integer) ' Endrer fargene tilbake til white og whitesmoke når du svarer.
        For Each tab As TabPage In TabControlEgenskjema.TabPages
            For Each ctrl As Control In tab.Controls
                If ctrl.GetType() Is GetType(System.Windows.Forms.Label) Or ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then
                    If ctrl.Tag = tag Then
                        Select Case ctrl.Tag Mod 2
                            Case 1
                                ctrl.BackColor = Color.WhiteSmoke
                            Case 0
                                ctrl.BackColor = Color.White
                        End Select
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub sendInn()
        Dim tillatSms As Integer = 0
        If CheckBoxSms.Checked Then
            tillatSms = 1
        End If
        Dim tillatEpost As Integer = 0
        If CheckBoxEpost.Checked Then
            tillatEpost = 1
        End If
        Dim evt As String = TextBoxEvt.Text
        Dim svarArray As New Hashtable()
        Dim finalArray As New Hashtable()
        For Each tab As TabPage In TabControlEgenskjema.TabPages
            For Each ctrl As Control In tab.Controls
                If ctrl.GetType Is GetType(Panel) Then
                    Dim checkedRadios = From radio In ctrl.Controls.OfType(Of RadioButton)()
                                        Where radio.Checked
                                        Select radio.Location.X, radio.Tag
                    For Each item In checkedRadios
                        svarArray.Add(item.Tag, item.X.ToString)
                    Next
                End If
            Next
        Next
        For i = 1 To 59 Step 1
            If svarArray.ContainsKey(CStr(i)) = False Then
                finalArray.Add(i, -1)
            ElseIf svarArray(CStr(i)) = 0 Then
                finalArray.Add(i, 1)
            ElseIf svarArray(CStr(i)) = 52 Then
                finalArray.Add(i, 0)
            Else
                finalArray.Add(i, -1)
            End If
        Next
        finalArray.Add(60, tillatEpost)
        finalArray.Add(61, tillatSms)
        sql.SendSvar(Logginn.currentuser, finalArray, evt)
    End Sub
    Private Sub endreForKjonn()
        Dim kjonn As String = sql.getKjonn(Logginn.currentuser)
        Select Case kjonn.ToLower
            Case "annet"
                RadioButton67.Enabled = False
                RadioButton68.Enabled = False
            Case "kvinne"
                RadioButton68.Enabled = False
                RadioButton67.Enabled = False
        End Select
    End Sub
    Private Sub ButtonNeste_Click(sender As Object, e As EventArgs) Handles ButtonNeste.Click
        If valider() Then
            LabelFeilMelding.Show()
        Else
            If TabControlEgenskjema.SelectedIndex < 9 Then
                TabControlEgenskjema.SelectedIndex += 1
            End If
        End If
    End Sub
    Private Sub ButtonForrige_Click(sender As Object, e As EventArgs) Handles ButtonForrige.Click
        If TabControlEgenskjema.SelectedIndex > 0 Then
            TabControlEgenskjema.SelectedIndex -= 1
        End If
    End Sub

    Private Sub RadioButtonAll_CheckedChanged(sender As Object, e As EventArgs)
        changeToDefault(DirectCast(sender, RadioButton).Tag) 'Her bruker vi directcast. Vet ikke hvorfor. Det fungerte.
    End Sub

    Private Sub egenSkjemaTempStorage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'side 3 spm 15 //feil skriftstørrelse, får ikke vist hele spørsmål

        For i = 1 To 59
            changeToDefault(i)
        Next


        LabelSpm1.Text = spm1.getText
        LabelSpm2.Text = spm2.getText
        LabelSpm3.Text = spm3.getText
        LabelSpm4.Text = spm4.getText
        LabelSpm5.Text = spm5.getText
        LabelSpm6.Text = spm6.getText
        LabelSpm7.Text = spm7.getText
        LabelSpm8.Text = spm8.getText
        LabelSpm9.Text = spm9.getText
        LabelSpm10.Text = spm10.getText
        LabelSpm11.Text = spm11.getText
        LabelSpm12.Text = spm12.getText
        LabelSpm13.Text = spm13.getText
        LabelSpm14.Text = spm14.getText
        LabelSpm15.Text = spm15.getText
        LabelSpm16.Text = spm16.getText
        LabelSpm17.Text = spm17.getText
        LabelSpm18.Text = spm18.getText
        LabelSpm19.Text = spm19.getText
        LabelSpm20.Text = spm20.getText
        LabelSpm21.Text = spm21.getText
        LabelSpm22.Text = spm22.getText
        LabelSpm23.Text = spm23.getText
        LabelSpm24.Text = spm24.getText
        LabelSpm25.Text = spm25.getText
        LabelSpm26.Text = spm26.getText
        LabelSpm27.Text = spm27.getText
        LabelSpm28.Text = spm28.getText
        LabelSpm29.Text = spm29.getText
        LabelSpm30.Text = spm30.getText
        LabelSpm31.Text = spm31.getText
        LabelSpm32.Text = spm32.getText
        LabelSpm33.Text = spm33.getText
        LabelSpm34.Text = spm34.getText
        LabelSpm35.Text = spm35.getText
        LabelSpm36.Text = spm36.getText
        LabelSpm37.Text = spm37.getText
        LabelSpm38.Text = spm38.getText
        LabelSpm39.Text = spm39.getText
        LabelSpm40.Text = spm40.getText
        LabelSpm41.Text = spm41.getText
        LabelSpm42.Text = spm42.getText
        LabelSpm43.Text = spm43.getText
        LabelSpm44.Text = spm44.getText
        LabelSpm45.Text = spm45.getText
        LabelSpm46.Text = spm46.getText
        LabelSpm47.Text = spm47.getText
        LabelSpm48.Text = spm48.getText
        LabelSpm49.Text = spm49.getText
        LabelSpm50.Text = spm50.getText
        LabelSpm51.Text = spm51.getText
        LabelSpm52.Text = spm52.getText
        LabelSpm53.Text = spm53.getText
        LabelSpm54.Text = spm54.getText
        LabelSpm55.Text = spm55.getText
        LabelSpm56.Text = spm56.getText
        LabelSpm57.Text = spm57.getText
        LabelSpm58.Text = spm58.getText
        LabelSpm59.Text = spm59.getText
        CheckBoxEpost.Text = spm60.getText
        CheckBoxSms.Text = spm61.getText

        For Each tab As TabPage In TabControlEgenskjema.TabPages 'Itererer gjennom hver tab
            For Each ctrl As Control In tab.Controls
                If ctrl.GetType() Is GetType(System.Windows.Forms.Panel) Then 'For hvert panel i hver tab
                    Dim radios = From radio In ctrl.Controls.OfType(Of RadioButton)() 'Legg alle radioknapper inn i radios
                                 Select radio
                    For Each x In radios 'for hver radioknapp i radios
                        AddHandler DirectCast(x, RadioButton).CheckedChanged, AddressOf RadioButtonAll_CheckedChanged 'Legg til radioknapp.checkedchanged som en eventhandler for radiobuttonall_checkedchanged sub-en
                    Next
                End If
            Next
        Next 'Denne sparer masse skriving, der alternativet er å skriver private sub x(sender as object, e as eventargs) handles radiobutton1, radiobutton2 ... radiobutton 120.

    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        sendInn()
        MsgBox("Skjema er lagret i vår database.")
        Me.Close()
        BrukerMinSide.Show()
    End Sub
End Class