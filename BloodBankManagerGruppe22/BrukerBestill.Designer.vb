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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(31, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(376, 56)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Bestill ny blodgivning"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(33, 133)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(374, 23)
        Me.DateTimePicker1.TabIndex = 30
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(49, 215)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 31
        '
        'BrukerBestill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(442, 585)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BrukerBestill"
        Me.Text = "kalender_bestilling"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
