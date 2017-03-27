<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrukerBestill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrukerBestill))
        Me.Button_bestill_ny_time_blod_bruker_blodgiver = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kalender_bestilling_blodgiver_tilbake_ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_bestill_ny_time_blod_bruker_blodgiver
        '
        Me.Button_bestill_ny_time_blod_bruker_blodgiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_bestill_ny_time_blod_bruker_blodgiver.Location = New System.Drawing.Point(18, 526)
        Me.Button_bestill_ny_time_blod_bruker_blodgiver.Name = "Button_bestill_ny_time_blod_bruker_blodgiver"
        Me.Button_bestill_ny_time_blod_bruker_blodgiver.Size = New System.Drawing.Size(376, 56)
        Me.Button_bestill_ny_time_blod_bruker_blodgiver.TabIndex = 29
        Me.Button_bestill_ny_time_blod_bruker_blodgiver.Text = "Bestill ny blodgivning"
        Me.Button_bestill_ny_time_blod_bruker_blodgiver.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(4, 3)
        Me.MonthCalendar1.Location = New System.Drawing.Point(2, 56)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(724, 31)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Velg en passende dato i kalenderen for blodgivning"
        '
        'kalender_bestilling_blodgiver_tilbake_
        '
        Me.kalender_bestilling_blodgiver_tilbake_.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kalender_bestilling_blodgiver_tilbake_.Location = New System.Drawing.Point(1064, 662)
        Me.kalender_bestilling_blodgiver_tilbake_.Name = "kalender_bestilling_blodgiver_tilbake_"
        Me.kalender_bestilling_blodgiver_tilbake_.Size = New System.Drawing.Size(138, 31)
        Me.kalender_bestilling_blodgiver_tilbake_.TabIndex = 33
        Me.kalender_bestilling_blodgiver_tilbake_.Text = "Tilbake"
        Me.kalender_bestilling_blodgiver_tilbake_.UseVisualStyleBackColor = True
        '
        'BrukerBestill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1214, 705)
        Me.Controls.Add(Me.kalender_bestilling_blodgiver_tilbake_)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button_bestill_ny_time_blod_bruker_blodgiver)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BrukerBestill"
        Me.Text = "kalender_bestilling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_bestill_ny_time_blod_bruker_blodgiver As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents kalender_bestilling_blodgiver_tilbake_ As Button
End Class
