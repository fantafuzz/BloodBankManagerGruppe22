<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MINSIDENAVIGASJON
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1_nyBlodTime = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Velkommen til Minside"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(17, 68)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(429, 47)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Endre Mine Opplysninger"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(19, 122)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(429, 64)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Hvor mye blod har jeg gitt til blodbanken?"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 193)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(429, 64)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Bestill ny blodgivning"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1_nyBlodTime
        '
        Me.DateTimePicker1_nyBlodTime.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1_nyBlodTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1_nyBlodTime.Location = New System.Drawing.Point(20, 263)
        Me.DateTimePicker1_nyBlodTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1_nyBlodTime.Name = "DateTimePicker1_nyBlodTime"
        Me.DateTimePicker1_nyBlodTime.Size = New System.Drawing.Size(426, 22)
        Me.DateTimePicker1_nyBlodTime.TabIndex = 29
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(619, 15)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 36)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Logg Ut"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MINSIDENAVIGASJON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(731, 329)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DateTimePicker1_nyBlodTime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MINSIDENAVIGASJON"
        Me.Text = "MINSIDENAVIGASJON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1_nyBlodTime As DateTimePicker
    Friend WithEvents Button4 As Button
End Class
