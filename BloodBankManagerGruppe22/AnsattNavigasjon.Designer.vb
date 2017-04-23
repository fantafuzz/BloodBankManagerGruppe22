<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsattNavigasjon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnsattNavigasjon))
        Me.Statistikk = New System.Windows.Forms.Button()
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.Bestill_Ny_BlodTime = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_blodprodukter = New System.Windows.Forms.Button()
        Me.Button_tapping_blod = New System.Windows.Forms.Button()
        Me.Button_helsesjekk = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Statistikk
        '
        Me.Statistikk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statistikk.Location = New System.Drawing.Point(116, 400)
        Me.Statistikk.Name = "Statistikk"
        Me.Statistikk.Size = New System.Drawing.Size(516, 90)
        Me.Statistikk.TabIndex = 39
        Me.Statistikk.Text = "Statistikk"
        Me.Statistikk.UseVisualStyleBackColor = True
        '
        'Logg_ut
        '
        Me.Logg_ut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logg_ut.Location = New System.Drawing.Point(634, 527)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(138, 31)
        Me.Logg_ut.TabIndex = 37
        Me.Logg_ut.Text = "Logg Ut"
        Me.Logg_ut.UseVisualStyleBackColor = True
        '
        'Bestill_Ny_BlodTime
        '
        Me.Bestill_Ny_BlodTime.BackColor = System.Drawing.Color.Transparent
        Me.Bestill_Ny_BlodTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bestill_Ny_BlodTime.Location = New System.Drawing.Point(116, 85)
        Me.Bestill_Ny_BlodTime.Name = "Bestill_Ny_BlodTime"
        Me.Bestill_Ny_BlodTime.Size = New System.Drawing.Size(516, 85)
        Me.Bestill_Ny_BlodTime.TabIndex = 36
        Me.Bestill_Ny_BlodTime.Text = "Bestill ny blodgivning"
        Me.Bestill_Ny_BlodTime.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 73)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Velkommen "
        '
        'Button_blodprodukter
        '
        Me.Button_blodprodukter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_blodprodukter.Location = New System.Drawing.Point(116, 164)
        Me.Button_blodprodukter.Name = "Button_blodprodukter"
        Me.Button_blodprodukter.Size = New System.Drawing.Size(516, 81)
        Me.Button_blodprodukter.TabIndex = 40
        Me.Button_blodprodukter.Text = "Utlevering av blodprodukter"
        Me.Button_blodprodukter.UseVisualStyleBackColor = True
        '
        'Button_tapping_blod
        '
        Me.Button_tapping_blod.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_tapping_blod.Location = New System.Drawing.Point(116, 235)
        Me.Button_tapping_blod.Name = "Button_tapping_blod"
        Me.Button_tapping_blod.Size = New System.Drawing.Size(516, 90)
        Me.Button_tapping_blod.TabIndex = 43
        Me.Button_tapping_blod.Text = "Tapping Av Blod"
        Me.Button_tapping_blod.UseVisualStyleBackColor = True
        '
        'Button_helsesjekk
        '
        Me.Button_helsesjekk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_helsesjekk.Location = New System.Drawing.Point(116, 318)
        Me.Button_helsesjekk.Name = "Button_helsesjekk"
        Me.Button_helsesjekk.Size = New System.Drawing.Size(516, 90)
        Me.Button_helsesjekk.TabIndex = 44
        Me.Button_helsesjekk.Text = "Helsesjekk"
        Me.Button_helsesjekk.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(12, 527)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(143, 23)
        Me.btnAdmin.TabIndex = 45
        Me.btnAdmin.Text = "Administrer ansatte"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'AnsattNavigasjon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.Button_helsesjekk)
        Me.Controls.Add(Me.Button_tapping_blod)
        Me.Controls.Add(Me.Button_blodprodukter)
        Me.Controls.Add(Me.Statistikk)
        Me.Controls.Add(Me.Logg_ut)
        Me.Controls.Add(Me.Bestill_Ny_BlodTime)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AnsattNavigasjon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Statistikk As Button
    Friend WithEvents Logg_ut As Button
    Friend WithEvents Bestill_Ny_BlodTime As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_blodprodukter As Button
    Friend WithEvents Button_tapping_blod As Button
    Friend WithEvents Button_helsesjekk As Button
    Friend WithEvents btnAdmin As Button
End Class
