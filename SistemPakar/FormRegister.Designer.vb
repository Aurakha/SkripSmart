<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
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
        PanelHeader = New Panel()
        LabelJudul = New Label()
        Label1 = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label3 = New Label()
        txtKonfirmasi = New TextBox()
        btnDaftar = New Button()
        btnKembali = New Button()
        PanelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        PanelHeader.Controls.Add(LabelJudul)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Margin = New Padding(5, 6, 5, 6)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(667, 154)
        PanelHeader.TabIndex = 0
        ' 
        ' LabelJudul
        ' 
        LabelJudul.AutoSize = True
        LabelJudul.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelJudul.ForeColor = Color.White
        LabelJudul.Location = New Point(158, 46)
        LabelJudul.Margin = New Padding(5, 0, 5, 0)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(269, 48)
        LabelJudul.TabIndex = 0
        LabelJudul.Text = "DAFTAR AKUN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(83, 192)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 11.0F)
        txtUsername.Location = New Point(90, 235)
        txtUsername.Margin = New Padding(5, 6, 5, 6)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(481, 37)
        txtUsername.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(83, 308)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 28)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11.0F)
        txtPassword.Location = New Point(90, 350)
        txtPassword.Margin = New Padding(5, 6, 5, 6)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(481, 37)
        txtPassword.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(83, 423)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 28)
        Label3.TabIndex = 5
        Label3.Text = "Ulangi Password"
        ' 
        ' txtKonfirmasi
        ' 
        txtKonfirmasi.Font = New Font("Segoe UI", 11.0F)
        txtKonfirmasi.Location = New Point(90, 465)
        txtKonfirmasi.Margin = New Padding(5, 6, 5, 6)
        txtKonfirmasi.Name = "txtKonfirmasi"
        txtKonfirmasi.PasswordChar = "*"c
        txtKonfirmasi.Size = New Size(481, 37)
        txtKonfirmasi.TabIndex = 6
        ' 
        ' btnDaftar
        ' 
        btnDaftar.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnDaftar.Cursor = Cursors.Hand
        btnDaftar.FlatAppearance.BorderSize = 0
        btnDaftar.FlatStyle = FlatStyle.Flat
        btnDaftar.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        btnDaftar.ForeColor = Color.White
        btnDaftar.Location = New Point(90, 558)
        btnDaftar.Margin = New Padding(5, 6, 5, 6)
        btnDaftar.Name = "btnDaftar"
        btnDaftar.Size = New Size(483, 77)
        btnDaftar.TabIndex = 7
        btnDaftar.Text = "DAFTAR SEKARANG"
        btnDaftar.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.Transparent
        btnKembali.Cursor = Cursors.Hand
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9.0F, FontStyle.Underline)
        btnKembali.ForeColor = Color.Gray
        btnKembali.Location = New Point(90, 654)
        btnKembali.Margin = New Padding(5, 6, 5, 6)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(483, 58)
        btnKembali.TabIndex = 8
        btnKembali.Text = "Sudah punya akun? Login disini"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(667, 865)
        Controls.Add(btnKembali)
        Controls.Add(btnDaftar)
        Controls.Add(txtKonfirmasi)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 6, 5, 6)
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormRegister"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelJudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKonfirmasi As TextBox
    Friend WithEvents btnDaftar As Button
    Friend WithEvents btnKembali As Button
End Class