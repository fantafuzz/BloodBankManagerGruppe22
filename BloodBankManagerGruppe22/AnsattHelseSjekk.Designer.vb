<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnsattHelseSjekk
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
        Me.gridBruker = New System.Windows.Forms.DataGridView()
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.tbSok = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.rbGodkjent = New System.Windows.Forms.RadioButton()
        Me.rbIkkeGodkjent = New System.Windows.Forms.RadioButton()
        Me.PanelUtfor = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.tbEtternavn = New System.Windows.Forms.TextBox()
        Me.tbSisteE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFornavn = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnVelg = New System.Windows.Forms.Button()
        Me.PanelVelg = New System.Windows.Forms.Panel()
        CType(Me.gridBruker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUtfor.SuspendLayout()
        Me.PanelVelg.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridBruker
        '
        Me.gridBruker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBruker.Location = New System.Drawing.Point(3, 46)
        Me.gridBruker.Margin = New System.Windows.Forms.Padding(2)
        Me.gridBruker.Name = "gridBruker"
        Me.gridBruker.RowTemplate.Height = 24
        Me.gridBruker.Size = New System.Drawing.Size(761, 409)
        Me.gridBruker.TabIndex = 1
        '
        'Logg_ut
        '
        Me.Logg_ut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logg_ut.Location = New System.Drawing.Point(556, 503)
        Me.Logg_ut.Margin = New System.Windows.Forms.Padding(2)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(217, 47)
        Me.Logg_ut.TabIndex = 33
        Me.Logg_ut.Text = "Tilbake "
        Me.Logg_ut.UseVisualStyleBackColor = True
        '
        'tbSok
        '
        Me.tbSok.Location = New System.Drawing.Point(3, 2)
        Me.tbSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSok.Multiline = True
        Me.tbSok.Name = "tbSok"
        Me.tbSok.Size = New System.Drawing.Size(300, 40)
        Me.tbSok.TabIndex = 37
        '
        'btnSok
        '
        Me.btnSok.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSok.Location = New System.Drawing.Point(309, 2)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(139, 40)
        Me.btnSok.TabIndex = 38
        Me.btnSok.Text = "Søk"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'rbGodkjent
        '
        Me.rbGodkjent.AutoSize = True
        Me.rbGodkjent.Location = New System.Drawing.Point(637, 402)
        Me.rbGodkjent.Name = "rbGodkjent"
        Me.rbGodkjent.Size = New System.Drawing.Size(68, 17)
        Me.rbGodkjent.TabIndex = 39
        Me.rbGodkjent.TabStop = True
        Me.rbGodkjent.Text = "Godkjent"
        Me.rbGodkjent.UseVisualStyleBackColor = True
        '
        'rbIkkeGodkjent
        '
        Me.rbIkkeGodkjent.AutoSize = True
        Me.rbIkkeGodkjent.Location = New System.Drawing.Point(637, 425)
        Me.rbIkkeGodkjent.Name = "rbIkkeGodkjent"
        Me.rbIkkeGodkjent.Size = New System.Drawing.Size(90, 17)
        Me.rbIkkeGodkjent.TabIndex = 40
        Me.rbIkkeGodkjent.TabStop = True
        Me.rbIkkeGodkjent.Text = "Ikke godkjent"
        Me.rbIkkeGodkjent.UseVisualStyleBackColor = True
        '
        'PanelUtfor
        '
        Me.PanelUtfor.Controls.Add(Me.Button1)
        Me.PanelUtfor.Controls.Add(Me.ListView1)
        Me.PanelUtfor.Controls.Add(Me.tbEtternavn)
        Me.PanelUtfor.Controls.Add(Me.tbSisteE)
        Me.PanelUtfor.Controls.Add(Me.Label4)
        Me.PanelUtfor.Controls.Add(Me.Label3)
        Me.PanelUtfor.Controls.Add(Me.Label1)
        Me.PanelUtfor.Controls.Add(Me.tbFornavn)
        Me.PanelUtfor.Controls.Add(Me.btnReg)
        Me.PanelUtfor.Controls.Add(Me.rbGodkjent)
        Me.PanelUtfor.Controls.Add(Me.rbIkkeGodkjent)
        Me.PanelUtfor.Location = New System.Drawing.Point(12, 12)
        Me.PanelUtfor.Name = "PanelUtfor"
        Me.PanelUtfor.Size = New System.Drawing.Size(770, 486)
        Me.PanelUtfor.TabIndex = 41
        Me.PanelUtfor.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Velg ny blodgiver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(6, 35)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(750, 356)
        Me.ListView1.TabIndex = 44
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'tbEtternavn
        '
        Me.tbEtternavn.Location = New System.Drawing.Point(245, 9)
        Me.tbEtternavn.Name = "tbEtternavn"
        Me.tbEtternavn.ReadOnly = True
        Me.tbEtternavn.Size = New System.Drawing.Size(100, 20)
        Me.tbEtternavn.TabIndex = 50
        '
        'tbSisteE
        '
        Me.tbSisteE.Location = New System.Drawing.Point(473, 9)
        Me.tbSisteE.Name = "tbSisteE"
        Me.tbSisteE.ReadOnly = True
        Me.tbSisteE.Size = New System.Drawing.Size(100, 20)
        Me.tbSisteE.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Siste egenerklæring:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Etternavn:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Fornavn:"
        '
        'tbFornavn
        '
        Me.tbFornavn.Location = New System.Drawing.Point(58, 9)
        Me.tbFornavn.Name = "tbFornavn"
        Me.tbFornavn.ReadOnly = True
        Me.tbFornavn.Size = New System.Drawing.Size(100, 20)
        Me.tbFornavn.TabIndex = 42
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(614, 448)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(144, 23)
        Me.btnReg.TabIndex = 41
        Me.btnReg.Text = "Registrer helsesjekk"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnVelg
        '
        Me.btnVelg.Location = New System.Drawing.Point(3, 460)
        Me.btnVelg.Name = "btnVelg"
        Me.btnVelg.Size = New System.Drawing.Size(75, 23)
        Me.btnVelg.TabIndex = 42
        Me.btnVelg.Text = "Velg bruker"
        Me.btnVelg.UseVisualStyleBackColor = True
        '
        'PanelVelg
        '
        Me.PanelVelg.Controls.Add(Me.tbSok)
        Me.PanelVelg.Controls.Add(Me.btnVelg)
        Me.PanelVelg.Controls.Add(Me.btnSok)
        Me.PanelVelg.Controls.Add(Me.gridBruker)
        Me.PanelVelg.Location = New System.Drawing.Point(12, 12)
        Me.PanelVelg.Name = "PanelVelg"
        Me.PanelVelg.Size = New System.Drawing.Size(770, 486)
        Me.PanelVelg.TabIndex = 43
        '
        'AnsattHelseSjekk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PanelVelg)
        Me.Controls.Add(Me.PanelUtfor)
        Me.Controls.Add(Me.Logg_ut)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AnsattHelseSjekk"
        Me.Text = "AnsattHelseSjekk"
        CType(Me.gridBruker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUtfor.ResumeLayout(False)
        Me.PanelUtfor.PerformLayout()
        Me.PanelVelg.ResumeLayout(False)
        Me.PanelVelg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridBruker As DataGridView
    Friend WithEvents Logg_ut As Button
    Friend WithEvents tbSok As TextBox
    Friend WithEvents btnSok As Button
    Friend WithEvents rbGodkjent As RadioButton
    Friend WithEvents rbIkkeGodkjent As RadioButton
    Friend WithEvents PanelUtfor As Panel
    Friend WithEvents tbEtternavn As TextBox
    Friend WithEvents tbSisteE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFornavn As TextBox
    Friend WithEvents btnReg As Button
    Friend WithEvents btnVelg As Button
    Friend WithEvents PanelVelg As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
End Class
