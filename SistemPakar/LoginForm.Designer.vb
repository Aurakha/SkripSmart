<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm ' <--- SUDAH DIGANTI JADI LoginForm (Sesuai Logic)
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox() ' <-- Diubah dari TextBox1
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox() ' <-- Diubah dari TextBox2
        Me.btnLogin = New System.Windows.Forms.Button()     ' <-- Diubah dari Button1
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()     ' <-- Diubah dari Button2
        Me.btnDaftar = New System.Windows.Forms.Label()     ' <-- Diubah dari Label6 (Untuk Register)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()   ' <-- Diubah dari Panel1
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(59, 117)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(254, 23)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(59, 171)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(254, 23)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True ' Opsional: Agar password jadi bintang/titik
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogin.Location = New System.Drawing.Point(59, 247)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(254, 26)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lupa password?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Belum punya akun? "
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Red
        Me.btnBatal.Location = New System.Drawing.Point(59, 277)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(254, 24)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnDaftar
        '
        Me.btnDaftar.AutoSize = True
        Me.btnDaftar.Cursor = System.Windows.Forms.Cursors.Hand ' Biar kursor berubah saat dihover
        Me.btnDaftar.ForeColor = System.Drawing.Color.Blue
        Me.btnDaftar.Location = New System.Drawing.Point(175, 218)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(49, 15)
        Me.btnDaftar.TabIndex = 9
        Me.btnDaftar.Text = "Register"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Silahkan masukkan data yang valid"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Controls.Add(Me.Label7)
        Me.PanelHeader.Location = New System.Drawing.Point(-2, 0)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(369, 80)
        Me.PanelHeader.TabIndex = 11
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 322)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.btnDaftar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox ' Sesuai Logic
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox ' Sesuai Logic
    Friend WithEvents btnLogin As Button     ' Sesuai Logic
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBatal As Button     ' Sesuai Logic
    Friend WithEvents btnDaftar As Label     ' Sesuai Logic (Tetap label tapi namanya btnDaftar)
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelHeader As Panel   ' Sesuai Logic

End Class