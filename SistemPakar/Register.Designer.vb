<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Panel1 = New Panel()
        Label7 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(174, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 28)
        Label1.TabIndex = 1
        Label1.Text = "REGISTER"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(77, 205)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(290, 27)
        TextBox2.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(77, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(77, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 6
        Label2.Text = "Username"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(77, 133)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(290, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(77, 282)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(290, 27)
        TextBox3.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(77, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 25)
        Label4.TabIndex = 11
        Label4.Text = "Ulangi Password"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Location = New Point(77, 375)
        Button2.Name = "Button2"
        Button2.Size = New Size(290, 35)
        Button2.TabIndex = 14
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(77, 334)
        Button1.Name = "Button1"
        Button1.Size = New Size(290, 35)
        Button1.TabIndex = 13
        Button1.Text = "Daftar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(446, 93)
        Panel1.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(128, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 20)
        Label7.TabIndex = 16
        Label7.Text = "Isi data pendaftaran anda"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(444, 450)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Name = "Register"
        Text = "Register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
End Class
