<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class egenSkjemaBolk10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(egenSkjemaBolk10))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEvt = New System.Windows.Forms.TextBox()
        Me.CheckBoxEpost = New System.Windows.Forms.CheckBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.CheckBoxSms = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Er det noen andre eventuelle opplysninger du vil tilføye?"
        '
        'TextBoxEvt
        '
        Me.TextBoxEvt.Location = New System.Drawing.Point(12, 86)
        Me.TextBoxEvt.MaxLength = 256
        Me.TextBoxEvt.Multiline = True
        Me.TextBoxEvt.Name = "TextBoxEvt"
        Me.TextBoxEvt.Size = New System.Drawing.Size(324, 83)
        Me.TextBoxEvt.TabIndex = 1
        '
        'CheckBoxEpost
        '
        Me.CheckBoxEpost.AutoSize = True
        Me.CheckBoxEpost.Location = New System.Drawing.Point(12, 12)
        Me.CheckBoxEpost.Name = "CheckBoxEpost"
        Me.CheckBoxEpost.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxEpost.TabIndex = 2
        Me.CheckBoxEpost.Text = "spm60"
        Me.CheckBoxEpost.UseVisualStyleBackColor = True
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(12, 186)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(89, 23)
        Me.ButtonSend.TabIndex = 3
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'CheckBoxSms
        '
        Me.CheckBoxSms.AutoSize = True
        Me.CheckBoxSms.Location = New System.Drawing.Point(12, 35)
        Me.CheckBoxSms.Name = "CheckBoxSms"
        Me.CheckBoxSms.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxSms.TabIndex = 4
        Me.CheckBoxSms.Text = "spm61"
        Me.CheckBoxSms.UseVisualStyleBackColor = True
        '
        'egenSkjemaBolk10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(399, 221)
        Me.Controls.Add(Me.CheckBoxSms)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.CheckBoxEpost)
        Me.Controls.Add(Me.TextBoxEvt)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "egenSkjemaBolk10"
        Me.Text = "egenSkjemaBolk10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEvt As TextBox
    Friend WithEvents CheckBoxEpost As CheckBox
    Friend WithEvents ButtonSend As Button
    Friend WithEvents CheckBoxSms As CheckBox
End Class
