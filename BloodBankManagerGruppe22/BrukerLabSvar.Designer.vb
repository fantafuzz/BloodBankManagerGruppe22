<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BrukerLabSvar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrukerLabSvar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_tilbake_fra_lab_svar = New System.Windows.Forms.Button()
        Me.GridSvar = New System.Windows.Forms.DataGridView()
        CType(Me.GridSvar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Labratorie Prøve Resultater"
        '
        'Button_tilbake_fra_lab_svar
        '
        Me.Button_tilbake_fra_lab_svar.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_tilbake_fra_lab_svar.Location = New System.Drawing.Point(673, 507)
        Me.Button_tilbake_fra_lab_svar.Name = "Button_tilbake_fra_lab_svar"
        Me.Button_tilbake_fra_lab_svar.Size = New System.Drawing.Size(99, 43)
        Me.Button_tilbake_fra_lab_svar.TabIndex = 2
        Me.Button_tilbake_fra_lab_svar.Text = "Tilbake"
        Me.Button_tilbake_fra_lab_svar.UseVisualStyleBackColor = True
        '
        'GridSvar
        '
        Me.GridSvar.AllowUserToAddRows = False
        Me.GridSvar.AllowUserToDeleteRows = False
        Me.GridSvar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSvar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridSvar.Location = New System.Drawing.Point(12, 43)
        Me.GridSvar.Name = "GridSvar"
        Me.GridSvar.Size = New System.Drawing.Size(760, 458)
        Me.GridSvar.TabIndex = 3
        '
        'BrukerLabSvar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GridSvar)
        Me.Controls.Add(Me.Button_tilbake_fra_lab_svar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BrukerLabSvar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        CType(Me.GridSvar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_tilbake_fra_lab_svar As Button
    Friend WithEvents GridSvar As DataGridView
End Class
