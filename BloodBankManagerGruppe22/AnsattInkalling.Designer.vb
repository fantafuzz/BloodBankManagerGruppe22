<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnsattInkalling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnsattInkalling))
        Me.ButtonTilbake = New System.Windows.Forms.Button()
        Me.GridBrukere = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonInnkall = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.GridBrukere, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonTilbake
        '
        Me.ButtonTilbake.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTilbake.Location = New System.Drawing.Point(632, 509)
        Me.ButtonTilbake.Name = "ButtonTilbake"
        Me.ButtonTilbake.Size = New System.Drawing.Size(140, 40)
        Me.ButtonTilbake.TabIndex = 25
        Me.ButtonTilbake.Text = "Tilbake"
        Me.ButtonTilbake.UseVisualStyleBackColor = True
        '
        'GridBrukere
        '
        Me.GridBrukere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBrukere.Location = New System.Drawing.Point(12, 11)
        Me.GridBrukere.Margin = New System.Windows.Forms.Padding(2)
        Me.GridBrukere.Name = "GridBrukere"
        Me.GridBrukere.RowTemplate.Height = 24
        Me.GridBrukere.Size = New System.Drawing.Size(760, 336)
        Me.GridBrukere.TabIndex = 30
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(391, 436)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 34)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Søk"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonInnkall
        '
        Me.ButtonInnkall.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInnkall.Location = New System.Drawing.Point(12, 625)
        Me.ButtonInnkall.Name = "ButtonInnkall"
        Me.ButtonInnkall.Size = New System.Drawing.Size(242, 40)
        Me.ButtonInnkall.TabIndex = 39
        Me.ButtonInnkall.Text = "Innkall til ny blodgivningstime"
        Me.ButtonInnkall.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 358)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 40
        '
        'AnsattInkalling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.ButtonInnkall)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GridBrukere)
        Me.Controls.Add(Me.ButtonTilbake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "AnsattInkalling"
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        CType(Me.GridBrukere, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonTilbake As Button
    Friend WithEvents GridBrukere As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents ButtonInnkall As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
