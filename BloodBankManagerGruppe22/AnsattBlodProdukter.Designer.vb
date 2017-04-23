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
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUtlever = New System.Windows.Forms.Button()
        Me.dataGridProdukt = New System.Windows.Forms.DataGridView()
        Me.tbUtlever = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.pnlLager = New System.Windows.Forms.Panel()
        Me.pnlUtlever = New System.Windows.Forms.Panel()
        Me.pnlMottak = New System.Windows.Forms.Panel()
        Me.btnMottak = New System.Windows.Forms.Button()
        Me.tbMottak = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTilMottak = New System.Windows.Forms.Button()
        Me.btnTilUtlevering = New System.Windows.Forms.Button()
        Me.btnTilbakeSame = New System.Windows.Forms.Button()
        Me.pnlNav = New System.Windows.Forms.Panel()
        CType(Me.dataGridProdukt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLager.SuspendLayout()
        Me.pnlUtlever.SuspendLayout()
        Me.pnlMottak.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilbake.Location = New System.Drawing.Point(612, 493)
        Me.btnTilbake.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(167, 63)
        Me.btnTilbake.TabIndex = 40
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 18)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Lager av blodprodukter"
        '
        'btnUtlever
        '
        Me.btnUtlever.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtlever.Location = New System.Drawing.Point(2, 63)
        Me.btnUtlever.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUtlever.Name = "btnUtlever"
        Me.btnUtlever.Size = New System.Drawing.Size(260, 60)
        Me.btnUtlever.TabIndex = 44
        Me.btnUtlever.Text = "Utlever"
        Me.btnUtlever.UseVisualStyleBackColor = True
        '
        'dataGridProdukt
        '
        Me.dataGridProdukt.AllowUserToAddRows = False
        Me.dataGridProdukt.AllowUserToDeleteRows = False
        Me.dataGridProdukt.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dataGridProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridProdukt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataGridProdukt.Location = New System.Drawing.Point(6, 23)
        Me.dataGridProdukt.Name = "dataGridProdukt"
        Me.dataGridProdukt.Size = New System.Drawing.Size(761, 383)
        Me.dataGridProdukt.TabIndex = 46
        '
        'tbUtlever
        '
        Me.tbUtlever.Location = New System.Drawing.Point(2, 24)
        Me.tbUtlever.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUtlever.Multiline = True
        Me.tbUtlever.Name = "tbUtlever"
        Me.tbUtlever.Size = New System.Drawing.Size(260, 35)
        Me.tbUtlever.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Hvor mange Ml hvil du utlevere"
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(271, 35)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(75, 34)
        Me.btnMax.TabIndex = 51
        Me.btnMax.Text = "Max"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'pnlLager
        '
        Me.pnlLager.Controls.Add(Me.dataGridProdukt)
        Me.pnlLager.Controls.Add(Me.Label1)
        Me.pnlLager.Location = New System.Drawing.Point(12, 12)
        Me.pnlLager.Name = "pnlLager"
        Me.pnlLager.Size = New System.Drawing.Size(767, 415)
        Me.pnlLager.TabIndex = 52
        '
        'pnlUtlever
        '
        Me.pnlUtlever.Controls.Add(Me.Label2)
        Me.pnlUtlever.Controls.Add(Me.tbUtlever)
        Me.pnlUtlever.Controls.Add(Me.btnMax)
        Me.pnlUtlever.Controls.Add(Me.btnUtlever)
        Me.pnlUtlever.Location = New System.Drawing.Point(18, 433)
        Me.pnlUtlever.Name = "pnlUtlever"
        Me.pnlUtlever.Size = New System.Drawing.Size(357, 133)
        Me.pnlUtlever.TabIndex = 53
        '
        'pnlMottak
        '
        Me.pnlMottak.Controls.Add(Me.btnMottak)
        Me.pnlMottak.Controls.Add(Me.tbMottak)
        Me.pnlMottak.Controls.Add(Me.Label3)
        Me.pnlMottak.Location = New System.Drawing.Point(18, 433)
        Me.pnlMottak.Name = "pnlMottak"
        Me.pnlMottak.Size = New System.Drawing.Size(397, 133)
        Me.pnlMottak.TabIndex = 54
        '
        'btnMottak
        '
        Me.btnMottak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMottak.Location = New System.Drawing.Point(6, 63)
        Me.btnMottak.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMottak.Name = "btnMottak"
        Me.btnMottak.Size = New System.Drawing.Size(260, 60)
        Me.btnMottak.TabIndex = 52
        Me.btnMottak.Text = "Registrer mottak"
        Me.btnMottak.UseVisualStyleBackColor = True
        '
        'tbMottak
        '
        Me.tbMottak.Location = New System.Drawing.Point(6, 24)
        Me.tbMottak.Margin = New System.Windows.Forms.Padding(2)
        Me.tbMottak.Multiline = True
        Me.tbMottak.Name = "tbMottak"
        Me.tbMottak.Size = New System.Drawing.Size(260, 35)
        Me.tbMottak.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 18)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Hvor mange Ml har kommet inn"
        '
        'btnTilMottak
        '
        Me.btnTilMottak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilMottak.Location = New System.Drawing.Point(2, 2)
        Me.btnTilMottak.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTilMottak.Name = "btnTilMottak"
        Me.btnTilMottak.Size = New System.Drawing.Size(167, 63)
        Me.btnTilMottak.TabIndex = 55
        Me.btnTilMottak.Text = "Registrer mottak"
        Me.btnTilMottak.UseVisualStyleBackColor = True
        '
        'btnTilUtlevering
        '
        Me.btnTilUtlevering.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilUtlevering.Location = New System.Drawing.Point(2, 69)
        Me.btnTilUtlevering.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTilUtlevering.Name = "btnTilUtlevering"
        Me.btnTilUtlevering.Size = New System.Drawing.Size(167, 63)
        Me.btnTilUtlevering.TabIndex = 56
        Me.btnTilUtlevering.Text = "Registrer utlevering"
        Me.btnTilUtlevering.UseVisualStyleBackColor = True
        '
        'btnTilbakeSame
        '
        Me.btnTilbakeSame.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilbakeSame.Location = New System.Drawing.Point(612, 493)
        Me.btnTilbakeSame.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTilbakeSame.Name = "btnTilbakeSame"
        Me.btnTilbakeSame.Size = New System.Drawing.Size(167, 63)
        Me.btnTilbakeSame.TabIndex = 57
        Me.btnTilbakeSame.Text = "Tilbake"
        Me.btnTilbakeSame.UseVisualStyleBackColor = True
        '
        'pnlNav
        '
        Me.pnlNav.Controls.Add(Me.btnTilMottak)
        Me.pnlNav.Controls.Add(Me.btnTilUtlevering)
        Me.pnlNav.Location = New System.Drawing.Point(252, 124)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(177, 144)
        Me.pnlNav.TabIndex = 58
        '
        'AnsattBlodProdukter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.btnTilbakeSame)
        Me.Controls.Add(Me.pnlUtlever)
        Me.Controls.Add(Me.pnlMottak)
        Me.Controls.Add(Me.pnlLager)
        Me.Controls.Add(Me.btnTilbake)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "AnsattBlodProdukter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        CType(Me.dataGridProdukt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLager.ResumeLayout(False)
        Me.pnlLager.PerformLayout()
        Me.pnlUtlever.ResumeLayout(False)
        Me.pnlUtlever.PerformLayout()
        Me.pnlMottak.ResumeLayout(False)
        Me.pnlMottak.PerformLayout()
        Me.pnlNav.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTilbake As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUtlever As Button
    Friend WithEvents dataGridProdukt As DataGridView
    Friend WithEvents tbUtlever As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMax As Button
    Friend WithEvents pnlLager As Panel
    Friend WithEvents pnlUtlever As Panel
    Friend WithEvents pnlMottak As Panel
    Friend WithEvents tbMottak As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMottak As Button
    Friend WithEvents btnTilMottak As Button
    Friend WithEvents btnTilUtlevering As Button
    Friend WithEvents btnTilbakeSame As Button
    Friend WithEvents pnlNav As Panel
End Class
