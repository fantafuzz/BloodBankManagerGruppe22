<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnsattBlodProdukter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnsattBlodProdukter))
        Me.Button_Tilbake_AnsattMinSide = New System.Windows.Forms.Button()
        Me.Button_Utlevere_Blodprodukter = New System.Windows.Forms.Button()
        Me.ListBox_Blodprodukter_Ansatte = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button_Tilbake_AnsattMinSide
        '
        Me.Button_Tilbake_AnsattMinSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Tilbake_AnsattMinSide.Location = New System.Drawing.Point(761, 550)
        Me.Button_Tilbake_AnsattMinSide.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_Tilbake_AnsattMinSide.Name = "Button_Tilbake_AnsattMinSide"
        Me.Button_Tilbake_AnsattMinSide.Size = New System.Drawing.Size(143, 43)
        Me.Button_Tilbake_AnsattMinSide.TabIndex = 40
        Me.Button_Tilbake_AnsattMinSide.Text = "Tilbake"
        Me.Button_Tilbake_AnsattMinSide.UseVisualStyleBackColor = True
        '
        'Button_Utlevere_Blodprodukter
        '
        Me.Button_Utlevere_Blodprodukter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Utlevere_Blodprodukter.Location = New System.Drawing.Point(10, 20)
        Me.Button_Utlevere_Blodprodukter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_Utlevere_Blodprodukter.Name = "Button_Utlevere_Blodprodukter"
        Me.Button_Utlevere_Blodprodukter.Size = New System.Drawing.Size(324, 38)
        Me.Button_Utlevere_Blodprodukter.TabIndex = 41
        Me.Button_Utlevere_Blodprodukter.Text = "Utlevere blodprodukter"
        Me.Button_Utlevere_Blodprodukter.UseVisualStyleBackColor = True
        '
        'ListBox_Blodprodukter_Ansatte
        '
        Me.ListBox_Blodprodukter_Ansatte.FormattingEnabled = True
        Me.ListBox_Blodprodukter_Ansatte.ItemHeight = 14
        Me.ListBox_Blodprodukter_Ansatte.Location = New System.Drawing.Point(10, 62)
        Me.ListBox_Blodprodukter_Ansatte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox_Blodprodukter_Ansatte.Name = "ListBox_Blodprodukter_Ansatte"
        Me.ListBox_Blodprodukter_Ansatte.Size = New System.Drawing.Size(325, 494)
        Me.ListBox_Blodprodukter_Ansatte.TabIndex = 42
        '
        'AnsattBlodProdukter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 604)
        Me.Controls.Add(Me.ListBox_Blodprodukter_Ansatte)
        Me.Controls.Add(Me.Button_Utlevere_Blodprodukter)
        Me.Controls.Add(Me.Button_Tilbake_AnsattMinSide)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnsattBlodProdukter"
        Me.Text = "AnsattBlodProdukter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Tilbake_AnsattMinSide As Button
    Friend WithEvents Button_Utlevere_Blodprodukter As Button
    Friend WithEvents ListBox_Blodprodukter_Ansatte As ListBox
End Class
