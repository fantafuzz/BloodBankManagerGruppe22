<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnsattStatistikkNy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnsattStatistikkNy))
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.btnTapStat = New System.Windows.Forms.Button()
        Me.btnGiverStat = New System.Windows.Forms.Button()
        Me.gridStat = New System.Windows.Forms.DataGridView()
        Me.lblHjelp = New System.Windows.Forms.Label()
        CType(Me.gridStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilbake.Location = New System.Drawing.Point(653, 515)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(119, 35)
        Me.btnTilbake.TabIndex = 3
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'btnTapStat
        '
        Me.btnTapStat.Location = New System.Drawing.Point(12, 12)
        Me.btnTapStat.Name = "btnTapStat"
        Me.btnTapStat.Size = New System.Drawing.Size(137, 30)
        Me.btnTapStat.TabIndex = 4
        Me.btnTapStat.Text = "Antall Tappinger"
        Me.btnTapStat.UseVisualStyleBackColor = True
        '
        'btnGiverStat
        '
        Me.btnGiverStat.Location = New System.Drawing.Point(184, 12)
        Me.btnGiverStat.Name = "btnGiverStat"
        Me.btnGiverStat.Size = New System.Drawing.Size(174, 30)
        Me.btnGiverStat.TabIndex = 5
        Me.btnGiverStat.Text = "Tappinger per blodgiver"
        Me.btnGiverStat.UseVisualStyleBackColor = True
        '
        'gridStat
        '
        Me.gridStat.AllowUserToAddRows = False
        Me.gridStat.AllowUserToDeleteRows = False
        Me.gridStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridStat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gridStat.Location = New System.Drawing.Point(12, 48)
        Me.gridStat.Name = "gridStat"
        Me.gridStat.Size = New System.Drawing.Size(760, 461)
        Me.gridStat.TabIndex = 6
        '
        'lblHjelp
        '
        Me.lblHjelp.Location = New System.Drawing.Point(12, 48)
        Me.lblHjelp.Name = "lblHjelp"
        Me.lblHjelp.Size = New System.Drawing.Size(346, 59)
        Me.lblHjelp.TabIndex = 7
        Me.lblHjelp.Text = "Bruk knappene over for å vise statistikk over antall tappinger som er gjort per d" &
    "ato, eller antall tappinger hver bruker har gjort."
        '
        'AnsattStatistikkNy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.lblHjelp)
        Me.Controls.Add(Me.gridStat)
        Me.Controls.Add(Me.btnGiverStat)
        Me.Controls.Add(Me.btnTapStat)
        Me.Controls.Add(Me.btnTilbake)
        Me.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AnsattStatistikkNy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        CType(Me.gridStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTilbake As Button
    Friend WithEvents btnTapStat As Button
    Friend WithEvents btnGiverStat As Button
    Friend WithEvents gridStat As DataGridView
    Friend WithEvents lblHjelp As Label
End Class
