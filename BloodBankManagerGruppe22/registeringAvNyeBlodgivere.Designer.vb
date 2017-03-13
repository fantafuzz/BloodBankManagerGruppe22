<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registeringAvNyeBlodgivere
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.ComboBoxLok = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPersonNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxAdr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPostNr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPostSt = New System.Windows.Forms.TextBox()
        Me.TextBoxPhone1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxPhone2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckBoxGiveBefore = New System.Windows.Forms.CheckBox()
        Me.TextBoxPrevBank = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBoxPrevGet = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBoxGetInfo = New System.Windows.Forms.CheckBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxDoB = New System.Windows.Forms.MaskedTextBox()
        Me.LabelFeilMelding = New System.Windows.Forms.Label()
        Me.TextBoxBrukernavn = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxPassord = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fornavn:"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(115, 94)
        Me.TextBoxFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(391, 22)
        Me.TextBoxFirstName.TabIndex = 1
        '
        'ComboBoxLok
        '
        Me.ComboBoxLok.FormattingEnabled = True
        Me.ComboBoxLok.Items.AddRange(New Object() {"St. Olavs Hospital Orkdal", "St. Olavs Hospital Trondheim"})
        Me.ComboBoxLok.Location = New System.Drawing.Point(16, 44)
        Me.ComboBoxLok.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxLok.Name = "ComboBoxLok"
        Me.ComboBoxLok.Size = New System.Drawing.Size(307, 24)
        Me.ComboBoxLok.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hvor ønsker du å gi blod?"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(115, 126)
        Me.TextBoxLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(391, 22)
        Me.TextBoxLastName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Etternavn:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Føsdselsdato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(273, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "(YYYY-MM-DD)"
        '
        'TextBoxPersonNum
        '
        Me.TextBoxPersonNum.Location = New System.Drawing.Point(115, 212)
        Me.TextBoxPersonNum.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPersonNum.Name = "TextBoxPersonNum"
        Me.TextBoxPersonNum.Size = New System.Drawing.Size(149, 22)
        Me.TextBoxPersonNum.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 215)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Personnummer:"
        '
        'TextBoxAdr
        '
        Me.TextBoxAdr.Location = New System.Drawing.Point(115, 256)
        Me.TextBoxAdr.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxAdr.Name = "TextBoxAdr"
        Me.TextBoxAdr.Size = New System.Drawing.Size(391, 22)
        Me.TextBoxAdr.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 260)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Adresse:"
        '
        'TextBoxPostNr
        '
        Me.TextBoxPostNr.Location = New System.Drawing.Point(116, 308)
        Me.TextBoxPostNr.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPostNr.Name = "TextBoxPostNr"
        Me.TextBoxPostNr.Size = New System.Drawing.Size(103, 22)
        Me.TextBoxPostNr.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 311)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Postnr/sted:"
        '
        'TextBoxPostSt
        '
        Me.TextBoxPostSt.Location = New System.Drawing.Point(260, 308)
        Me.TextBoxPostSt.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPostSt.Name = "TextBoxPostSt"
        Me.TextBoxPostSt.Size = New System.Drawing.Size(204, 22)
        Me.TextBoxPostSt.TabIndex = 15
        '
        'TextBoxPhone1
        '
        Me.TextBoxPhone1.Location = New System.Drawing.Point(115, 359)
        Me.TextBoxPhone1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPhone1.Name = "TextBoxPhone1"
        Me.TextBoxPhone1.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxPhone1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 363)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Telefonnummer:"
        '
        'TextBoxPhone2
        '
        Me.TextBoxPhone2.Location = New System.Drawing.Point(315, 359)
        Me.TextBoxPhone2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPhone2.Name = "TextBoxPhone2"
        Me.TextBoxPhone2.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxPhone2.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Italic)
        Me.Label10.Location = New System.Drawing.Point(12, 341)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Minst ett telefonnummer må oppgis:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(115, 405)
        Me.TextBoxEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(391, 22)
        Me.TextBoxEmail.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(12, 409)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Epost:"
        '
        'CheckBoxGiveBefore
        '
        Me.CheckBoxGiveBefore.AutoSize = True
        Me.CheckBoxGiveBefore.Location = New System.Drawing.Point(16, 448)
        Me.CheckBoxGiveBefore.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxGiveBefore.Name = "CheckBoxGiveBefore"
        Me.CheckBoxGiveBefore.Size = New System.Drawing.Size(256, 21)
        Me.CheckBoxGiveBefore.TabIndex = 22
        Me.CheckBoxGiveBefore.Text = "Kryss av her om du har gitt blod før:"
        Me.CheckBoxGiveBefore.UseVisualStyleBackColor = True
        '
        'TextBoxPrevBank
        '
        Me.TextBoxPrevBank.Location = New System.Drawing.Point(16, 505)
        Me.TextBoxPrevBank.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPrevBank.Name = "TextBoxPrevBank"
        Me.TextBoxPrevBank.Size = New System.Drawing.Size(411, 22)
        Me.TextBoxPrevBank.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 485)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Hvilken blodbank:"
        '
        'CheckBoxPrevGet
        '
        Me.CheckBoxPrevGet.AutoSize = True
        Me.CheckBoxPrevGet.Location = New System.Drawing.Point(16, 550)
        Me.CheckBoxPrevGet.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPrevGet.Name = "CheckBoxPrevGet"
        Me.CheckBoxPrevGet.Size = New System.Drawing.Size(688, 21)
        Me.CheckBoxPrevGet.TabIndex = 25
        Me.CheckBoxPrevGet.Text = "Jeg samtykker i at blodbanken kan hendvende seg til min tidligere blodbank for å " &
    "innhente opplysninger."
        Me.CheckBoxPrevGet.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 587)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(483, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Har du spørsmål av medisinsk karakter, ta direkte kontakt med blodbanken."
        '
        'CheckBoxGetInfo
        '
        Me.CheckBoxGetInfo.AutoSize = True
        Me.CheckBoxGetInfo.Location = New System.Drawing.Point(15, 625)
        Me.CheckBoxGetInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxGetInfo.Name = "CheckBoxGetInfo"
        Me.CheckBoxGetInfo.Size = New System.Drawing.Size(326, 21)
        Me.CheckBoxGetInfo.TabIndex = 27
        Me.CheckBoxGetInfo.Text = "Jeg vil gjerne motta informasjon fra Røde Kors."
        Me.CheckBoxGetInfo.UseVisualStyleBackColor = True
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(15, 682)
        Me.ButtonSend.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(100, 28)
        Me.ButtonSend.TabIndex = 28
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 662)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1139, 17)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Ved å sende inn dette skjema samtykker jeg i at BloodBank Manager kan lagre min i" &
    "nformasjon i 3 måneder og at min blodbank registerer meg i sitt system."
        '
        'TextBoxDoB
        '
        Me.TextBoxDoB.Location = New System.Drawing.Point(116, 169)
        Me.TextBoxDoB.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDoB.Mask = "0000-00-00"
        Me.TextBoxDoB.Name = "TextBoxDoB"
        Me.TextBoxDoB.Size = New System.Drawing.Size(148, 22)
        Me.TextBoxDoB.TabIndex = 30
        '
        'LabelFeilMelding
        '
        Me.LabelFeilMelding.AutoSize = True
        Me.LabelFeilMelding.BackColor = System.Drawing.SystemColors.Control
        Me.LabelFeilMelding.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelFeilMelding.Location = New System.Drawing.Point(436, 508)
        Me.LabelFeilMelding.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFeilMelding.Name = "LabelFeilMelding"
        Me.LabelFeilMelding.Size = New System.Drawing.Size(104, 17)
        Me.LabelFeilMelding.TabIndex = 31
        Me.LabelFeilMelding.Text = "PLACEHOLDer"
        '
        'TextBoxBrukernavn
        '
        Me.TextBoxBrukernavn.Location = New System.Drawing.Point(788, 94)
        Me.TextBoxBrukernavn.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBrukernavn.Name = "TextBoxBrukernavn"
        Me.TextBoxBrukernavn.Size = New System.Drawing.Size(180, 22)
        Me.TextBoxBrukernavn.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(645, 97)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 17)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Ønsket brukernavn:"
        '
        'TextBoxPassord
        '
        Me.TextBoxPassord.Location = New System.Drawing.Point(788, 126)
        Me.TextBoxPassord.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPassord.Name = "TextBoxPassord"
        Me.TextBoxPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassord.Size = New System.Drawing.Size(180, 22)
        Me.TextBoxPassord.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(668, 129)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 17)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Ønsket passord:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(345, 44)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(341, 25)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(165, 17)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Hvilken blodtype har du?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(788, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 30)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Oprett"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'registeringAvNyeBlodgivere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(1329, 734)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBoxPassord)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBoxBrukernavn)
        Me.Controls.Add(Me.LabelFeilMelding)
        Me.Controls.Add(Me.TextBoxDoB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.CheckBoxGetInfo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CheckBoxPrevGet)
        Me.Controls.Add(Me.TextBoxPrevBank)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CheckBoxGiveBefore)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxPhone2)
        Me.Controls.Add(Me.TextBoxPhone1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxPostSt)
        Me.Controls.Add(Me.TextBoxPostNr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxAdr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxPersonNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxLok)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "registeringAvNyeBlodgivere"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents ComboBoxLok As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPersonNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAdr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxPostNr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxPostSt As TextBox
    Friend WithEvents TextBoxPhone1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxPhone2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBoxGiveBefore As CheckBox
    Friend WithEvents TextBoxPrevBank As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckBoxPrevGet As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBoxGetInfo As CheckBox
    Friend WithEvents ButtonSend As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxDoB As MaskedTextBox
    Friend WithEvents LabelFeilMelding As Label
    Friend WithEvents TextBoxBrukernavn As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxPassord As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Button1 As Button
End Class
