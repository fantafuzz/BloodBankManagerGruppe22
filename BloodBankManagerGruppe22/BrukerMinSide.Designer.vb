<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.LabelOverskrift = New System.Windows.Forms.Label()
        Me.ButtonEndre = New System.Windows.Forms.Button()
        Me.Logg_ut = New System.Windows.Forms.Button()
        Me.ButtonBestill = New System.Windows.Forms.Button()
        Me.ButtonLabSvar = New System.Windows.Forms.Button()
        Me.ButtonEgenerklering = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelOverskrift
        '
        Me.LabelOverskrift.AutoSize = True
        Me.LabelOverskrift.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOverskrift.Location = New System.Drawing.Point(164, 27)
        Me.LabelOverskrift.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelOverskrift.Name = "LabelOverskrift"
        Me.LabelOverskrift.Size = New System.Drawing.Size(523, 55)
        Me.LabelOverskrift.TabIndex = 0
        Me.LabelOverskrift.Text = "Velkommen til Minside"
        '
        'ButtonEndre
        '
        Me.ButtonEndre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEndre.Location = New System.Drawing.Point(245, 188)
        Me.ButtonEndre.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEndre.Name = "ButtonEndre"
        Me.ButtonEndre.Size = New System.Drawing.Size(389, 122)
        Me.ButtonEndre.TabIndex = 25
        Me.ButtonEndre.Text = "Endre Mine Opplysninger"
        Me.ButtonEndre.UseVisualStyleBackColor = True
        '
        'Logg_ut
        '
        Me.Logg_ut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logg_ut.Location = New System.Drawing.Point(685, 519)
        Me.Logg_ut.Margin = New System.Windows.Forms.Padding(2)
        Me.Logg_ut.Name = "Logg_ut"
        Me.Logg_ut.Size = New System.Drawing.Size(88, 32)
        Me.Logg_ut.TabIndex = 30
        Me.Logg_ut.Text = "Logg Ut"
        Me.Logg_ut.UseVisualStyleBackColor = True
        '
        'ButtonBestill
        '
        Me.ButtonBestill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBestill.Location = New System.Drawing.Point(245, 294)
        Me.ButtonBestill.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBestill.Name = "ButtonBestill"
        Me.ButtonBestill.Size = New System.Drawing.Size(389, 124)
        Me.ButtonBestill.TabIndex = 28
        Me.ButtonBestill.Text = "Bestill ny blodgivning"
        Me.ButtonBestill.UseVisualStyleBackColor = True
        '
        'ButtonLabSvar
        '
        Me.ButtonLabSvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLabSvar.Location = New System.Drawing.Point(245, 392)
        Me.ButtonLabSvar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonLabSvar.Name = "ButtonLabSvar"
        Me.ButtonLabSvar.Size = New System.Drawing.Size(389, 127)
        Me.ButtonLabSvar.TabIndex = 31
        Me.ButtonLabSvar.Text = "Labaratorie Svar"
        Me.ButtonLabSvar.UseVisualStyleBackColor = True
        '
        'ButtonEgenerklering
        '
        Me.ButtonEgenerklering.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEgenerklering.Location = New System.Drawing.Point(245, 108)
        Me.ButtonEgenerklering.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEgenerklering.Name = "ButtonEgenerklering"
        Me.ButtonEgenerklering.Size = New System.Drawing.Size(389, 95)
        Me.ButtonEgenerklering.TabIndex = 32
        Me.ButtonEgenerklering.Text = "Lever Egenerklæring"
        Me.ButtonEgenerklering.UseVisualStyleBackColor = True
        '
        'BrukerMinSide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.ButtonEgenerklering)
        Me.Controls.Add(Me.ButtonLabSvar)
        Me.Controls.Add(Me.Logg_ut)
        Me.Controls.Add(Me.ButtonBestill)
        Me.Controls.Add(Me.ButtonEndre)
        Me.Controls.Add(Me.LabelOverskrift)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BrukerMinSide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelOverskrift As Label
    Friend WithEvents ButtonEndre As Button
    Friend WithEvents Logg_ut As Button
    Friend WithEvents ButtonBestill As Button
    Friend WithEvents ButtonLabSvar As Button
    Friend WithEvents ButtonEgenerklering As Button
End Class
