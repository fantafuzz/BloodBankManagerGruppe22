<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsattTapping
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
        Me.tbSok = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.btnRegistrer = New System.Windows.Forms.Button()
        Me.GridBruker = New System.Windows.Forms.DataGridView()
        Me.chkBlod = New System.Windows.Forms.CheckBox()
        Me.btnTilbake = New System.Windows.Forms.Button()
        CType(Me.GridBruker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSok
        '
        Me.tbSok.Location = New System.Drawing.Point(15, 14)
        Me.tbSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSok.Multiline = True
        Me.tbSok.Name = "tbSok"
        Me.tbSok.Size = New System.Drawing.Size(308, 37)
        Me.tbSok.TabIndex = 0
        '
        'btnSok
        '
        Me.btnSok.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSok.Location = New System.Drawing.Point(344, 12)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(139, 39)
        Me.btnSok.TabIndex = 5
        Me.btnSok.Text = "Søk"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrer.Location = New System.Drawing.Point(12, 488)
        Me.btnRegistrer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(344, 62)
        Me.btnRegistrer.TabIndex = 6
        Me.btnRegistrer.Text = "Registrer Tapping"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'GridBruker
        '
        Me.GridBruker.AllowUserToAddRows = False
        Me.GridBruker.AllowUserToDeleteRows = False
        Me.GridBruker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBruker.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridBruker.Location = New System.Drawing.Point(15, 58)
        Me.GridBruker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridBruker.Name = "GridBruker"
        Me.GridBruker.RowTemplate.Height = 33
        Me.GridBruker.Size = New System.Drawing.Size(757, 366)
        Me.GridBruker.TabIndex = 7
        '
        'chkBlod
        '
        Me.chkBlod.AutoSize = True
        Me.chkBlod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBlod.Location = New System.Drawing.Point(15, 428)
        Me.chkBlod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkBlod.Name = "chkBlod"
        Me.chkBlod.Size = New System.Drawing.Size(137, 28)
        Me.chkBlod.TabIndex = 8
        Me.chkBlod.Text = "400 ml blod"
        Me.chkBlod.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilbake.Location = New System.Drawing.Point(623, 488)
        Me.btnTilbake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(149, 62)
        Me.btnTilbake.TabIndex = 9
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'AnsattTapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.chkBlod)
        Me.Controls.Add(Me.GridBruker)
        Me.Controls.Add(Me.btnRegistrer)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.tbSok)
        Me.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AnsattTapping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnsattTapping"
        CType(Me.GridBruker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbSok As TextBox
    Friend WithEvents btnSok As Button
    Friend WithEvents btnRegistrer As Button
    Friend WithEvents GridBruker As DataGridView
    Friend WithEvents chkBlod As CheckBox
    Friend WithEvents btnTilbake As Button
End Class
