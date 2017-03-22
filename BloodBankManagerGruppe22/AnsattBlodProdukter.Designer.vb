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
        Me.Button_Tilbake_AnsattMinSide = New System.Windows.Forms.Button()
        Me.Button_Utlevere_Blodprodukter = New System.Windows.Forms.Button()
        Me.ListBox_Blodprodukter_Ansatte = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button_Tilbake_AnsattMinSide
        '
        Me.Button_Tilbake_AnsattMinSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Tilbake_AnsattMinSide.Location = New System.Drawing.Point(869, 629)
        Me.Button_Tilbake_AnsattMinSide.Name = "Button_Tilbake_AnsattMinSide"
        Me.Button_Tilbake_AnsattMinSide.Size = New System.Drawing.Size(164, 49)
        Me.Button_Tilbake_AnsattMinSide.TabIndex = 40
        Me.Button_Tilbake_AnsattMinSide.Text = "Tilbake"
        Me.Button_Tilbake_AnsattMinSide.UseVisualStyleBackColor = True
        '
        'Button_Utlevere_Blodprodukter
        '
        Me.Button_Utlevere_Blodprodukter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Utlevere_Blodprodukter.Location = New System.Drawing.Point(12, 23)
        Me.Button_Utlevere_Blodprodukter.Name = "Button_Utlevere_Blodprodukter"
        Me.Button_Utlevere_Blodprodukter.Size = New System.Drawing.Size(371, 43)
        Me.Button_Utlevere_Blodprodukter.TabIndex = 41
        Me.Button_Utlevere_Blodprodukter.Text = "Utlevere blodprodukter"
        Me.Button_Utlevere_Blodprodukter.UseVisualStyleBackColor = True
        '
        'ListBox_Blodprodukter_Ansatte
        '
        Me.ListBox_Blodprodukter_Ansatte.FormattingEnabled = True
        Me.ListBox_Blodprodukter_Ansatte.ItemHeight = 16
        Me.ListBox_Blodprodukter_Ansatte.Location = New System.Drawing.Point(12, 72)
        Me.ListBox_Blodprodukter_Ansatte.Name = "ListBox_Blodprodukter_Ansatte"
        Me.ListBox_Blodprodukter_Ansatte.Size = New System.Drawing.Size(371, 564)
        Me.ListBox_Blodprodukter_Ansatte.TabIndex = 42
        '
        'AnsattBlodProdukter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 690)
        Me.Controls.Add(Me.ListBox_Blodprodukter_Ansatte)
        Me.Controls.Add(Me.Button_Utlevere_Blodprodukter)
        Me.Controls.Add(Me.Button_Tilbake_AnsattMinSide)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AnsattBlodProdukter"
        Me.Text = "AnsattBlodProdukter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Tilbake_AnsattMinSide As Button
    Friend WithEvents Button_Utlevere_Blodprodukter As Button
    Friend WithEvents ListBox_Blodprodukter_Ansatte As ListBox
End Class
