<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardNew))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Sidebar = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel1 = New Panel()
        Panel5 = New Panel()
        PictureBox5 = New PictureBox()
        Label11 = New Label()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Chart1 = New DataVisualization.Charting.Chart()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox3 = New GroupBox()
        Label6 = New Label()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        Label8 = New Label()
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
        GroupBox5 = New GroupBox()
        Label17 = New Label()
        GroupBox6 = New GroupBox()
        Label18 = New Label()
        Label19 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label12 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Timer1 = New Timer(components)
        Sidebar.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox10.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox9.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Sidebar
        ' 
        Sidebar.Controls.Add(PictureBox2)
        Sidebar.Controls.Add(PictureBox1)
        Sidebar.Dock = DockStyle.Top
        Sidebar.Location = New Point(0, 0)
        Sidebar.Margin = New Padding(4)
        Sidebar.Name = "Sidebar"
        Sidebar.Size = New Size(303, 114)
        Sidebar.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(104, 31)
        PictureBox2.Margin = New Padding(4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(195, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(4, 14)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 82)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 114)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(20, 941)
        Panel2.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(29, 80)
        Panel3.Margin = New Padding(4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(333, 143)
        Panel3.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(283, 114)
        Panel4.Margin = New Padding(4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(20, 941)
        Panel4.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(20, 114)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(263, 43)
        Button1.TabIndex = 4
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(20, 157)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(263, 43)
        Button2.TabIndex = 6
        Button2.Text = "Mulai Konsultasi"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Top
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(20, 200)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(263, 43)
        Button3.TabIndex = 7
        Button3.Text = "Riwayat Konsultasi"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Bottom
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(20, 1001)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(263, 54)
        Button4.TabIndex = 8
        Button4.Text = "Keluar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Sidebar)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(303, 1055)
        Panel1.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(PictureBox5)
        Panel5.Controls.Add(Label11)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(Label1)
        Panel5.Controls.Add(PictureBox3)
        Panel5.Location = New Point(307, 0)
        Panel5.Margin = New Padding(4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1550, 54)
        Panel5.TabIndex = 2
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(1379, 5)
        PictureBox5.Margin = New Padding(4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(35, 46)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 22
        PictureBox5.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        Label11.Location = New Point(1422, 15)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 21)
        Label11.TabIndex = 20
        Label11.Text = "Label Jam"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1608, 4)
        PictureBox4.Margin = New Padding(4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(37, 47)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1653, 15)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 18)
        Label3.TabIndex = 3
        Label3.Text = "Label Jam"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(276, 14)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 19)
        Label2.TabIndex = 2
        Label2.Text = "Role: User"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(84, 14)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 19)
        Label1.TabIndex = 1
        Label1.Text = "Halo, User"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(31, 0)
        PictureBox3.Margin = New Padding(4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 51)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        Label4.Location = New Point(-268, -164)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(716, 24)
        Label4.TabIndex = 8
        Label4.Text = """Temukan topik yang paling cocok dengan minat, kemampuan dan jurusanmu"""
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(371, 213)
        Chart1.Margin = New Padding(4)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(614, 365)
        Chart1.TabIndex = 13
        Chart1.Text = "Chart1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(372, 167)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(243, 21)
        Label5.TabIndex = 14
        Label5.Text = "Persentase Minat Pengguna:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(371, 663)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(614, 317)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Keunggulan"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(45, 167)
        GroupBox3.Margin = New Padding(4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4)
        GroupBox3.Size = New Size(515, 126)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "🔗 Forward Chaining Inference (Mesin Penalaran)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        Label6.Location = New Point(21, 45)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(441, 57)
        Label6.TabIndex = 1
        Label6.Text = "SkripSmart memakai metode forward chaining, yaitu proses menarik " & vbCrLf & "kesimpulan dari serangkaian fakta (jawaban pengguna) menuju " & vbCrLf & "rekomendasi topik paling cocok."
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(45, 51)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(515, 79)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "⚖️ Rules–Based System (Berbasis Aturan)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        Label7.Location = New Point(61, 37)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(380, 19)
        Label7.TabIndex = 1
        Label7.Text = "Setiap keputusan yang dihasilkan sistem " & ChrW(8220) & "dapat dijelaskan" & ChrW(8221) & "."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Label8.Location = New Point(96, 24)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 23)
        Label8.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(GroupBox10)
        GroupBox4.Controls.Add(GroupBox7)
        GroupBox4.Controls.Add(GroupBox9)
        GroupBox4.Controls.Add(GroupBox5)
        GroupBox4.Controls.Add(GroupBox6)
        GroupBox4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(1020, 554)
        GroupBox4.Margin = New Padding(5)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(5)
        GroupBox4.Size = New Size(819, 487)
        GroupBox4.TabIndex = 16
        GroupBox4.TabStop = False
        GroupBox4.Text = "Panduan Singkat"
        ' 
        ' GroupBox10
        ' 
        GroupBox10.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        GroupBox10.Controls.Add(Label15)
        GroupBox10.Controls.Add(Label16)
        GroupBox10.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox10.ForeColor = Color.White
        GroupBox10.Location = New Point(513, 301)
        GroupBox10.Margin = New Padding(4)
        GroupBox10.Name = "GroupBox10"
        GroupBox10.Padding = New Padding(4)
        GroupBox10.Size = New Size(282, 97)
        GroupBox10.TabIndex = 13
        GroupBox10.TabStop = False
        GroupBox10.Text = "STEP 6 — Menampilkan Hasil"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        Label15.Location = New Point(8, 38)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(221, 38)
        Label15.TabIndex = 1
        Label15.Text = "Setiap keputusan yang dihasilkan " & vbCrLf & "sistem " & ChrW(8220) & "dapat dijelaskan" & ChrW(8221) & "."
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Label16.Location = New Point(96, 24)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 23)
        Label16.TabIndex = 0
        ' 
        ' GroupBox7
        ' 
        GroupBox7.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        GroupBox7.Controls.Add(Label9)
        GroupBox7.Controls.Add(Label10)
        GroupBox7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox7.ForeColor = Color.White
        GroupBox7.Location = New Point(89, 364)
        GroupBox7.Margin = New Padding(4)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Padding = New Padding(4)
        GroupBox7.Size = New Size(301, 114)
        GroupBox7.TabIndex = 10
        GroupBox7.TabStop = False
        GroupBox7.Text = "STEP 3 — Pertanyaan LEVEL 2 (Per Prodi)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        Label9.Location = New Point(8, 59)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(248, 38)
        Label9.TabIndex = 1
        Label9.Text = "Hasilnya digunakan untuk " & vbCrLf & "sistem dalam memilij judul yang tepat"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Label10.Location = New Point(96, 24)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 23)
        Label10.TabIndex = 0
        ' 
        ' GroupBox9
        ' 
        GroupBox9.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        GroupBox9.Controls.Add(Label13)
        GroupBox9.Controls.Add(Label14)
        GroupBox9.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox9.ForeColor = Color.White
        GroupBox9.Location = New Point(513, 129)
        GroupBox9.Margin = New Padding(4)
        GroupBox9.Name = "GroupBox9"
        GroupBox9.Padding = New Padding(4)
        GroupBox9.Size = New Size(282, 116)
        GroupBox9.TabIndex = 12
        GroupBox9.TabStop = False
        GroupBox9.Text = "STEP 5 — Sistem Memilih Judul Skripsi"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        Label13.Location = New Point(8, 58)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(266, 38)
        Label13.TabIndex = 1
        Label13.Text = "Sistem melakukan forward chaining " & vbCrLf & "untuk memilih judul skripsi yang relevan."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Label14.Location = New Point(96, 24)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 23)
        Label14.TabIndex = 0
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        GroupBox5.Controls.Add(Label17)
        GroupBox5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.ForeColor = Color.White
        GroupBox5.Location = New Point(89, 202)
        GroupBox5.Margin = New Padding(4)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(4)
        GroupBox5.Size = New Size(301, 116)
        GroupBox5.TabIndex = 9
        GroupBox5.TabStop = False
        GroupBox5.Text = "STEP 2 — Pertanyaan LEVEL 1 (General)"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        Label17.Location = New Point(8, 60)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(210, 38)
        Label17.TabIndex = 1
        Label17.Text = "Output Level 1 mengarahkan ke " & vbCrLf & "list pertanyaan level 2"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        GroupBox6.Controls.Add(Label18)
        GroupBox6.Controls.Add(Label19)
        GroupBox6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox6.ForeColor = Color.White
        GroupBox6.Location = New Point(89, 63)
        GroupBox6.Margin = New Padding(4)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(4)
        GroupBox6.Size = New Size(301, 92)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "STEP 1 — Input Identitas"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        Label18.Location = New Point(8, 37)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(237, 38)
        Label18.TabIndex = 1
        Label18.Text = "Sistem menyimpan identitas dan " & vbCrLf & "masuk ke tahap pertanyaan pertama."
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Label19.Location = New Point(96, 24)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(0, 23)
        Label19.TabIndex = 0
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BorderStyle = BorderStyle.Fixed3D
        Label21.Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        Label21.Location = New Point(1109, 350)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(430, 21)
        Label21.TabIndex = 19
        Label21.Text = "Topik paling di rekomendasikan: Machine Learning"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BorderStyle = BorderStyle.Fixed3D
        Label20.Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        Label20.Location = New Point(1109, 316)
        Label20.Margin = New Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(186, 21)
        Label20.TabIndex = 18
        Label20.Text = "Konsultasi bulan ini: 5"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        Label12.Location = New Point(1109, 388)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(130, 21)
        Label12.TabIndex = 20
        Label12.Text = "Backend: 20%"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.BorderStyle = BorderStyle.Fixed3D
        Label22.Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        Label22.Location = New Point(1109, 419)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(126, 21)
        Label22.TabIndex = 21
        Label22.Text = "Frontend: 30%"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.BackColor = SystemColors.Control
        Label23.BorderStyle = BorderStyle.Fixed3D
        Label23.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label23.ForeColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        Label23.Location = New Point(762, 100)
        Label23.Margin = New Padding(4, 0, 4, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(739, 30)
        Label23.TabIndex = 22
        Label23.Text = """Temukan topik yang paling cocok dengan minat, kemampuan dan jurusanmu"""
        ' 
        ' DashboardNew
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1860, 1055)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label12)
        Controls.Add(Label21)
        Controls.Add(Panel5)
        Controls.Add(Label20)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox1)
        Controls.Add(Label5)
        Controls.Add(Chart1)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "DashboardNew"
        Text = "DashboardNew"
        Sidebar.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
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
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Sidebar As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Timer1 As Timer
End Class
