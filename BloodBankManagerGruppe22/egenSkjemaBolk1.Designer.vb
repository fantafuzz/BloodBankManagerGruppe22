﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class egenSkjemaBolk1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(egenSkjemaBolk1))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 26)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Vennligst besvar:"
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(30, 315)
        Me.CheckBox14.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(310, 29)
        Me.CheckBox14.TabIndex = 72
        Me.CheckBox14.Text = "Har du piercing i slimhinne?"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(30, 271)
        Me.CheckBox15.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(448, 29)
        Me.CheckBox15.TabIndex = 71
        Me.CheckBox15.Text = "Har du åpne sår, eksem eller hudsykdom?"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(30, 227)
        Me.CheckBox16.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(278, 29)
        Me.CheckBox16.TabIndex = 70
        Me.CheckBox16.Text = "Veier du 50kg eller mer?"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(30, 183)
        Me.CheckBox17.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(894, 29)
        Me.CheckBox17.TabIndex = 69
        Me.CheckBox17.Text = "Hvis du har gitt blod tidligere, har du vært frisk i perioden fra forrige blodgiv" &
    "ning og til nå?"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(30, 138)
        Me.CheckBox18.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(253, 29)
        Me.CheckBox18.TabIndex = 68
        Me.CheckBox18.Text = "Føler du deg frisk nå?"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Location = New System.Drawing.Point(30, 94)
        Me.CheckBox19.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(424, 29)
        Me.CheckBox19.TabIndex = 67
        Me.CheckBox19.Text = "Har du fått informasjon om blodgivning?"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(30, 377)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 44)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Gå videre til neste bolk"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'egenSkjemaBolk1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(1038, 473)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.CheckBox15)
        Me.Controls.Add(Me.CheckBox16)
        Me.Controls.Add(Me.CheckBox17)
        Me.Controls.Add(Me.CheckBox18)
        Me.Controls.Add(Me.CheckBox19)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "egenSkjemaBolk1"
        Me.Text = "egenerklæring"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents Button2 As Button
End Class
