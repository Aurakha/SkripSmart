<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasilLvl2
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Chart1 = New DataVisualization.Charting.Chart()
        PanelHeader = New Panel()
        LabelHeader = New Label()
        Panel1 = New Panel()
        btnTutup = New Button()
        btnLanjut = New Button()
        Label22 = New Label()
        Label12 = New Label()
        Label21 = New Label()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        PanelHeader.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Chart1
        ' 
        Chart1.BorderlineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea4.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Chart1.Legends.Add(Legend4)
        Chart1.Location = New Point(45, 130)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Chart1.Series.Add(Series4)
        Chart1.Size = New Size(744, 301)
        Chart1.TabIndex = 8
        Chart1.Text = "Chart1"
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        PanelHeader.Controls.Add(LabelHeader)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Margin = New Padding(2)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(976, 55)
        PanelHeader.TabIndex = 9
        ' 
        ' LabelHeader
        ' 
        LabelHeader.AutoSize = True
        LabelHeader.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHeader.ForeColor = Color.White
        LabelHeader.Location = New Point(339, 9)
        LabelHeader.Margin = New Padding(2, 0, 2, 0)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(308, 34)
        LabelHeader.TabIndex = 0
        LabelHeader.Text = "HASIL ANALISIS AKHIR"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(btnLanjut)
        Panel1.Controls.Add(btnTutup)
        Panel1.Controls.Add(Chart1)
        Panel1.Location = New Point(73, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(822, 510)
        Panel1.TabIndex = 0
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnTutup.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(45, 451)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(181, 36)
        btnTutup.TabIndex = 21
        btnTutup.Text = "Tutup Aplikasi"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' btnLanjut
        ' 
        btnLanjut.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        btnLanjut.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLanjut.ForeColor = Color.White
        btnLanjut.Location = New Point(597, 449)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(191, 38)
        btnLanjut.TabIndex = 22
        btnLanjut.Text = "Simpan Riwayat"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BorderStyle = BorderStyle.Fixed3D
        Label22.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Label22.Location = New Point(45, 83)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(126, 21)
        Label22.TabIndex = 26
        Label22.Text = "Frontend: 30%"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Label12.Location = New Point(45, 53)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(130, 21)
        Label12.TabIndex = 25
        Label12.Text = "Backend: 20%"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BorderStyle = BorderStyle.Fixed3D
        Label21.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Label21.Location = New Point(45, 23)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(430, 21)
        Label21.TabIndex = 24
        Label21.Text = "Topik paling di rekomendasikan: Machine Learning"
        ' 
        ' FormHasilLvl2
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(976, 619)
        Controls.Add(Panel1)
        Controls.Add(PanelHeader)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ForeColor = Color.White
        Name = "FormHasilLvl2"
        Text = "FormHasilLvl2"
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnLanjut As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
End Class
