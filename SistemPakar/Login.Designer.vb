<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(171, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 28)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(67, 156)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(290, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(67, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(67, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(67, 228)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(290, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(67, 329)
        Button1.Name = "Button1"
        Button1.Size = New Size(290, 34)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(67, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 20)
        Label4.TabIndex = 6
        Label4.Text = "Lupa password?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(67, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 20)
        Label5.TabIndex = 7
        Label5.Text = "Belum punya akun? "
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Location = New Point(67, 369)
        Button2.Name = "Button2"
        Button2.Size = New Size(290, 32)
        Button2.TabIndex = 8
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(200, 291)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 20)
        Label6.TabIndex = 9
        Label6.Text = "Register"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(94, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(239, 20)
        Label7.TabIndex = 10
        Label7.Text = "Silahkan masukkan data yang valid"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 106)
        Panel1.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 430)
        Controls.Add(Panel1)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel

End Class
