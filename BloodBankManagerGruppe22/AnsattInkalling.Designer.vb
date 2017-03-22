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
        Me.ButtonLogUt.Location = New System.Drawing.Point(15, 14)
        Me.ButtonLogUt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonLogUt.Name = "ButtonLogUt"
        Me.ButtonLogUt.Size = New System.Drawing.Size(113, 42)
        Me.ButtonLogUt.TabIndex = 25
        Me.ButtonLogUt.Text = "Logg Ut"
        Me.ButtonLogUt.UseVisualStyleBackColor = True
        '
        'GridBrukere
        '
        Me.GridBrukere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBrukere.Location = New System.Drawing.Point(15, 167)
        Me.GridBrukere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridBrukere.Name = "GridBrukere"
        Me.GridBrukere.RowTemplate.Height = 24
        Me.GridBrukere.Size = New System.Drawing.Size(1184, 528)
        Me.GridBrukere.TabIndex = 30
        '
        'TextBoxSok
        '
        Me.TextBoxSok.Location = New System.Drawing.Point(15, 119)
        Me.TextBoxSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxSok.Multiline = True
        Me.TextBoxSok.Name = "TextBoxSok"
        Me.TextBoxSok.Size = New System.Drawing.Size(1060, 42)
        Me.TextBoxSok.TabIndex = 31
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1504, 150)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 42)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Søk"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonSok
        '
        Me.ButtonSok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSok.Location = New System.Drawing.Point(1083, 118)
        Me.ButtonSok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSok.Name = "ButtonSok"
        Me.ButtonSok.Size = New System.Drawing.Size(116, 43)
        Me.ButtonSok.TabIndex = 37
        Me.ButtonSok.Text = "Søk"
        Me.ButtonSok.UseVisualStyleBackColor = True
        '
        'ButtonInnkall
        '
        Me.ButtonInnkall.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInnkall.Location = New System.Drawing.Point(15, 63)
        Me.ButtonInnkall.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonInnkall.Name = "ButtonInnkall"
        Me.ButtonInnkall.Size = New System.Drawing.Size(323, 49)
        Me.ButtonInnkall.TabIndex = 39
        Me.ButtonInnkall.Text = "Innkall til ny blodgivningstime"
        Me.ButtonInnkall.UseVisualStyleBackColor = True
        '
        'AnsattInkalling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1213, 740)
        Me.Controls.Add(Me.ButtonInnkall)
        Me.Controls.Add(Me.ButtonSok)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBoxSok)
        Me.Controls.Add(Me.GridBrukere)
        Me.Controls.Add(Me.ButtonLogUt)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
