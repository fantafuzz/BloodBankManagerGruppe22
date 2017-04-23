<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.pnlLeggtil = New System.Windows.Forms.Panel()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbAnsatt = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbPassord = New System.Windows.Forms.TextBox()
        Me.tbEpost = New System.Windows.Forms.TextBox()
        Me.tbFornavn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEtternavn = New System.Windows.Forms.TextBox()
        Me.gridAnsatt = New System.Windows.Forms.DataGridView()
        Me.btnFjern = New System.Windows.Forms.Button()
        Me.tbSok = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.pnlLeggtil.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gridAnsatt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(697, 527)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(75, 23)
        Me.btnTilbake.TabIndex = 2
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'pnlLeggtil
        '
        Me.pnlLeggtil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLeggtil.Controls.Add(Me.btnReg)
        Me.pnlLeggtil.Controls.Add(Me.Panel2)
        Me.pnlLeggtil.Controls.Add(Me.Label6)
        Me.pnlLeggtil.Controls.Add(Me.Panel1)
        Me.pnlLeggtil.Location = New System.Drawing.Point(12, 319)
        Me.pnlLeggtil.Name = "pnlLeggtil"
        Me.pnlLeggtil.Size = New System.Drawing.Size(616, 231)
        Me.pnlLeggtil.TabIndex = 3
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(445, 199)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 23)
        Me.btnReg.TabIndex = 4
        Me.btnReg.Text = "Registrer"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.rbAdmin)
        Me.Panel2.Controls.Add(Me.rbAnsatt)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(316, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 148)
        Me.Panel2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(3, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 58)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Forskjellen på vanlig ansatt og administrasjon er at administrasjon har tilgang t" &
    "il dette panelet, og kan legge til eller fjerne brukere."
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Location = New System.Drawing.Point(6, 58)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(92, 17)
        Me.rbAdmin.TabIndex = 2
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Administrasjon"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbAnsatt
        '
        Me.rbAnsatt.AutoSize = True
        Me.rbAnsatt.Location = New System.Drawing.Point(6, 35)
        Me.rbAnsatt.Name = "rbAnsatt"
        Me.rbAnsatt.Size = New System.Drawing.Size(86, 17)
        Me.rbAnsatt.TabIndex = 1
        Me.rbAnsatt.TabStop = True
        Me.rbAnsatt.Text = "Vanlig ansatt"
        Me.rbAnsatt.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Velg ansatt-type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Legg til ny ansattbruker"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tbPassord)
        Me.Panel1.Controls.Add(Me.tbEpost)
        Me.Panel1.Controls.Add(Me.tbFornavn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbEtternavn)
        Me.Panel1.Location = New System.Drawing.Point(17, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 148)
        Me.Panel1.TabIndex = 1
        '
        'tbPassord
        '
        Me.tbPassord.Location = New System.Drawing.Point(65, 116)
        Me.tbPassord.Name = "tbPassord"
        Me.tbPassord.Size = New System.Drawing.Size(216, 20)
        Me.tbPassord.TabIndex = 8
        '
        'tbEpost
        '
        Me.tbEpost.Location = New System.Drawing.Point(65, 88)
        Me.tbEpost.Name = "tbEpost"
        Me.tbEpost.Size = New System.Drawing.Size(216, 20)
        Me.tbEpost.TabIndex = 7
        '
        'tbFornavn
        '
        Me.tbFornavn.Location = New System.Drawing.Point(65, 32)
        Me.tbFornavn.Name = "tbFornavn"
        Me.tbFornavn.Size = New System.Drawing.Size(216, 20)
        Me.tbFornavn.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Passord:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Epost:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Etternavn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fornavn:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Personinformasjon"
        '
        'tbEtternavn
        '
        Me.tbEtternavn.Location = New System.Drawing.Point(65, 61)
        Me.tbEtternavn.Name = "tbEtternavn"
        Me.tbEtternavn.Size = New System.Drawing.Size(216, 20)
        Me.tbEtternavn.TabIndex = 0
        '
        'gridAnsatt
        '
        Me.gridAnsatt.AllowUserToAddRows = False
        Me.gridAnsatt.AllowUserToDeleteRows = False
        Me.gridAnsatt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAnsatt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gridAnsatt.Location = New System.Drawing.Point(12, 56)
        Me.gridAnsatt.Name = "gridAnsatt"
        Me.gridAnsatt.Size = New System.Drawing.Size(616, 257)
        Me.gridAnsatt.TabIndex = 4
        '
        'btnFjern
        '
        Me.btnFjern.Location = New System.Drawing.Point(634, 277)
        Me.btnFjern.Name = "btnFjern"
        Me.btnFjern.Size = New System.Drawing.Size(75, 36)
        Me.btnFjern.TabIndex = 5
        Me.btnFjern.Text = "Fjern valgt ansatt"
        Me.btnFjern.UseVisualStyleBackColor = True
        '
        'tbSok
        '
        Me.tbSok.Location = New System.Drawing.Point(12, 11)
        Me.tbSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSok.Multiline = True
        Me.tbSok.Name = "tbSok"
        Me.tbSok.Size = New System.Drawing.Size(300, 40)
        Me.tbSok.TabIndex = 42
        '
        'btnSok
        '
        Me.btnSok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSok.Location = New System.Drawing.Point(318, 10)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(85, 40)
        Me.btnSok.TabIndex = 43
        Me.btnSok.Text = "Søk"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.tbSok)
        Me.Controls.Add(Me.btnFjern)
        Me.Controls.Add(Me.gridAnsatt)
        Me.Controls.Add(Me.pnlLeggtil)
        Me.Controls.Add(Me.btnTilbake)
        Me.Name = "AdminPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminPanel"
        Me.pnlLeggtil.ResumeLayout(False)
        Me.pnlLeggtil.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridAnsatt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTilbake As Button
    Friend WithEvents pnlLeggtil As Panel
    Friend WithEvents btnReg As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnsatt As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbPassord As TextBox
    Friend WithEvents tbEpost As TextBox
    Friend WithEvents tbFornavn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbEtternavn As TextBox
    Friend WithEvents gridAnsatt As DataGridView
    Friend WithEvents btnFjern As Button
    Friend WithEvents tbSok As TextBox
    Friend WithEvents btnSok As Button
End Class
