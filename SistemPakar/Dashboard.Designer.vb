<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        components = New ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Panel1 = New Panel()
        Label22 = New Label()
        MenuStrip1 = New MenuStrip()
        BerandaToolStripMenuItem = New ToolStripMenuItem()
        KonsultasiToolStripMenuItem = New ToolStripMenuItem()
        SemuaRiwayatToolStripMenuItem = New ToolStripMenuItem()
        HasilRekomendasiToolStripMenuItem = New ToolStripMenuItem()
        DetailKonsultasiToolStripMenuItem = New ToolStripMenuItem()
        RiwayatKonsultasiToolStripMenuItem = New ToolStripMenuItem()
        SemuaRiwayatToolStripMenuItem1 = New ToolStripMenuItem()
        HasilRekomendasiToolStripMenuItem1 = New ToolStripMenuItem()
        Label19 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        GroupBox3 = New GroupBox()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox4 = New GroupBox()
        GroupBox10 = New GroupBox()
        Label15 = New Label()
        Label16 = New Label()
        GroupBox7 = New GroupBox()
        Label9 = New Label()
        Label10 = New Label()
        GroupBox9 = New GroupBox()
        Label13 = New Label()
        Label14 = New Label()
        GroupBox8 = New GroupBox()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox5 = New GroupBox()
        Label6 = New Label()
        GroupBox6 = New GroupBox()
        Label7 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        Label17 = New Label()
        Label18 = New Label()
        Button1 = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        Label20 = New Label()
        Label21 = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox10.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox9.SuspendLayout()
        GroupBox8.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        Panel2.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Label19)
        Panel1.Location = New Point(712, 5)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(659, 77)
        Panel1.TabIndex = 1
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label22.Location = New Point(561, 45)
        Label22.Name = "Label22"
        Label22.Size = New Size(93, 25)
        Label22.TabIndex = 16
        Label22.Text = "Label Jam"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {BerandaToolStripMenuItem, KonsultasiToolStripMenuItem, RiwayatKonsultasiToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(659, 35)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BerandaToolStripMenuItem
        ' 
        BerandaToolStripMenuItem.Name = "BerandaToolStripMenuItem"
        BerandaToolStripMenuItem.Size = New Size(156, 29)
        BerandaToolStripMenuItem.Text = "📊 Dashboard  "
        ' 
        ' KonsultasiToolStripMenuItem
        ' 
        KonsultasiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SemuaRiwayatToolStripMenuItem, HasilRekomendasiToolStripMenuItem, DetailKonsultasiToolStripMenuItem})
        KonsultasiToolStripMenuItem.Name = "KonsultasiToolStripMenuItem"
        KonsultasiToolStripMenuItem.Size = New Size(138, 29)
        KonsultasiToolStripMenuItem.Text = ChrW(55358) & ChrW(56800) & " Konsultasi"
        ' 
        ' SemuaRiwayatToolStripMenuItem
        ' 
        SemuaRiwayatToolStripMenuItem.Name = "SemuaRiwayatToolStripMenuItem"
        SemuaRiwayatToolStripMenuItem.Size = New Size(168, 34)
        SemuaRiwayatToolStripMenuItem.Text = "Level 1"
        ' 
        ' HasilRekomendasiToolStripMenuItem
        ' 
        HasilRekomendasiToolStripMenuItem.Name = "HasilRekomendasiToolStripMenuItem"
        HasilRekomendasiToolStripMenuItem.Size = New Size(168, 34)
        HasilRekomendasiToolStripMenuItem.Text = "Level 2"
        ' 
        ' DetailKonsultasiToolStripMenuItem
        ' 
        DetailKonsultasiToolStripMenuItem.Name = "DetailKonsultasiToolStripMenuItem"
        DetailKonsultasiToolStripMenuItem.Size = New Size(168, 34)
        DetailKonsultasiToolStripMenuItem.Text = "Level 3"
        ' 
        ' RiwayatKonsultasiToolStripMenuItem
        ' 
        RiwayatKonsultasiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SemuaRiwayatToolStripMenuItem1, HasilRekomendasiToolStripMenuItem1})
        RiwayatKonsultasiToolStripMenuItem.Name = "RiwayatKonsultasiToolStripMenuItem"
        RiwayatKonsultasiToolStripMenuItem.Size = New Size(204, 29)
        RiwayatKonsultasiToolStripMenuItem.Text = "📝 Riwayat Konsultasi"
        ' 
        ' SemuaRiwayatToolStripMenuItem1
        ' 
        SemuaRiwayatToolStripMenuItem1.Name = "SemuaRiwayatToolStripMenuItem1"
        SemuaRiwayatToolStripMenuItem1.Size = New Size(293, 34)
        SemuaRiwayatToolStripMenuItem1.Text = "📅 Semua Riwayat"
        ' 
        ' HasilRekomendasiToolStripMenuItem1
        ' 
        HasilRekomendasiToolStripMenuItem1.Name = "HasilRekomendasiToolStripMenuItem1"
        HasilRekomendasiToolStripMenuItem1.Size = New Size(293, 34)
        HasilRekomendasiToolStripMenuItem1.Text = "🎯 Hasil Rekomendasi"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label19.Location = New Point(438, 45)
        Label19.Name = "Label19"
        Label19.Size = New Size(97, 25)
        Label19.TabIndex = 2
        Label19.Text = "Halo, User"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(506, 5)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 119)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(66, 196)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(1157, 186)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Keunggulan"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ActiveCaption
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Location = New Point(525, 45)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(600, 110)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "🔗 Forward Chaining Inference (Mesin Penalaran)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label5.Location = New Point(46, 44)
        Label5.Name = "Label5"
        Label5.Size = New Size(629, 42)
        Label5.TabIndex = 1
        Label5.Text = "SkripSmart memakai metode forward chaining, yaitu proses menarik kesimpulan dari " & vbCrLf & "serangkaian fakta (jawaban pengguna) menuju rekomendasi topik paling cocok."
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ActiveCaption
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(34, 45)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(473, 110)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "⚖️ Rules–Based System (Berbasis Aturan)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(42, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(505, 25)
        Label4.TabIndex = 1
        Label4.Text = "Setiap keputusan yang dihasilkan sistem " & ChrW(8220) & "dapat dijelaskan" & ChrW(8221) & "."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label3.Location = New Point(72, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 28)
        Label3.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLight
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold)
        Label2.Location = New Point(967, 124)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(208, 34)
        Label2.TabIndex = 6
        Label2.Text = "SKRIPSMART"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.Location = New Point(769, 155)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(667, 27)
        Label1.TabIndex = 7
        Label1.Text = """Temukan topik yang paling cocok dengan minat, kemampuan dan jurusanmu"""
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(GroupBox10)
        GroupBox4.Controls.Add(GroupBox7)
        GroupBox4.Controls.Add(GroupBox9)
        GroupBox4.Controls.Add(GroupBox8)
        GroupBox4.Controls.Add(GroupBox5)
        GroupBox4.Controls.Add(GroupBox6)
        GroupBox4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(66, 400)
        GroupBox4.Margin = New Padding(4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4)
        GroupBox4.Size = New Size(1125, 389)
        GroupBox4.TabIndex = 8
        GroupBox4.TabStop = False
        GroupBox4.Text = "Panduan Singkat"
        ' 
        ' GroupBox10
        ' 
        GroupBox10.BackColor = SystemColors.ActiveCaption
        GroupBox10.Controls.Add(Label15)
        GroupBox10.Controls.Add(Label16)
        GroupBox10.Location = New Point(764, 231)
        GroupBox10.Name = "GroupBox10"
        GroupBox10.Size = New Size(284, 118)
        GroupBox10.TabIndex = 13
        GroupBox10.TabStop = False
        GroupBox10.Text = "STEP 6 — Menampilkan Hasil"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label15.Location = New Point(6, 67)
        Label15.Name = "Label15"
        Label15.Size = New Size(253, 42)
        Label15.TabIndex = 1
        Label15.Text = "Setiap keputusan yang dihasilkan " & vbCrLf & "sistem " & ChrW(8220) & "dapat dijelaskan" & ChrW(8221) & "."
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label16.Location = New Point(72, 21)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 28)
        Label16.TabIndex = 0
        ' 
        ' GroupBox7
        ' 
        GroupBox7.BackColor = SystemColors.ActiveCaption
        GroupBox7.Controls.Add(Label9)
        GroupBox7.Controls.Add(Label10)
        GroupBox7.Location = New Point(764, 54)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(284, 110)
        GroupBox7.TabIndex = 10
        GroupBox7.TabStop = False
        GroupBox7.Text = "STEP 3 — Pertanyaan LEVEL 2 (Per Prodi)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label9.Location = New Point(6, 67)
        Label9.Name = "Label9"
        Label9.Size = New Size(237, 42)
        Label9.TabIndex = 1
        Label9.Text = "Hasilnya digunakan untuk " & vbCrLf & "memilih list pertanyaan Level 3."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label10.Location = New Point(72, 21)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 28)
        Label10.TabIndex = 0
        ' 
        ' GroupBox9
        ' 
        GroupBox9.BackColor = SystemColors.ActiveCaption
        GroupBox9.Controls.Add(Label13)
        GroupBox9.Controls.Add(Label14)
        GroupBox9.Location = New Point(409, 228)
        GroupBox9.Name = "GroupBox9"
        GroupBox9.Size = New Size(300, 121)
        GroupBox9.TabIndex = 12
        GroupBox9.TabStop = False
        GroupBox9.Text = "STEP 5 — Sistem Memilih Judul Skripsi"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label13.Location = New Point(6, 67)
        Label13.Name = "Label13"
        Label13.Size = New Size(303, 42)
        Label13.TabIndex = 1
        Label13.Text = "Sistem melakukan forward chaining " & vbCrLf & "untuk memilih judul skripsi yang relevan."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label14.Location = New Point(72, 21)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 28)
        Label14.TabIndex = 0
        ' 
        ' GroupBox8
        ' 
        GroupBox8.BackColor = SystemColors.ActiveCaption
        GroupBox8.Controls.Add(Label11)
        GroupBox8.Controls.Add(Label12)
        GroupBox8.Location = New Point(67, 228)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(284, 138)
        GroupBox8.TabIndex = 11
        GroupBox8.TabStop = False
        GroupBox8.Text = "STEP 4 — Pertanyaan LEVEL 3 (Per Bidang Spesifik)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label11.Location = New Point(6, 91)
        Label11.Name = "Label11"
        Label11.Size = New Size(261, 42)
        Label11.TabIndex = 1
        Label11.Text = "Output Level 3 untuk Menentukan " & vbCrLf & "SUB-BIDANG yang paling cocok."
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label12.Location = New Point(72, 21)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 28)
        Label12.TabIndex = 0
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = SystemColors.ActiveCaption
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Location = New Point(409, 54)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(300, 110)
        GroupBox5.TabIndex = 9
        GroupBox5.TabStop = False
        GroupBox5.Text = "STEP 2 — Pertanyaan LEVEL 1 (General)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label6.Location = New Point(6, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(241, 42)
        Label6.TabIndex = 1
        Label6.Text = "Output Level 1 mengarahkan ke " & vbCrLf & "list pertanyaan Prodi."
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = SystemColors.ActiveCaption
        GroupBox6.Controls.Add(Label7)
        GroupBox6.Controls.Add(Label8)
        GroupBox6.Location = New Point(67, 54)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(284, 110)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "STEP 1 — Input Identitas"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.Location = New Point(6, 44)
        Label7.Name = "Label7"
        Label7.Size = New Size(318, 50)
        Label7.TabIndex = 1
        Label7.Text = "Sistem menyimpan identitas dan " & vbCrLf & "masuk ke tahap pertanyaan pertama."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label8.Location = New Point(72, 21)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 28)
        Label8.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label17)
        Panel2.Location = New Point(-1, 991)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1929, 62)
        Panel2.TabIndex = 9
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(867, 15)
        Label17.Name = "Label17"
        Label17.Size = New Size(463, 32)
        Label17.TabIndex = 0
        Label17.Text = "© 2025 SKRIPSMART. All Rights Reserved"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label18.Location = New Point(902, 836)
        Label18.Name = "Label18"
        Label18.Size = New Size(366, 38)
        Label18.TabIndex = 10
        Label18.Text = "  " & ChrW(8220) & "Siap temukan topikmu?" & ChrW(8221) & " "
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Button1.Location = New Point(980, 888)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 40)
        Button1.TabIndex = 11
        Button1.Text = "Mulai Konsultasi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(1375, 358)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(469, 375)
        Chart1.TabIndex = 12
        Chart1.Text = "Chart1"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BorderStyle = BorderStyle.Fixed3D
        Label20.Location = New Point(1375, 241)
        Label20.Name = "Label20"
        Label20.Size = New Size(254, 34)
        Label20.TabIndex = 14
        Label20.Text = "Konsultasi bulan ini: 5"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BorderStyle = BorderStyle.Fixed3D
        Label21.Location = New Point(1375, 285)
        Label21.Name = "Label21"
        Label21.Size = New Size(570, 34)
        Label21.TabIndex = 15
        Label21.Text = "Topik paling di rekomendasikan: Machine Learning"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Chart1)
        Controls.Add(Button1)
        Controls.Add(Label18)
        Controls.Add(Panel2)
        Controls.Add(GroupBox4)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox10.ResumeLayout(False)
        GroupBox10.PerformLayout()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        GroupBox9.ResumeLayout(False)
        GroupBox9.PerformLayout()
        GroupBox8.ResumeLayout(False)
        GroupBox8.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BerandaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonsultasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemuaRiwayatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasilRekomendasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailKonsultasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents RiwayatKonsultasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemuaRiwayatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HasilRekomendasiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Timer1 As Timer
End Class
