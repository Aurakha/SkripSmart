<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasilLvl1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        PanelHeader = New Panel()
        LabelHeader = New Label()
        lblIntro = New Label()
        lblNamaHasil = New Label()
        lblCF = New Label()
        txtPesan = New TextBox()
        Panel1 = New Panel()
        Label22 = New Label()
        Label12 = New Label()
        Label21 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        Panel2 = New Panel()
        PanelHeader.SuspendLayout()
        Panel1.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        PanelHeader.Controls.Add(LabelHeader)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Margin = New Padding(2)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1405, 55)
        PanelHeader.TabIndex = 0
        ' 
        ' LabelHeader
        ' 
        LabelHeader.AutoSize = True
        LabelHeader.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHeader.ForeColor = Color.White
        LabelHeader.Location = New Point(507, 9)
        LabelHeader.Margin = New Padding(2, 0, 2, 0)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(308, 34)
        LabelHeader.TabIndex = 0
        LabelHeader.Text = "HASIL ANALISIS AKHIR"
        ' 
        ' lblIntro
        ' 
        lblIntro.AutoSize = True
        lblIntro.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblIntro.ForeColor = Color.Gray
        lblIntro.Location = New Point(15, 10)
        lblIntro.Margin = New Padding(2, 0, 2, 0)
        lblIntro.Name = "lblIntro"
        lblIntro.Size = New Size(422, 21)
        lblIntro.TabIndex = 1
        lblIntro.Text = "Berdasarkan jawabanmu, kamu cocok masuk ke:"
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.BorderStyle = BorderStyle.Fixed3D
        lblNamaHasil.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaHasil.ForeColor = Color.Black
        lblNamaHasil.Location = New Point(13, 34)
        lblNamaHasil.Margin = New Padding(2, 0, 2, 0)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(392, 46)
        lblNamaHasil.TabIndex = 2
        lblNamaHasil.Text = "TEKNIK INFORMATIKA"
        ' 
        ' lblCF
        ' 
        lblCF.AutoSize = True
        lblCF.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCF.ForeColor = Color.OrangeRed
        lblCF.Location = New Point(15, 82)
        lblCF.Margin = New Padding(2, 0, 2, 0)
        lblCF.Name = "lblCF"
        lblCF.Size = New Size(229, 23)
        lblCF.TabIndex = 3
        lblCF.Text = "Tingkat Keyakinan: 0%"
        ' 
        ' txtPesan
        ' 
        txtPesan.BackColor = Color.White
        txtPesan.BorderStyle = BorderStyle.FixedSingle
        txtPesan.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPesan.Location = New Point(20, 122)
        txtPesan.Margin = New Padding(2)
        txtPesan.Multiline = True
        txtPesan.Name = "txtPesan"
        txtPesan.ReadOnly = True
        txtPesan.ScrollBars = ScrollBars.Vertical
        txtPesan.Size = New Size(486, 120)
        txtPesan.TabIndex = 4
        txtPesan.Text = "Deskripsi detail hasil analisis..."
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Chart1)
        Panel1.Location = New Point(560, 81)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(830, 515)
        Panel1.TabIndex = 20
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BorderStyle = BorderStyle.Fixed3D
        Label22.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Label22.ForeColor = Color.White
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
        Label12.ForeColor = Color.White
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
        Label21.ForeColor = Color.White
        Label21.Location = New Point(45, 23)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(430, 21)
        Label21.TabIndex = 24
        Label21.Text = "Topik paling di rekomendasikan: Machine Learning"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(597, 449)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 38)
        Button1.TabIndex = 22
        Button1.Text = "Simpan Riwayat"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(45, 451)
        Button2.Name = "Button2"
        Button2.Size = New Size(181, 36)
        Button2.TabIndex = 21
        Button2.Text = "Tutup Aplikasi"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Chart1
        ' 
        Chart1.BorderlineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea2.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Chart1.Legends.Add(Legend2)
        Chart1.Location = New Point(45, 130)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Chart1.Series.Add(Series2)
        Chart1.Size = New Size(744, 301)
        Chart1.TabIndex = 8
        Chart1.Text = "Chart1"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblIntro)
        Panel2.Controls.Add(lblNamaHasil)
        Panel2.Controls.Add(txtPesan)
        Panel2.Controls.Add(lblCF)
        Panel2.Location = New Point(12, 81)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(531, 271)
        Panel2.TabIndex = 21
        ' 
        ' FormHasilLvl1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1405, 611)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PanelHeader)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "FormHasilLvl1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hasil Analisis"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelHeader As Label
    Friend WithEvents lblIntro As Label
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblCF As Label
    Friend WithEvents txtPesan As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel2 As Panel
End Class