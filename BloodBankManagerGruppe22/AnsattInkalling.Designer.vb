<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnsattInkalling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnsattInkalling))
        Me.ButtonLogUt = New System.Windows.Forms.Button()
        Me.GridBrukere = New System.Windows.Forms.DataGridView()
        Me.TextBoxSok = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonSok = New System.Windows.Forms.Button()
        Me.ButtonInnkall = New System.Windows.Forms.Button()
        CType(Me.GridBrukere, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonLogUt
        '
        Me.ButtonLogUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogUt.Location = New System.Drawing.Point(11, 11)
        Me.ButtonLogUt.Name = "ButtonLogUt"
        Me.ButtonLogUt.Size = New System.Drawing.Size(85, 34)
        Me.ButtonLogUt.TabIndex = 25
        Me.ButtonLogUt.Text = "Logg Ut"
        Me.ButtonLogUt.UseVisualStyleBackColor = True
        '
        'GridBrukere
        '
        Me.GridBrukere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBrukere.Location = New System.Drawing.Point(11, 136)
        Me.GridBrukere.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridBrukere.Name = "GridBrukere"
        Me.GridBrukere.RowTemplate.Height = 24
        Me.GridBrukere.Size = New System.Drawing.Size(888, 429)
        Me.GridBrukere.TabIndex = 30
        '
        'TextBoxSok
        '
        Me.TextBoxSok.Location = New System.Drawing.Point(11, 97)
        Me.TextBoxSok.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxSok.Multiline = True
        Me.TextBoxSok.Name = "TextBoxSok"
        Me.TextBoxSok.Size = New System.Drawing.Size(796, 35)
        Me.TextBoxSok.TabIndex = 31
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1128, 122)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 34)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Søk"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonSok
        '
        Me.ButtonSok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSok.Location = New System.Drawing.Point(812, 96)
        Me.ButtonSok.Name = "ButtonSok"
        Me.ButtonSok.Size = New System.Drawing.Size(87, 35)
        Me.ButtonSok.TabIndex = 37
        Me.ButtonSok.Text = "Søk"
        Me.ButtonSok.UseVisualStyleBackColor = True
        '
        'ButtonInnkall
        '
        Me.ButtonInnkall.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInnkall.Location = New System.Drawing.Point(11, 51)
        Me.ButtonInnkall.Name = "ButtonInnkall"
        Me.ButtonInnkall.Size = New System.Drawing.Size(242, 40)
        Me.ButtonInnkall.TabIndex = 39
        Me.ButtonInnkall.Text = "Innkall til ny blodgivningstime"
        Me.ButtonInnkall.UseVisualStyleBackColor = True
        '
        'AnsattInkalling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(910, 601)
        Me.Controls.Add(Me.ButtonInnkall)
        Me.Controls.Add(Me.ButtonSok)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBoxSok)
        Me.Controls.Add(Me.GridBrukere)
        Me.Controls.Add(Me.ButtonLogUt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnsattInkalling"
        Me.Text = "minSideAnsatte"
        CType(Me.GridBrukere, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonLogUt As Button
    Friend WithEvents GridBrukere As DataGridView
    Friend WithEvents TextBoxSok As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ButtonSok As Button
    Friend WithEvents ButtonInnkall As Button
End Class
