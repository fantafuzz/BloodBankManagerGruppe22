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
        Me.TextBox_mengde_blod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Tilbake_AnsattMinSide
        '
        Me.Button_Tilbake_AnsattMinSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Tilbake_AnsattMinSide.Location = New System.Drawing.Point(735, 552)
        Me.Button_Tilbake_AnsattMinSide.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Tilbake_AnsattMinSide.Name = "Button_Tilbake_AnsattMinSide"
        Me.Button_Tilbake_AnsattMinSide.Size = New System.Drawing.Size(167, 63)
        Me.Button_Tilbake_AnsattMinSide.TabIndex = 40
        Me.Button_Tilbake_AnsattMinSide.Text = "Tilbake"
        Me.Button_Tilbake_AnsattMinSide.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 18)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Lager av blodprodukter"
        '
        'Button_utlevering_av_blodprodukter
        '
        Me.Button_utlevering_av_blodprodukter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_utlevering_av_blodprodukter.Location = New System.Drawing.Point(16, 519)
        Me.Button_utlevering_av_blodprodukter.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_utlevering_av_blodprodukter.Name = "Button_utlevering_av_blodprodukter"
        Me.Button_utlevering_av_blodprodukter.Size = New System.Drawing.Size(260, 60)
        Me.Button_utlevering_av_blodprodukter.TabIndex = 44
        Me.Button_utlevering_av_blodprodukter.Text = "Utlever"
        Me.Button_utlevering_av_blodprodukter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(891, 383)
        Me.DataGridView1.TabIndex = 46
        '
        'TextBox_mengde_blod
        '
        Me.TextBox_mengde_blod.Location = New System.Drawing.Point(16, 469)
        Me.TextBox_mengde_blod.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_mengde_blod.Multiline = True
        Me.TextBox_mengde_blod.Name = "TextBox_mengde_blod"
        Me.TextBox_mengde_blod.Size = New System.Drawing.Size(260, 35)
        Me.TextBox_mengde_blod.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Hvor mye blod vil du ha?"
        '
        'AnsattBlodProdukter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(931, 626)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_mengde_blod)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_utlevering_av_blodprodukter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Tilbake_AnsattMinSide)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "AnsattBlodProdukter"
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Tilbake_AnsattMinSide As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_utlevering_av_blodprodukter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox_mengde_blod As TextBox
    Friend WithEvents Label2 As Label
End Class
