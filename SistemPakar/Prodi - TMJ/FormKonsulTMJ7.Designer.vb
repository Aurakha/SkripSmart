<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKonsulTMJ7
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
        Button3 = New Button()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton1 = New RadioButton()
        Panel3 = New Panel()
        Label6 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        MenuStrip1 = New MenuStrip()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        KonsultasiToolStripMenuItem = New ToolStripMenuItem()
        KategoriLevel1ToolStripMenuItem = New ToolStripMenuItem()
        Level2ToolStripMenuItem = New ToolStripMenuItem()
        Level3ToolStripMenuItem = New ToolStripMenuItem()
        RiwayatKonsultasiToolStripMenuItem = New ToolStripMenuItem()
        SemuaRiwayatToolStripMenuItem = New ToolStripMenuItem()
        HasilRekomendasiToolStripMenuItem1 = New ToolStripMenuItem()
        Panel2 = New Panel()
        Button2 = New Button()
        Timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(596, 517)
        Button3.Name = "Button3"
        Button3.Size = New Size(192, 39)
        Button3.TabIndex = 52
        Button3.Text = "Selanjutnya →"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(45, 186)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(105, 24)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "4 - Tertarik"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(45, 139)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(152, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "3 - Cukup Tertarik"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(46, 93)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(145, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "2 - Tidak Tertarik"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(259, 193)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(529, 283)
        GroupBox1.TabIndex = 55
        GroupBox1.TabStop = False
        GroupBox1.Text = "Silahkan pilih salah satu jawaban"
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(46, 232)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(155, 24)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "5 - Sangat Tertarik"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(46, 49)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(194, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "1 - Sangat Tidak Tertarik"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(259, 94)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(529, 74)
        Panel3.TabIndex = 53
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label6.Location = New Point(46, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(451, 46)
        Label6.TabIndex = 0
        Label6.Text = "Seberapa tertarik kamu memahami bagaimana informasi " & vbCrLf & "berpindah dari satu titik ke titik lain dalam sebuah sistem"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(35, 263)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 29)
        Button1.TabIndex = 5
        Button1.Text = "Keluar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 20)
        Label5.TabIndex = 4
        Label5.Text = "Level 3: 1/2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 3
        Label4.Text = "Level 2: 0/3"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 2
        Label3.Text = "Level 1: 2/4"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 20)
        Label2.TabIndex = 2
        Label2.Text = "Ringkasan Jawaban"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(21, 70)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(206, 29)
        ProgressBar1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 0
        Label1.Text = "Halo, User"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Location = New Point(-7, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(848, 62)
        Panel1.TabIndex = 54
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(513, 35)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 20)
        Label8.TabIndex = 12
        Label8.Text = "Label Jam "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label7.Location = New Point(620, 33)
        Label7.Name = "Label7"
        Label7.Size = New Size(185, 23)
        Label7.TabIndex = 11
        Label7.Text = "Kategori: Level 2 (TMJ)"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, KonsultasiToolStripMenuItem, RiwayatKonsultasiToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(848, 28)
        MenuStrip1.TabIndex = 13
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(129, 24)
        HomeToolStripMenuItem.Text = "📊 Dashboard  "
        ' 
        ' KonsultasiToolStripMenuItem
        ' 
        KonsultasiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {KategoriLevel1ToolStripMenuItem, Level2ToolStripMenuItem, Level3ToolStripMenuItem})
        KonsultasiToolStripMenuItem.Name = "KonsultasiToolStripMenuItem"
        KonsultasiToolStripMenuItem.Size = New Size(115, 24)
        KonsultasiToolStripMenuItem.Text = ChrW(55358) & ChrW(56800) & " Konsultasi"
        ' 
        ' KategoriLevel1ToolStripMenuItem
        ' 
        KategoriLevel1ToolStripMenuItem.Name = "KategoriLevel1ToolStripMenuItem"
        KategoriLevel1ToolStripMenuItem.Size = New Size(138, 26)
        KategoriLevel1ToolStripMenuItem.Text = "Level 1"
        ' 
        ' Level2ToolStripMenuItem
        ' 
        Level2ToolStripMenuItem.Name = "Level2ToolStripMenuItem"
        Level2ToolStripMenuItem.Size = New Size(138, 26)
        Level2ToolStripMenuItem.Text = "Level 2"
        ' 
        ' Level3ToolStripMenuItem
        ' 
        Level3ToolStripMenuItem.Name = "Level3ToolStripMenuItem"
        Level3ToolStripMenuItem.Size = New Size(138, 26)
        Level3ToolStripMenuItem.Text = "Level 3"
        ' 
        ' RiwayatKonsultasiToolStripMenuItem
        ' 
        RiwayatKonsultasiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SemuaRiwayatToolStripMenuItem, HasilRekomendasiToolStripMenuItem1})
        RiwayatKonsultasiToolStripMenuItem.Name = "RiwayatKonsultasiToolStripMenuItem"
        RiwayatKonsultasiToolStripMenuItem.Size = New Size(171, 24)
        RiwayatKonsultasiToolStripMenuItem.Text = "📝 Riwayat Konsultasi"
        ' 
        ' SemuaRiwayatToolStripMenuItem
        ' 
        SemuaRiwayatToolStripMenuItem.Name = "SemuaRiwayatToolStripMenuItem"
        SemuaRiwayatToolStripMenuItem.Size = New Size(243, 26)
        SemuaRiwayatToolStripMenuItem.Text = "📅 Semua Riwayat"
        ' 
        ' HasilRekomendasiToolStripMenuItem1
        ' 
        HasilRekomendasiToolStripMenuItem1.Name = "HasilRekomendasiToolStripMenuItem1"
        HasilRekomendasiToolStripMenuItem1.Size = New Size(243, 26)
        HasilRekomendasiToolStripMenuItem1.Text = "🎯 Hasil Rekomendasi"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.AppWorkspace
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ProgressBar1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(2, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(248, 321)
        Panel2.TabIndex = 51
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(259, 517)
        Button2.Name = "Button2"
        Button2.Size = New Size(191, 39)
        Button2.TabIndex = 56
        Button2.Text = "← Sebelumnya"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FormKonsulTMJ7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 606)
        Controls.Add(Button3)
        Controls.Add(GroupBox1)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Button2)
        Name = "FormKonsulTMJ7"
        Text = "Konsultasi Level 2 - Prodi TMJ"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonsultasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriLevel1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Level2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Level3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiwayatKonsultasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemuaRiwayatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasilRekomendasiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
End Class
