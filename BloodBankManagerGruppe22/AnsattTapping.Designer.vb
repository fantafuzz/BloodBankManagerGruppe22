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
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_ = New System.Windows.Forms.Button()
        CType(Me.GridBruker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(308, 37)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(344, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Søk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 498)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(344, 62)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Registrer Tapping"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GridBruker
        '
        Me.GridBruker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBruker.Location = New System.Drawing.Point(15, 58)
        Me.GridBruker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridBruker.Name = "GridBruker"
        Me.GridBruker.RowTemplate.Height = 33
        Me.GridBruker.Size = New System.Drawing.Size(828, 366)
        Me.GridBruker.TabIndex = 7
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(15, 428)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(137, 28)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "400 ml blod"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_
        '
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_.Location = New System.Drawing.Point(694, 498)
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_.Name = "Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_"
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_.Size = New System.Drawing.Size(149, 62)
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_.TabIndex = 9
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_.Text = "Tilbake"
        Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_.UseVisualStyleBackColor = True
        '
        'AnsattTapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(855, 571)
        Me.Controls.Add(Me.Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GridBruker)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents Button_Ansatt_Tilbake_fra_BlodtappingAnsatt_ As Button
End Class
