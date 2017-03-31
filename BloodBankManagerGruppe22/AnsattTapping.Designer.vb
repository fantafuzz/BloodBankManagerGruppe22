<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsattTapping
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GridBruker = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.GridBruker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(460, 31)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(609, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Søk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 550)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 59)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Registrer Tapping"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GridBruker
        '
        Me.GridBruker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBruker.Location = New System.Drawing.Point(95, 148)
        Me.GridBruker.Name = "GridBruker"
        Me.GridBruker.RowTemplate.Height = 33
        Me.GridBruker.Size = New System.Drawing.Size(1114, 260)
        Me.GridBruker.TabIndex = 7
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(107, 458)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(155, 29)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "400 ml blod"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'AnsattTapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 757)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GridBruker)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "AnsattTapping"
        Me.Text = "AnsattTapping"
        CType(Me.GridBruker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GridBruker As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
End Class
