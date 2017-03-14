<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class minSideAnsatte
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(11, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 34)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Logg Ut"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(11, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 43)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Innkalling av blodgivere"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(11, 122)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(245, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(660, 158)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(553, 332)
        Me.DataGridView1.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(660, 122)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(463, 35)
        Me.TextBox1.TabIndex = 31
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Utlevering og Bestilling av blodprodukter"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(15, 252)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(244, 43)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Utlevering av blodprodukter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(15, 301)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(244, 43)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Bestill blodprodukter"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'minSideAnsatte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(1294, 773)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "minSideAnsatte"
        Me.Text = "minSideAnsatte"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
End Class
