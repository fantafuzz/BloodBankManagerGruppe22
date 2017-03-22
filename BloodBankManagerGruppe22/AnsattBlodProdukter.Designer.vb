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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_utlevering_av_blodprodukter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonSok = New System.Windows.Forms.Button()
        Me.TextBoxSok = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Tilbake_AnsattMinSide
        '
        Me.Button_Tilbake_AnsattMinSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Tilbake_AnsattMinSide.Location = New System.Drawing.Point(761, 550)
        Me.Button_Tilbake_AnsattMinSide.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Tilbake_AnsattMinSide.Name = "Button_Tilbake_AnsattMinSide"
        Me.Button_Tilbake_AnsattMinSide.Size = New System.Drawing.Size(143, 43)
        Me.Button_Tilbake_AnsattMinSide.TabIndex = 40
        Me.Button_Tilbake_AnsattMinSide.Text = "Tilbake"
        Me.Button_Tilbake_AnsattMinSide.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 18)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Lager av blodprodukter"
        '
        'Button_utlevering_av_blodprodukter
        '
        Me.Button_utlevering_av_blodprodukter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_utlevering_av_blodprodukter.Location = New System.Drawing.Point(11, 505)
        Me.Button_utlevering_av_blodprodukter.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_utlevering_av_blodprodukter.Name = "Button_utlevering_av_blodprodukter"
        Me.Button_utlevering_av_blodprodukter.Size = New System.Drawing.Size(212, 37)
        Me.Button_utlevering_av_blodprodukter.TabIndex = 44
        Me.Button_utlevering_av_blodprodukter.Text = "Utlevere blodprodukter"
        Me.Button_utlevering_av_blodprodukter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(563, 399)
        Me.DataGridView1.TabIndex = 46
        '
        'ButtonSok
        '
        Me.ButtonSok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSok.Location = New System.Drawing.Point(487, 60)
        Me.ButtonSok.Name = "ButtonSok"
        Me.ButtonSok.Size = New System.Drawing.Size(87, 35)
        Me.ButtonSok.TabIndex = 47
        Me.ButtonSok.Text = "Søk"
        Me.ButtonSok.UseVisualStyleBackColor = True
        '
        'TextBoxSok
        '
        Me.TextBoxSok.Location = New System.Drawing.Point(11, 61)
        Me.TextBoxSok.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSok.Multiline = True
        Me.TextBoxSok.Name = "TextBoxSok"
        Me.TextBoxSok.Size = New System.Drawing.Size(459, 35)
        Me.TextBoxSok.TabIndex = 48
        '
        'AnsattBlodProdukter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 604)
        Me.Controls.Add(Me.TextBoxSok)
        Me.Controls.Add(Me.ButtonSok)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_utlevering_av_blodprodukter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Tilbake_AnsattMinSide)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnsattBlodProdukter"
        Me.Text = "AnsattBlodProdukter"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Tilbake_AnsattMinSide As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_utlevering_av_blodprodukter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonSok As Button
    Friend WithEvents TextBoxSok As TextBox
End Class
