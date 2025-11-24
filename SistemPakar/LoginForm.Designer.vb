<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelHeader = New Panel()
        LabelJudul = New Label()
        Label1 = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnBatal = New Button()
        btnDaftar = New Button()
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
        PanelHeader.Size = New Size(709, 154)
        PanelHeader.TabIndex = 0
        ' 
        ' LabelJudul
        ' 
        LabelJudul.AutoSize = True
        LabelJudul.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelJudul.ForeColor = Color.White
        LabelJudul.Location = New Point(108, 46)
        LabelJudul.Margin = New Padding(5, 0, 5, 0)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(391, 48)
        LabelJudul.TabIndex = 0
        LabelJudul.Text = "LOGIN SISTEM PAKAR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(101, 186)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(108, 228)
        txtUsername.Margin = New Padding(5, 6, 5, 6)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(481, 37)
        txtUsername.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(101, 320)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 28)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(108, 362)
        txtPassword.Margin = New Padding(5, 6, 5, 6)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(481, 37)
        txtPassword.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(108, 431)
        btnLogin.Margin = New Padding(5, 6, 5, 6)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(483, 77)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(108, 537)
        btnBatal.Margin = New Padding(5, 6, 5, 6)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(483, 77)
        btnBatal.TabIndex = 6
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnDaftar
        ' 
        btnDaftar.BackColor = Color.Transparent
        btnDaftar.Cursor = Cursors.Hand
        btnDaftar.FlatAppearance.BorderSize = 0
        btnDaftar.FlatStyle = FlatStyle.Flat
        btnDaftar.Font = New Font("Segoe UI", 9.0F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        btnDaftar.ForeColor = Color.Gray
        btnDaftar.Location = New Point(108, 643)
        btnDaftar.Margin = New Padding(5, 6, 5, 6)
        btnDaftar.Name = "btnDaftar"
        btnDaftar.Size = New Size(483, 58)
        btnDaftar.TabIndex = 7
        btnDaftar.Text = "Belum punya akun? Daftar disini"
        btnDaftar.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(709, 857)
        Controls.Add(btnDaftar)
        Controls.Add(btnBatal)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 6, 5, 6)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
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
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnDaftar As Button
End Class