<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mottaBestillinger
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
        Me.motta_bestillinger_grid = New System.Windows.Forms.DataGridView()
        Me.Button_tilbake_fra_motta_bestillinger = New System.Windows.Forms.Button()
        CType(Me.motta_bestillinger_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'motta_bestillinger_grid
        '
        Me.motta_bestillinger_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.motta_bestillinger_grid.Location = New System.Drawing.Point(12, 12)
        Me.motta_bestillinger_grid.Name = "motta_bestillinger_grid"
        Me.motta_bestillinger_grid.RowTemplate.Height = 24
        Me.motta_bestillinger_grid.Size = New System.Drawing.Size(921, 557)
        Me.motta_bestillinger_grid.TabIndex = 0
        '
        'Button_tilbake_fra_motta_bestillinger
        '
        Me.Button_tilbake_fra_motta_bestillinger.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_tilbake_fra_motta_bestillinger.Location = New System.Drawing.Point(902, 685)
        Me.Button_tilbake_fra_motta_bestillinger.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_tilbake_fra_motta_bestillinger.Name = "Button_tilbake_fra_motta_bestillinger"
        Me.Button_tilbake_fra_motta_bestillinger.Size = New System.Drawing.Size(149, 44)
        Me.Button_tilbake_fra_motta_bestillinger.TabIndex = 4
        Me.Button_tilbake_fra_motta_bestillinger.Text = "Tilbake"
        Me.Button_tilbake_fra_motta_bestillinger.UseVisualStyleBackColor = True
        '
        'mottaBestillinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 742)
        Me.Controls.Add(Me.Button_tilbake_fra_motta_bestillinger)
        Me.Controls.Add(Me.motta_bestillinger_grid)
        Me.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "mottaBestillinger"
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        CType(Me.motta_bestillinger_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents motta_bestillinger_grid As DataGridView
    Friend WithEvents Button_tilbake_fra_motta_bestillinger As Button
End Class
