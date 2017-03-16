<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class egenSkjemaBolk5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(egenSkjemaBolk5))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButtonN1 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonJ1 = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(332, 26)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Har du i løpet av de siste to år"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 45)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Gå videre til neste bolk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(15, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 58)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "spm29"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.RadioButtonN1)
        Me.Panel2.Controls.Add(Me.RadioButtonJ1)
        Me.Panel2.Location = New System.Drawing.Point(611, 86)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(132, 48)
        Me.Panel2.TabIndex = 80
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(697, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 27)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Nei"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(618, 27)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 27)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Ja"
        '
        'egenSkjemaBolk5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(788, 229)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "egenSkjemaBolk5"
        Me.Text = "egenSkjemaBolk5"
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
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
