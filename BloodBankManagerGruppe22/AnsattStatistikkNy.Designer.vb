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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnsattStatistikkNy))
        Me.Button_tilbake_fra_lab_svar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chartStat = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_tilbake_fra_lab_svar
        '
        Me.Button_tilbake_fra_lab_svar.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_tilbake_fra_lab_svar.Location = New System.Drawing.Point(938, 523)
        Me.Button_tilbake_fra_lab_svar.Name = "Button_tilbake_fra_lab_svar"
        Me.Button_tilbake_fra_lab_svar.Size = New System.Drawing.Size(119, 35)
        Me.Button_tilbake_fra_lab_svar.TabIndex = 3
        Me.Button_tilbake_fra_lab_svar.Text = "Tilbake"
        Me.Button_tilbake_fra_lab_svar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Statistikk over antall blodgivere som har gitt blod de siste årene"
        '
        'chartStat
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartStat.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartStat.Legends.Add(Legend1)
        Me.chartStat.Location = New System.Drawing.Point(20, 50)
        Me.chartStat.Name = "chartStat"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartStat.Series.Add(Series1)
        Me.chartStat.Size = New System.Drawing.Size(740, 374)
        Me.chartStat.TabIndex = 6
        Me.chartStat.Text = "Chart1"
        '
        'AnsattStatistikkNy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1069, 570)
        Me.Controls.Add(Me.chartStat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_tilbake_fra_lab_svar)
        Me.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AnsattStatistikkNy"
        Me.Text = "Blood Bank Administrator 2k17™ - xTreme Edition"
        CType(Me.chartStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_tilbake_fra_lab_svar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chartStat As DataVisualization.Charting.Chart
End Class
