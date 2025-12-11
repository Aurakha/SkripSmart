<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKonsulTI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKonsulTI))
        Timer1 = New Timer(components)
        Panel5 = New Panel()
        PictureBox5 = New PictureBox()
        Label11 = New Label()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        PanelQuestion = New Panel()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label7 = New Label()
        Button4 = New Button()
        Sidebar = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        Label8 = New Label()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        PanelQuestion.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        Sidebar.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(PictureBox5)
        Panel5.Controls.Add(Label11)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(PictureBox3)
        Panel5.Controls.Add(Label1)
        Panel5.Location = New Point(246, 0)
        Panel5.Margin = New Padding(4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(667, 48)
        Panel5.TabIndex = 38
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(496, 11)
        PictureBox5.Margin = New Padding(4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(36, 28)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 22
        PictureBox5.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label11.Location = New Point(540, 15)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(84, 18)
        Label11.TabIndex = 20
        Label11.Text = "Label Jam"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1809, 4)
        PictureBox4.Margin = New Padding(4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(42, 42)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1860, 14)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 18)
        Label5.TabIndex = 3
        Label5.Text = "Label Jam"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(29, 11)
        PictureBox3.Margin = New Padding(4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(32, 28)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(69, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 18)
        Label1.TabIndex = 0
        Label1.Text = "Halo, User"
        ' 
        ' PanelQuestion
        ' 
        PanelQuestion.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        PanelQuestion.Controls.Add(Label6)
        PanelQuestion.Location = New Point(296, 106)
        PanelQuestion.Name = "PanelQuestion"
        PanelQuestion.Size = New Size(574, 67)
        PanelQuestion.TabIndex = 39
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(189, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(179, 19)
        Label6.TabIndex = 0
        Label6.Text = "Pertanyaannya disini"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(296, 182)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(574, 255)
        GroupBox1.TabIndex = 40
        GroupBox1.TabStop = False
        GroupBox1.Text = "Silahkan pilih salah satu jawaban"
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(52, 209)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(159, 22)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "5 - Sangat Tertarik"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(51, 167)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(104, 22)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "4 - Tertarik"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(51, 125)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(157, 22)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "3 - Cukup Tertarik"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(52, 84)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(157, 22)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "2 - Sedikit Tertarik"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.ForeColor = Color.Black
        RadioButton1.Location = New Point(52, 44)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(128, 22)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "1 - Tidak Tahu"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Button2.Location = New Point(296, 469)
        Button2.Name = "Button2"
        Button2.Size = New Size(206, 35)
        Button2.TabIndex = 41
        Button2.Text = "← Sebelumnya"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Button1.Location = New Point(675, 469)
        Button1.Name = "Button1"
        Button1.Size = New Size(195, 35)
        Button1.TabIndex = 42
        Button1.Text = "Selanjutnya →"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Sidebar)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ProgressBar1)
        Panel2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Panel2.Location = New Point(3, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(248, 546)
        Panel2.TabIndex = 43
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(16, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(129, 18)
        Label7.TabIndex = 10
        Label7.Text = "Kategori: Level 2"
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
        Button4.Location = New Point(0, 504)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(248, 42)
        Button4.TabIndex = 9
        Button4.Text = "Keluar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Sidebar
        ' 
        Sidebar.Controls.Add(PictureBox2)
        Sidebar.Controls.Add(PictureBox1)
        Sidebar.Dock = DockStyle.Top
        Sidebar.Location = New Point(0, 0)
        Sidebar.Margin = New Padding(4)
        Sidebar.Name = "Sidebar"
        Sidebar.Size = New Size(248, 103)
        Sidebar.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(104, 28)
        PictureBox2.Margin = New Padding(4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(133, 33)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(16, 13)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(16, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 18)
        Label4.TabIndex = 3
        Label4.Text = "Level 2: 0/3"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(16, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 18)
        Label3.TabIndex = 2
        Label3.Text = "Level 1: 2/4"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(16, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 18)
        Label2.TabIndex = 2
        Label2.Text = "Ringkasan Jawaban"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(15, 241)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(222, 26)
        ProgressBar1.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label8.Location = New Point(296, 70)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(187, 18)
        Label8.TabIndex = 23
        Label8.Text = "Prodi: Teknik Informatika"
        ' 
        ' FormKonsulTI1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 545)
        Controls.Add(Label8)
        Controls.Add(Panel2)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(GroupBox1)
        Controls.Add(PanelQuestion)
        Controls.Add(Panel5)
        Name = "FormKonsulTI1"
        Text = "Konsultasi Level 2 "
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        PanelQuestion.ResumeLayout(False)
        PanelQuestion.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Sidebar.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelQuestion As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Sidebar As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label8 As Label
End Class
