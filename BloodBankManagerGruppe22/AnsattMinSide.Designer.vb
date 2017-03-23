<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsattMinSide
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnsattMinSide))
        Me.Statistikk = New System.Windows.Forms.Button()
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.Bestill_Ny_BlodTime = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Statistikk
        '
        Me.Statistikk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statistikk.Location = New System.Drawing.Point(198, 227)
        Me.Statistikk.Name = "Statistikk"
        Me.Statistikk.Size = New System.Drawing.Size(376, 56)
        Me.Statistikk.TabIndex = 39
        Me.Statistikk.Text = "Statistikk"
        Me.Statistikk.UseVisualStyleBackColor = True
        '
        'Logg_ut
        '
        Me.Logg_ut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logg_ut.Location = New System.Drawing.Point(626, 349)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(138, 31)
        Me.Logg_ut.TabIndex = 37
        Me.Logg_ut.Text = "Logg Ut"
        Me.Logg_ut.UseVisualStyleBackColor = True
        '
        'Bestill_Ny_BlodTime
        '
        Me.Bestill_Ny_BlodTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bestill_Ny_BlodTime.Location = New System.Drawing.Point(198, 103)
        Me.Bestill_Ny_BlodTime.Name = "Bestill_Ny_BlodTime"
        Me.Bestill_Ny_BlodTime.Size = New System.Drawing.Size(376, 56)
        Me.Bestill_Ny_BlodTime.TabIndex = 36
        Me.Bestill_Ny_BlodTime.Text = "Bestill ny blodgivning"
        Me.Bestill_Ny_BlodTime.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(236, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 31)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Velkommen til Minside"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(198, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(376, 56)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Blodprodukter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AnsattMinSide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 392)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Statistikk)
        Me.Controls.Add(Me.Logg_ut)
        Me.Controls.Add(Me.Bestill_Ny_BlodTime)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AnsattMinSide"
        Me.Text = "minSideNavigasjonAnsatte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Statistikk As Button
    Friend WithEvents Logg_ut As Button
    Friend WithEvents Bestill_Ny_BlodTime As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
