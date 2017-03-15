<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class egenSkjemaBolk8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(egenSkjemaBolk8))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButtonN1 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonJ1 = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 26)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Besvares av menn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 207)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 44)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "Gå videre til neste bolk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(25, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(641, 48)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "spm50"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.RadioButtonN1)
        Me.Panel2.Controls.Add(Me.RadioButtonJ1)
        Me.Panel2.Location = New System.Drawing.Point(543, 109)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(132, 48)
        Me.Panel2.TabIndex = 104
        '
        'RadioButtonN1
        '
        Me.RadioButtonN1.AutoSize = True
        Me.RadioButtonN1.Location = New System.Drawing.Point(104, 12)
        Me.RadioButtonN1.Margin = New System.Windows.Forms.Padding(6)
        Me.RadioButtonN1.Name = "RadioButtonN1"
        Me.RadioButtonN1.Size = New System.Drawing.Size(27, 26)
        Me.RadioButtonN1.TabIndex = 37
        Me.RadioButtonN1.TabStop = True
        Me.RadioButtonN1.Tag = "1"
        Me.RadioButtonN1.UseVisualStyleBackColor = True
        '
        'RadioButtonJ1
        '
        Me.RadioButtonJ1.AutoSize = True
        Me.RadioButtonJ1.Location = New System.Drawing.Point(0, 12)
        Me.RadioButtonJ1.Margin = New System.Windows.Forms.Padding(6)
        Me.RadioButtonJ1.Name = "RadioButtonJ1"
        Me.RadioButtonJ1.Size = New System.Drawing.Size(27, 26)
        Me.RadioButtonJ1.TabIndex = 38
        Me.RadioButtonJ1.TabStop = True
        Me.RadioButtonJ1.Tag = "1"
        Me.RadioButtonJ1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(642, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 25)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Nei"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(538, 62)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 25)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Ja"
        '
        'egenSkjemaBolk8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 316)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "egenSkjemaBolk8"
        Me.Text = "egenSkjemaBolk8"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButtonN1 As RadioButton
    Friend WithEvents RadioButtonJ1 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
