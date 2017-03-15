<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registeringAvNyeBlodgivere
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.TextBoxPassord = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBoxBlodType = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.RadioButtonMann = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKvinne = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fornavn:"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(100, 82)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(342, 20)
        Me.TextBoxFirstName.TabIndex = 1
        '
        'ComboBoxLok
        '
        Me.ComboBoxLok.FormattingEnabled = True
        Me.ComboBoxLok.Items.AddRange(New Object() {"St. Olavs Hospital Orkdal", "St. Olavs Hospital Trondheim"})
        Me.ComboBoxLok.Location = New System.Drawing.Point(14, 39)
        Me.ComboBoxLok.Name = "ComboBoxLok"
        Me.ComboBoxLok.Size = New System.Drawing.Size(269, 22)
        Me.ComboBoxLok.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hvor ønsker du å gi blod?"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(100, 110)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(342, 20)
        Me.TextBoxLastName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Etternavn:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Føsdselsdato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "(YYYY-MM-DD)"
        '
        'TextBoxPersonNum
        '
        Me.TextBoxPersonNum.Location = New System.Drawing.Point(100, 185)
        Me.TextBoxPersonNum.Name = "TextBoxPersonNum"
        Me.TextBoxPersonNum.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxPersonNum.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Personnummer:"
        '
        'TextBoxAdr
        '
        Me.TextBoxAdr.Location = New System.Drawing.Point(100, 224)
        Me.TextBoxAdr.Name = "TextBoxAdr"
        Me.TextBoxAdr.Size = New System.Drawing.Size(342, 20)
        Me.TextBoxAdr.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Adresse:"
        '
        'TextBoxPostNr
        '
        Me.TextBoxPostNr.Location = New System.Drawing.Point(101, 269)
        Me.TextBoxPostNr.Name = "TextBoxPostNr"
        Me.TextBoxPostNr.Size = New System.Drawing.Size(90, 20)
        Me.TextBoxPostNr.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Postnr/sted:"
        '
        'TextBoxPostSt
        '
        Me.TextBoxPostSt.Location = New System.Drawing.Point(227, 269)
        Me.TextBoxPostSt.Name = "TextBoxPostSt"
        Me.TextBoxPostSt.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxPostSt.TabIndex = 15
        '
        'TextBoxPhone1
        '
        Me.TextBoxPhone1.Location = New System.Drawing.Point(100, 314)
        Me.TextBoxPhone1.Name = "TextBoxPhone1"
        Me.TextBoxPhone1.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxPhone1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 318)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 14)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Telefonnummer:"
        '
        'TextBoxPhone2
        '
        Me.TextBoxPhone2.Enabled = False
        Me.TextBoxPhone2.Location = New System.Drawing.Point(275, 314)
        Me.TextBoxPhone2.Name = "TextBoxPhone2"
        Me.TextBoxPhone2.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxPhone2.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Italic)
        Me.Label10.Location = New System.Drawing.Point(10, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 12)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Minst ett telefonnummer må oppgis:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(100, 354)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(342, 20)
        Me.TextBoxEmail.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(10, 358)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Epost:"
        '
        'CheckBoxGiveBefore
        '
        Me.CheckBoxGiveBefore.AutoSize = True
        Me.CheckBoxGiveBefore.Location = New System.Drawing.Point(14, 392)
        Me.CheckBoxGiveBefore.Name = "CheckBoxGiveBefore"
        Me.CheckBoxGiveBefore.Size = New System.Drawing.Size(236, 18)
        Me.CheckBoxGiveBefore.TabIndex = 22
        Me.CheckBoxGiveBefore.Text = "Kryss av her om du har gitt blod før:"
        Me.CheckBoxGiveBefore.UseVisualStyleBackColor = True
        '
        'TextBoxPrevBank
        '
        Me.TextBoxPrevBank.Location = New System.Drawing.Point(14, 442)
        Me.TextBoxPrevBank.Name = "TextBoxPrevBank"
        Me.TextBoxPrevBank.Size = New System.Drawing.Size(360, 20)
        Me.TextBoxPrevBank.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 424)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 14)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Hvilken blodbank:"
        '
        'CheckBoxPrevGet
        '
        Me.CheckBoxPrevGet.AutoSize = True
        Me.CheckBoxPrevGet.Location = New System.Drawing.Point(14, 481)
        Me.CheckBoxPrevGet.Name = "CheckBoxPrevGet"
        Me.CheckBoxPrevGet.Size = New System.Drawing.Size(635, 18)
        Me.CheckBoxPrevGet.TabIndex = 25
        Me.CheckBoxPrevGet.Text = "Jeg samtykker i at blodbanken kan hendvende seg til min tidligere blodbank for å " &
    "innhente opplysninger."
        Me.CheckBoxPrevGet.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 514)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(449, 14)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Har du spørsmål av medisinsk karakter, ta direkte kontakt med blodbanken."
        '
        'CheckBoxGetInfo
        '
        Me.CheckBoxGetInfo.AutoSize = True
        Me.CheckBoxGetInfo.Location = New System.Drawing.Point(13, 547)
        Me.CheckBoxGetInfo.Name = "CheckBoxGetInfo"
        Me.CheckBoxGetInfo.Size = New System.Drawing.Size(297, 18)
        Me.CheckBoxGetInfo.TabIndex = 27
        Me.CheckBoxGetInfo.Text = "Jeg vil gjerne motta informasjon fra Røde Kors."
        Me.CheckBoxGetInfo.UseVisualStyleBackColor = True
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(13, 597)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(87, 25)
        Me.ButtonSend.TabIndex = 28
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 579)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(885, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Ved å sende inn dette skjema samtykker jeg i at BloodBank Manager kan lagre min i" &
    "nformasjon i 3 måneder og at min blodbank registerer meg i sitt system."
        '
        'TextBoxDoB
        '
        Me.TextBoxDoB.Location = New System.Drawing.Point(101, 148)
        Me.TextBoxDoB.Mask = "0000-00-00"
        Me.TextBoxDoB.Name = "TextBoxDoB"
        Me.TextBoxDoB.Size = New System.Drawing.Size(130, 20)
        Me.TextBoxDoB.TabIndex = 30
        '
        'LabelFeilMelding
        '
        Me.LabelFeilMelding.AutoSize = True
        Me.LabelFeilMelding.BackColor = System.Drawing.SystemColors.Control
        Me.LabelFeilMelding.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelFeilMelding.Location = New System.Drawing.Point(534, 100)
        Me.LabelFeilMelding.Name = "LabelFeilMelding"
        Me.LabelFeilMelding.Size = New System.Drawing.Size(0, 14)
        Me.LabelFeilMelding.TabIndex = 31
        '
        'TextBoxPassord
        '
        Me.TextBoxPassord.Location = New System.Drawing.Point(561, 40)
        Me.TextBoxPassord.Name = "TextBoxPassord"
        Me.TextBoxPassord.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxPassord.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(456, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 14)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Ønsket passord:"
        '
        'ComboBoxBlodType
        '
        Me.ComboBoxBlodType.FormattingEnabled = True
        Me.ComboBoxBlodType.Items.AddRange(New Object() {"A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-"})
        Me.ComboBoxBlodType.Location = New System.Drawing.Point(302, 39)
        Me.ComboBoxBlodType.Name = "ComboBoxBlodType"
        Me.ComboBoxBlodType.Size = New System.Drawing.Size(140, 22)
        Me.ComboBoxBlodType.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(299, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(155, 14)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Hvilken blodtype har du?"
        '
        'RadioButtonMann
        '
        Me.RadioButtonMann.AutoSize = True
        Me.RadioButtonMann.Location = New System.Drawing.Point(460, 83)
        Me.RadioButtonMann.Name = "RadioButtonMann"
        Me.RadioButtonMann.Size = New System.Drawing.Size(58, 18)
        Me.RadioButtonMann.TabIndex = 38
        Me.RadioButtonMann.TabStop = True
        Me.RadioButtonMann.Tag = "1"
        Me.RadioButtonMann.Text = "Mann"
        Me.RadioButtonMann.UseVisualStyleBackColor = True
        '
        'RadioButtonKvinne
        '
        Me.RadioButtonKvinne.AutoSize = True
        Me.RadioButtonKvinne.Location = New System.Drawing.Point(460, 110)
        Me.RadioButtonKvinne.Name = "RadioButtonKvinne"
        Me.RadioButtonKvinne.Size = New System.Drawing.Size(67, 18)
        Me.RadioButtonKvinne.TabIndex = 39
        Me.RadioButtonKvinne.TabStop = True
        Me.RadioButtonKvinne.Tag = "1"
        Me.RadioButtonKvinne.Text = "Kvinne"
        Me.RadioButtonKvinne.UseVisualStyleBackColor = True
        '
        'registeringAvNyeBlodgivere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1163, 642)
        Me.Controls.Add(Me.RadioButtonKvinne)
        Me.Controls.Add(Me.RadioButtonMann)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ComboBoxBlodType)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBoxPassord)
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
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
    Friend WithEvents TextBoxPassord As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBoxBlodType As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents RadioButtonMann As RadioButton
    Friend WithEvents RadioButtonKvinne As RadioButton
End Class
