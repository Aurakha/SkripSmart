<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKonsulTI1
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
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Panel3 = New Panel()
        Label6 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel4 = New Panel()
        MenuStrip2 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripMenuItem()
        ToolStripMenuItem8 = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Timer1 = New Timer(components)
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        MenuStrip2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(592, 533)
        Button3.Name = "Button3"
        Button3.Size = New Size(179, 39)
        Button3.TabIndex = 34
        Button3.Text = "Selanjutnya →"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(41, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 29)
        Button1.TabIndex = 5
        Button1.Text = "Keluar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 3
        Label4.Text = "Level 2: 0/3"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 2
        Label3.Text = "Level 1: 2/4"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 20)
        Label2.TabIndex = 2
        Label2.Text = "Ringkasan Jawaban"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.AppWorkspace
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ProgressBar1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(2, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(226, 321)
        Panel2.TabIndex = 33
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(11, 70)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(197, 29)
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
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(255, 94)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(516, 74)
        Panel3.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label6.Location = New Point(160, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(173, 23)
        Label6.TabIndex = 0
        Label6.Text = "Pertanyaannya disini "
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(513, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 20)
        Label9.TabIndex = 12
        Label9.Text = "Label Jam "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label10.Location = New Point(635, 32)
        Label10.Name = "Label10"
        Label10.Size = New Size(141, 23)
        Label10.TabIndex = 11
        Label10.Text = "Kategori: Level 2 "
        Label10.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(MenuStrip2)
        Panel4.Location = New Point(-5, 1)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(828, 62)
        Panel4.TabIndex = 37
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem6})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(828, 28)
        MenuStrip2.TabIndex = 13
        MenuStrip2.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(129, 24)
        ToolStripMenuItem1.Text = "📊 Dashboard  "
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem3, ToolStripMenuItem4, ToolStripMenuItem5})
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(115, 24)
        ToolStripMenuItem2.Text = ChrW(55358) & ChrW(56800) & " Konsultasi"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(138, 26)
        ToolStripMenuItem3.Text = "Level 1"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(138, 26)
        ToolStripMenuItem4.Text = "Level 2"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(138, 26)
        ToolStripMenuItem5.Text = "Level 3"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem7, ToolStripMenuItem8})
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(171, 24)
        ToolStripMenuItem6.Text = "📝 Riwayat Konsultasi"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(243, 26)
        ToolStripMenuItem7.Text = "📅 Semua Riwayat"
        ' 
        ' ToolStripMenuItem8
        ' 
        ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        ToolStripMenuItem8.Size = New Size(243, 26)
        ToolStripMenuItem8.Text = "🎯 Hasil Rekomendasi"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(255, 193)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(516, 283)
        GroupBox1.TabIndex = 36
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
        RadioButton2.Size = New Size(154, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "2 - Sedikit Tertarik"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(46, 49)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(124, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "1 - Tidak Tahu"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' FormKonsulTI1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 606)
        Controls.Add(Button3)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(GroupBox1)
        Name = "FormKonsulTI1"
        Text = "Konsultasi Level 2 "
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
