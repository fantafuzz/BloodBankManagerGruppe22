﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BrukerMinSide
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrukerMinSide))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Endre_mine_opplysninger = New System.Windows.Forms.Button()
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.Bestill_Ny_BlodTime = New System.Windows.Forms.Button()
        Me.Lab_Svar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(238, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Velkommen til Minside"
        '
        'Endre_mine_opplysninger
        '
        Me.Endre_mine_opplysninger.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endre_mine_opplysninger.Location = New System.Drawing.Point(199, 92)
        Me.Endre_mine_opplysninger.Name = "Endre_mine_opplysninger"
        Me.Endre_mine_opplysninger.Size = New System.Drawing.Size(376, 51)
        Me.Endre_mine_opplysninger.TabIndex = 25
        Me.Endre_mine_opplysninger.Text = "Endre Mine Opplysninger"
        Me.Endre_mine_opplysninger.UseVisualStyleBackColor = True
        '
        'Logg_ut
        '
        Me.Logg_ut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logg_ut.Location = New System.Drawing.Point(595, 311)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(138, 31)
        Me.Logg_ut.TabIndex = 30
        Me.Logg_ut.Text = "Logg Ut"
        Me.Logg_ut.UseVisualStyleBackColor = True
        '
        'Bestill_Ny_BlodTime
        '
        Me.Bestill_Ny_BlodTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bestill_Ny_BlodTime.Location = New System.Drawing.Point(199, 140)
        Me.Bestill_Ny_BlodTime.Name = "Bestill_Ny_BlodTime"
        Me.Bestill_Ny_BlodTime.Size = New System.Drawing.Size(376, 56)
        Me.Bestill_Ny_BlodTime.TabIndex = 28
        Me.Bestill_Ny_BlodTime.Text = "Bestill ny blodgivning"
        Me.Bestill_Ny_BlodTime.UseVisualStyleBackColor = True
        '
        'Lab_Svar
        '
        Me.Lab_Svar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Svar.Location = New System.Drawing.Point(199, 195)
        Me.Lab_Svar.Name = "Lab_Svar"
        Me.Lab_Svar.Size = New System.Drawing.Size(376, 56)
        Me.Lab_Svar.TabIndex = 31
        Me.Lab_Svar.Text = "Labaratorie Svar"
        Me.Lab_Svar.UseVisualStyleBackColor = True
        '
        'BrukerMinSide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(756, 363)
        Me.Controls.Add(Me.Lab_Svar)
        Me.Controls.Add(Me.Logg_ut)
        Me.Controls.Add(Me.Bestill_Ny_BlodTime)
        Me.Controls.Add(Me.Endre_mine_opplysninger)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BrukerMinSide"
        Me.Text = "MINSIDENAVIGASJON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Endre_mine_opplysninger As Button
    Friend WithEvents Logg_ut As Button
    Friend WithEvents Bestill_Ny_BlodTime As Button
    Friend WithEvents Lab_Svar As Button
End Class
