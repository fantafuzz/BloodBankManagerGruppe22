<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logginn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logginn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonRegistrer = New System.Windows.Forms.Button()
        Me.ButtonLogInn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxEpost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonLogInnAnsatt = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OmBlodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetningslinjerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HvaSkjerNårDuGirBlodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HarDuNettoppGittBlodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NårKanDuIkkeGiBlodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÅpninstiderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontaktOssToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OmOssToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ButtonRegistrer)
        Me.Panel1.Location = New System.Drawing.Point(9, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 122)
        Me.Panel1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 51)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Er du ikke blodgiver enda? Trykk knappen under for å starte registreringen!"
        '
        'ButtonRegistrer
        '
        Me.ButtonRegistrer.Location = New System.Drawing.Point(6, 63)
        Me.ButtonRegistrer.Name = "ButtonRegistrer"
        Me.ButtonRegistrer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegistrer.TabIndex = 10
        Me.ButtonRegistrer.Text = "Register"
        Me.ButtonRegistrer.UseVisualStyleBackColor = True
        '
        'ButtonLogInn
        '
        Me.ButtonLogInn.Location = New System.Drawing.Point(6, 133)
        Me.ButtonLogInn.Name = "ButtonLogInn"
        Me.ButtonLogInn.Size = New System.Drawing.Size(160, 23)
        Me.ButtonLogInn.TabIndex = 13
        Me.ButtonLogInn.Text = "Logg inn"
        Me.ButtonLogInn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Passord:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Epost: "
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(6, 107)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxPassword.TabIndex = 10
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'TextBoxEpost
        '
        Me.TextBoxEpost.Location = New System.Drawing.Point(6, 58)
        Me.TextBoxEpost.Name = "TextBoxEpost"
        Me.TextBoxEpost.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxEpost.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 40.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(-4, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(678, 62)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Velkommen til Blodbanken"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Allerede Blodgiver? Logg inn:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.ButtonLogInnAnsatt)
        Me.Panel2.Controls.Add(Me.TextBoxEpost)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBoxPassword)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ButtonLogInn)
        Me.Panel2.Location = New System.Drawing.Point(9, 339)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 197)
        Me.Panel2.TabIndex = 19
        '
        'ButtonLogInnAnsatt
        '
        Me.ButtonLogInnAnsatt.Location = New System.Drawing.Point(6, 163)
        Me.ButtonLogInnAnsatt.Name = "ButtonLogInnAnsatt"
        Me.ButtonLogInnAnsatt.Size = New System.Drawing.Size(160, 23)
        Me.ButtonLogInnAnsatt.TabIndex = 19
        Me.ButtonLogInnAnsatt.Text = "Innlogging for ansatte"
        Me.ButtonLogInnAnsatt.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 114)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(644, 80)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "Det tar kun en halv time å gi blod. Den halve literen du gir kan redde tre liv. E" &
    "r du frisk og mellom 18 og 60 år, kan du melde deg som blodgiver.  Husk at BLOD " &
    "KAN IKKE LAGES, DET MÅ GIS!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OmBlodToolStripMenuItem, Me.RetningslinjerToolStripMenuItem, Me.HvaSkjerNårDuGirBlodToolStripMenuItem, Me.HarDuNettoppGittBlodToolStripMenuItem, Me.NårKanDuIkkeGiBlodToolStripMenuItem, Me.ÅpninstiderToolStripMenuItem, Me.KontaktOssToolStripMenuItem, Me.OmOssToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OmBlodToolStripMenuItem
        '
        Me.OmBlodToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OmBlodToolStripMenuItem.Name = "OmBlodToolStripMenuItem"
        Me.OmBlodToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.OmBlodToolStripMenuItem.Text = "Om Blod"
        '
        'RetningslinjerToolStripMenuItem
        '
        Me.RetningslinjerToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetningslinjerToolStripMenuItem.Name = "RetningslinjerToolStripMenuItem"
        Me.RetningslinjerToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.RetningslinjerToolStripMenuItem.Text = "Retningslinjer"
        '
        'HvaSkjerNårDuGirBlodToolStripMenuItem
        '
        Me.HvaSkjerNårDuGirBlodToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HvaSkjerNårDuGirBlodToolStripMenuItem.Name = "HvaSkjerNårDuGirBlodToolStripMenuItem"
        Me.HvaSkjerNårDuGirBlodToolStripMenuItem.Size = New System.Drawing.Size(188, 20)
        Me.HvaSkjerNårDuGirBlodToolStripMenuItem.Text = "Hva skjer når du gir blod?"
        '
        'HarDuNettoppGittBlodToolStripMenuItem
        '
        Me.HarDuNettoppGittBlodToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HarDuNettoppGittBlodToolStripMenuItem.Name = "HarDuNettoppGittBlodToolStripMenuItem"
        Me.HarDuNettoppGittBlodToolStripMenuItem.Size = New System.Drawing.Size(184, 20)
        Me.HarDuNettoppGittBlodToolStripMenuItem.Text = "Har du nettopp gitt blod?"
        '
        'NårKanDuIkkeGiBlodToolStripMenuItem
        '
        Me.NårKanDuIkkeGiBlodToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NårKanDuIkkeGiBlodToolStripMenuItem.Name = "NårKanDuIkkeGiBlodToolStripMenuItem"
        Me.NårKanDuIkkeGiBlodToolStripMenuItem.Size = New System.Drawing.Size(176, 20)
        Me.NårKanDuIkkeGiBlodToolStripMenuItem.Text = "Når kan du ikke gi blod?"
        '
        'ÅpninstiderToolStripMenuItem
        '
        Me.ÅpninstiderToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ÅpninstiderToolStripMenuItem.Name = "ÅpninstiderToolStripMenuItem"
        Me.ÅpninstiderToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ÅpninstiderToolStripMenuItem.Text = "Åpningstider"
        '
        'KontaktOssToolStripMenuItem
        '
        Me.KontaktOssToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KontaktOssToolStripMenuItem.Name = "KontaktOssToolStripMenuItem"
        Me.KontaktOssToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.KontaktOssToolStripMenuItem.Text = "Kontakt Oss"
        '
        'OmOssToolStripMenuItem
        '
        Me.OmOssToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OmOssToolStripMenuItem.Name = "OmOssToolStripMenuItem"
        Me.OmOssToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.OmOssToolStripMenuItem.Text = "Om Oss"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(373, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Visste du at..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(373, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(376, 230)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 43)
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.Text = "I gjennomsnitt tapper hver blodgiver i Norge 2,1 ganger i året."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(764, 541)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 18)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Date Time"
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(271, 460)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 19)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Ansatte"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(283, 398)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 19)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Brukere"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(264, 260)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Registrering"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Egenskjema"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(376, 276)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(191, 251)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(825, 35)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Klikk her for å komme til Blodbankens Facebook side")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(781, 35)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 67)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        Me.ToolTip2.SetToolTip(Me.PictureBox3, "Klikk her for å komme til Blodbankens hjemmeside")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(869, 35)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(52, 67)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 37
        Me.PictureBox4.TabStop = False
        Me.ToolTip3.SetToolTip(Me.PictureBox4, "Klikk her for å komme til Blodbankens Twitter Side")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(919, 35)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 67)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 38
        Me.PictureBox5.TabStop = False
        Me.ToolTip4.SetToolTip(Me.PictureBox5, "Klikk her for å komme til Blodbankens Instagram")
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(698, 130)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(265, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 39
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(698, 184)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(265, 343)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 40
        Me.PictureBox7.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Facebook Blodbanken"
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipTitle = "Blodbankens Hjemmeside"
        '
        'ToolTip3
        '
        Me.ToolTip3.ToolTipTitle = "Blodbanken Twitter"
        '
        'ToolTip4
        '
        Me.ToolTip4.ToolTipTitle = "Blodbanken Instagram"
        '
        'Logginn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 568)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Logginn"
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonRegistrer As Button
    Friend WithEvents ButtonLogInn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxEpost As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OmOssToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonLogInnAnsatt As Button
    Friend WithEvents OmBlodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetningslinjerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ÅpninstiderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KontaktOssToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents HvaSkjerNårDuGirBlodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents HarDuNettoppGittBlodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NårKanDuIkkeGiBlodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
End Class
