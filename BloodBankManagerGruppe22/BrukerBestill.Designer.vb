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
        Me.btnBestill = New System.Windows.Forms.Button()
        Me.kalender1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBestill
        '
        Me.btnBestill.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestill.Location = New System.Drawing.Point(12, 494)
        Me.btnBestill.Name = "btnBestill"
        Me.btnBestill.Size = New System.Drawing.Size(376, 56)
        Me.btnBestill.TabIndex = 29
        Me.btnBestill.Text = "Bestill ny blodgivning"
        Me.btnBestill.UseVisualStyleBackColor = True
        '
        'kalender1
        '
        Me.kalender1.CalendarDimensions = New System.Drawing.Size(4, 3)
        Me.kalender1.Location = New System.Drawing.Point(12, 29)
        Me.kalender1.Name = "kalender1"
        Me.kalender1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Velg en passende dato i kalenderen for blodgivning"
        '
        'btnTilbake
        '
        Me.btnTilbake.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilbake.Location = New System.Drawing.Point(570, 507)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(138, 31)
        Me.btnTilbake.TabIndex = 33
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'BrukerBestill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.kalender1)
        Me.Controls.Add(Me.btnBestill)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BrukerBestill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBestill As Button
    Friend WithEvents kalender1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTilbake As Button
End Class
