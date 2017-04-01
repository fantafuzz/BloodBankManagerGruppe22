<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrering))
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
        Me.TextBoxPassord = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBoxBlodType = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelFeilPerson = New System.Windows.Forms.Label()
        Me.ComboBoxKjonn = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelFeilKontakt = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelFeilBlod = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fornavn:"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(100, 25)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(294, 20)
        Me.TextBoxFirstName.TabIndex = 1
        '
        'ComboBoxLok
        '
        Me.ComboBoxLok.FormattingEnabled = True
        Me.ComboBoxLok.Items.AddRange(New Object() {"St. Olavs Hospital Orkdal", "St. Olavs Hospital Trondheim"})
        Me.ComboBoxLok.Location = New System.Drawing.Point(138, 24)
        Me.ComboBoxLok.Name = "ComboBoxLok"
        Me.ComboBoxLok.Size = New System.Drawing.Size(206, 21)
        Me.ComboBoxLok.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hvor ønsker du å gi blod?"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(100, 65)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(294, 20)
        Me.TextBoxLastName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Etternavn:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Føsdselsdato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "(YYYY-MM-DD)"
        '
        'TextBoxPersonNum
        '
        Me.TextBoxPersonNum.Location = New System.Drawing.Point(100, 145)
        Me.TextBoxPersonNum.Name = "TextBoxPersonNum"
        Me.TextBoxPersonNum.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxPersonNum.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Personnummer:"
        '
        'TextBoxAdr
        '
        Me.TextBoxAdr.Location = New System.Drawing.Point(100, 25)
        Me.TextBoxAdr.Name = "TextBoxAdr"
        Me.TextBoxAdr.Size = New System.Drawing.Size(294, 20)
        Me.TextBoxAdr.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Adresse:"
        '
        'TextBoxPostNr
        '
        Me.TextBoxPostNr.Location = New System.Drawing.Point(100, 65)
        Me.TextBoxPostNr.Name = "TextBoxPostNr"
        Me.TextBoxPostNr.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxPostNr.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Postnr/sted:"
        '
        'TextBoxPostSt
        '
        Me.TextBoxPostSt.Location = New System.Drawing.Point(184, 65)
        Me.TextBoxPostSt.Name = "TextBoxPostSt"
        Me.TextBoxPostSt.Size = New System.Drawing.Size(210, 20)
        Me.TextBoxPostSt.TabIndex = 15
        '
        'TextBoxPhone1
        '
        Me.TextBoxPhone1.Location = New System.Drawing.Point(100, 181)
        Me.TextBoxPhone1.Name = "TextBoxPhone1"
        Me.TextBoxPhone1.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxPhone1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Telefonnummer:"
        '
        'TextBoxPhone2
        '
        Me.TextBoxPhone2.Enabled = False
        Me.TextBoxPhone2.Location = New System.Drawing.Point(250, 181)
        Me.TextBoxPhone2.Name = "TextBoxPhone2"
        Me.TextBoxPhone2.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxPhone2.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Italic)
        Me.Label10.Location = New System.Drawing.Point(99, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 12)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Minst ett telefonnummer må oppgis:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(101, 105)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(294, 20)
        Me.TextBoxEmail.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(3, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Epost:"
        '
        'CheckBoxGiveBefore
        '
        Me.CheckBoxGiveBefore.AutoSize = True
        Me.CheckBoxGiveBefore.Location = New System.Drawing.Point(6, 108)
        Me.CheckBoxGiveBefore.Name = "CheckBoxGiveBefore"
        Me.CheckBoxGiveBefore.Size = New System.Drawing.Size(192, 17)
        Me.CheckBoxGiveBefore.TabIndex = 22
        Me.CheckBoxGiveBefore.Text = "Kryss av her om du har gitt blod før:"
        Me.CheckBoxGiveBefore.UseVisualStyleBackColor = True
        '
        'TextBoxPrevBank
        '
        Me.TextBoxPrevBank.Enabled = False
        Me.TextBoxPrevBank.Location = New System.Drawing.Point(138, 145)
        Me.TextBoxPrevBank.Name = "TextBoxPrevBank"
        Me.TextBoxPrevBank.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxPrevBank.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Hvilken blodbank:"
        '
        'CheckBoxPrevGet
        '
        Me.CheckBoxPrevGet.Enabled = False
        Me.CheckBoxPrevGet.Location = New System.Drawing.Point(6, 173)
        Me.CheckBoxPrevGet.Name = "CheckBoxPrevGet"
        Me.CheckBoxPrevGet.Size = New System.Drawing.Size(381, 32)
        Me.CheckBoxPrevGet.TabIndex = 25
        Me.CheckBoxPrevGet.Text = "Jeg samtykker i at blodbanken kan hendvende seg til min tidligere blodbank for å " &
    "innhente opplysninger."
        Me.CheckBoxPrevGet.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(363, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Har du spørsmål av medisinsk karakter, ta direkte kontakt med blodbanken."
        '
        'CheckBoxGetInfo
        '
        Me.CheckBoxGetInfo.AutoSize = True
        Me.CheckBoxGetInfo.Location = New System.Drawing.Point(101, 131)
        Me.CheckBoxGetInfo.Name = "CheckBoxGetInfo"
        Me.CheckBoxGetInfo.Size = New System.Drawing.Size(244, 17)
        Me.CheckBoxGetInfo.TabIndex = 27
        Me.CheckBoxGetInfo.Text = "Jeg vil gjerne motta informasjon fra Røde Kors."
        Me.CheckBoxGetInfo.UseVisualStyleBackColor = True
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(910, 561)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSend.TabIndex = 28
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(389, 71)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Ved å sende inn dette skjema samtykker jeg i at BloodBank Manager kan lagre min i" &
    "nformasjon i 3 måneder og at min blodbank registerer meg i sitt system."
        '
        'TextBoxDoB
        '
        Me.TextBoxDoB.Location = New System.Drawing.Point(100, 105)
        Me.TextBoxDoB.Mask = "0000-00-00"
        Me.TextBoxDoB.Name = "TextBoxDoB"
        Me.TextBoxDoB.Size = New System.Drawing.Size(63, 20)
        Me.TextBoxDoB.TabIndex = 30
        '
        'TextBoxPassord
        '
        Me.TextBoxPassord.Location = New System.Drawing.Point(100, 185)
        Me.TextBoxPassord.Name = "TextBoxPassord"
        Me.TextBoxPassord.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxPassord.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Ønsket passord:"
        '
        'ComboBoxBlodType
        '
        Me.ComboBoxBlodType.FormattingEnabled = True
        Me.ComboBoxBlodType.Items.AddRange(New Object() {"A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-"})
        Me.ComboBoxBlodType.Location = New System.Drawing.Point(138, 64)
        Me.ComboBoxBlodType.Name = "ComboBoxBlodType"
        Me.ComboBoxBlodType.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBlodType.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Hvilken blodtype har du?"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LabelFeilPerson)
        Me.Panel1.Controls.Add(Me.ComboBoxKjonn)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TextBoxFirstName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBoxLastName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxPassord)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.TextBoxDoB)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBoxPersonNum)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 283)
        Me.Panel1.TabIndex = 40
        '
        'LabelFeilPerson
        '
        Me.LabelFeilPerson.AutoSize = True
        Me.LabelFeilPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFeilPerson.Location = New System.Drawing.Point(297, 259)
        Me.LabelFeilPerson.Name = "LabelFeilPerson"
        Me.LabelFeilPerson.Size = New System.Drawing.Size(180, 20)
        Me.LabelFeilPerson.TabIndex = 42
        Me.LabelFeilPerson.Text = "Vennligst fyll inn alle felt."
        Me.LabelFeilPerson.Visible = False
        '
        'ComboBoxKjonn
        '
        Me.ComboBoxKjonn.FormattingEnabled = True
        Me.ComboBoxKjonn.Items.AddRange(New Object() {"Mann", "Kvinne", "Annet"})
        Me.ComboBoxKjonn.Location = New System.Drawing.Point(101, 225)
        Me.ComboBoxKjonn.Name = "ComboBoxKjonn"
        Me.ComboBoxKjonn.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxKjonn.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Kjønn:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Personinformasjon"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.LabelFeilKontakt)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBoxAdr)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBoxPostNr)
        Me.Panel2.Controls.Add(Me.TextBoxPostSt)
        Me.Panel2.Controls.Add(Me.CheckBoxGetInfo)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBoxEmail)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBoxPhone1)
        Me.Panel2.Controls.Add(Me.TextBoxPhone2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(12, 301)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 283)
        Me.Panel2.TabIndex = 41
        '
        'LabelFeilKontakt
        '
        Me.LabelFeilKontakt.AutoSize = True
        Me.LabelFeilKontakt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFeilKontakt.Location = New System.Drawing.Point(297, 258)
        Me.LabelFeilKontakt.Name = "LabelFeilKontakt"
        Me.LabelFeilKontakt.Size = New System.Drawing.Size(180, 20)
        Me.LabelFeilKontakt.TabIndex = 43
        Me.LabelFeilKontakt.Text = "Vennligst fyll inn alle felt."
        Me.LabelFeilKontakt.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Kontaktinformasjon"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.LabelFeilBlod)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.ComboBoxLok)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.ComboBoxBlodType)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.CheckBoxGiveBefore)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.TextBoxPrevBank)
        Me.Panel3.Controls.Add(Me.CheckBoxPrevGet)
        Me.Panel3.Location = New System.Drawing.Point(501, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(484, 283)
        Me.Panel3.TabIndex = 42
        '
        'LabelFeilBlod
        '
        Me.LabelFeilBlod.AutoSize = True
        Me.LabelFeilBlod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFeilBlod.Location = New System.Drawing.Point(297, 259)
        Me.LabelFeilBlod.Name = "LabelFeilBlod"
        Me.LabelFeilBlod.Size = New System.Drawing.Size(180, 20)
        Me.LabelFeilBlod.TabIndex = 44
        Me.LabelFeilBlod.Text = "Vennligst fyll inn alle felt."
        Me.LabelFeilBlod.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Blodgivningsinformasjon"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(501, 301)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(484, 252)
        Me.Panel4.TabIndex = 43
        '
        'Registrering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(997, 596)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ButtonSend)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "Registrering"
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents TextBoxPassord As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBoxBlodType As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ComboBoxKjonn As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelFeilPerson As Label
    Friend WithEvents LabelFeilKontakt As Label
    Friend WithEvents LabelFeilBlod As Label
End Class
