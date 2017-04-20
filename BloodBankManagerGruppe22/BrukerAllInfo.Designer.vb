<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrukerAllInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrukerAllInfo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEpost = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbTlf2 = New System.Windows.Forms.TextBox()
        Me.tbTlf1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbPoststed = New System.Windows.Forms.TextBox()
        Me.tbPostnr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbAdr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbEtternavn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbFornavn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEndreFornavn = New System.Windows.Forms.Button()
        Me.btnEndreEtternavn = New System.Windows.Forms.Button()
        Me.btnEndreAdresse = New System.Windows.Forms.Button()
        Me.btnEndrePostnr = New System.Windows.Forms.Button()
        Me.btnEndreTelefon = New System.Windows.Forms.Button()
        Me.btnEndreEpost = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Velkommen til minside"
        '
        'tbEpost
        '
        Me.tbEpost.Location = New System.Drawing.Point(94, 245)
        Me.tbEpost.Name = "tbEpost"
        Me.tbEpost.ReadOnly = True
        Me.tbEpost.Size = New System.Drawing.Size(342, 20)
        Me.tbEpost.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(14, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Epost:"
        '
        'tbTlf2
        '
        Me.tbTlf2.Location = New System.Drawing.Point(295, 217)
        Me.tbTlf2.Name = "tbTlf2"
        Me.tbTlf2.ReadOnly = True
        Me.tbTlf2.Size = New System.Drawing.Size(141, 20)
        Me.tbTlf2.TabIndex = 38
        '
        'tbTlf1
        '
        Me.tbTlf1.Location = New System.Drawing.Point(125, 217)
        Me.tbTlf1.Name = "tbTlf1"
        Me.tbTlf1.ReadOnly = True
        Me.tbTlf1.Size = New System.Drawing.Size(156, 20)
        Me.tbTlf1.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 14)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Telefonnummer:"
        '
        'tbPoststed
        '
        Me.tbPoststed.Location = New System.Drawing.Point(190, 185)
        Me.tbPoststed.Name = "tbPoststed"
        Me.tbPoststed.ReadOnly = True
        Me.tbPoststed.Size = New System.Drawing.Size(246, 20)
        Me.tbPoststed.TabIndex = 35
        '
        'tbPostnr
        '
        Me.tbPostnr.Location = New System.Drawing.Point(94, 185)
        Me.tbPostnr.Name = "tbPostnr"
        Me.tbPostnr.ReadOnly = True
        Me.tbPostnr.Size = New System.Drawing.Size(90, 20)
        Me.tbPostnr.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 14)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Postnr/sted:"
        '
        'tbAdr
        '
        Me.tbAdr.Location = New System.Drawing.Point(94, 159)
        Me.tbAdr.Name = "tbAdr"
        Me.tbAdr.ReadOnly = True
        Me.tbAdr.Size = New System.Drawing.Size(342, 20)
        Me.tbAdr.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Adresse:"
        '
        'tbEtternavn
        '
        Me.tbEtternavn.Location = New System.Drawing.Point(94, 133)
        Me.tbEtternavn.Name = "tbEtternavn"
        Me.tbEtternavn.ReadOnly = True
        Me.tbEtternavn.Size = New System.Drawing.Size(342, 20)
        Me.tbEtternavn.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Etternavn:"
        '
        'tbFornavn
        '
        Me.tbFornavn.Location = New System.Drawing.Point(94, 107)
        Me.tbFornavn.Name = "tbFornavn"
        Me.tbFornavn.ReadOnly = True
        Me.tbFornavn.Size = New System.Drawing.Size(342, 20)
        Me.tbFornavn.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fornavn:"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(94, 81)
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(99, 20)
        Me.tbID.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Bruker ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(555, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'btnEndreFornavn
        '
        Me.btnEndreFornavn.Location = New System.Drawing.Point(442, 106)
        Me.btnEndreFornavn.Name = "btnEndreFornavn"
        Me.btnEndreFornavn.Size = New System.Drawing.Size(75, 23)
        Me.btnEndreFornavn.TabIndex = 56
        Me.btnEndreFornavn.Text = "Endre"
        Me.btnEndreFornavn.UseVisualStyleBackColor = True
        '
        'btnEndreEtternavn
        '
        Me.btnEndreEtternavn.Location = New System.Drawing.Point(442, 132)
        Me.btnEndreEtternavn.Name = "btnEndreEtternavn"
        Me.btnEndreEtternavn.Size = New System.Drawing.Size(75, 23)
        Me.btnEndreEtternavn.TabIndex = 57
        Me.btnEndreEtternavn.Text = "Endre"
        Me.btnEndreEtternavn.UseVisualStyleBackColor = True
        '
        'btnEndreAdresse
        '
        Me.btnEndreAdresse.Location = New System.Drawing.Point(442, 159)
        Me.btnEndreAdresse.Name = "btnEndreAdresse"
        Me.btnEndreAdresse.Size = New System.Drawing.Size(75, 23)
        Me.btnEndreAdresse.TabIndex = 58
        Me.btnEndreAdresse.Text = "Endre"
        Me.btnEndreAdresse.UseVisualStyleBackColor = True
        '
        'btnEndrePostnr
        '
        Me.btnEndrePostnr.Location = New System.Drawing.Point(442, 184)
        Me.btnEndrePostnr.Name = "btnEndrePostnr"
        Me.btnEndrePostnr.Size = New System.Drawing.Size(75, 23)
        Me.btnEndrePostnr.TabIndex = 59
        Me.btnEndrePostnr.Text = "Endre"
        Me.btnEndrePostnr.UseVisualStyleBackColor = True
        '
        'btnEndreTelefon
        '
        Me.btnEndreTelefon.Location = New System.Drawing.Point(442, 216)
        Me.btnEndreTelefon.Name = "btnEndreTelefon"
        Me.btnEndreTelefon.Size = New System.Drawing.Size(75, 23)
        Me.btnEndreTelefon.TabIndex = 60
        Me.btnEndreTelefon.Text = "Endre"
        Me.btnEndreTelefon.UseVisualStyleBackColor = True
        '
        'btnEndreEpost
        '
        Me.btnEndreEpost.Location = New System.Drawing.Point(442, 244)
        Me.btnEndreEpost.Name = "btnEndreEpost"
        Me.btnEndreEpost.Size = New System.Drawing.Size(75, 23)
        Me.btnEndreEpost.TabIndex = 61
        Me.btnEndreEpost.Text = "Endre"
        Me.btnEndreEpost.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(718, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Tilbake"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 114)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(555, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 121)
        Me.Panel1.TabIndex = 64
        '
        'BrukerAllInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEndreEpost)
        Me.Controls.Add(Me.btnEndreTelefon)
        Me.Controls.Add(Me.btnEndrePostnr)
        Me.Controls.Add(Me.btnEndreAdresse)
        Me.Controls.Add(Me.btnEndreEtternavn)
        Me.Controls.Add(Me.btnEndreFornavn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbEpost)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbTlf2)
        Me.Controls.Add(Me.tbTlf1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbPoststed)
        Me.Controls.Add(Me.tbPostnr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbAdr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbEtternavn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbFornavn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "BrukerAllInfo"
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbEpost As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbTlf2 As TextBox
    Friend WithEvents tbTlf1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbPoststed As TextBox
    Friend WithEvents tbPostnr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbAdr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbEtternavn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbFornavn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEndreFornavn As Button
    Friend WithEvents btnEndreEtternavn As Button
    Friend WithEvents btnEndreAdresse As Button
    Friend WithEvents btnEndrePostnr As Button
    Friend WithEvents btnEndreTelefon As Button
    Friend WithEvents btnEndreEpost As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
End Class
