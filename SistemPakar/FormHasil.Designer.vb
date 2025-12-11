<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
        Label2 = New Label()
        btnLanjut = New Button()
        btnTutup = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(187, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 22)
        Label1.TabIndex = 0
        Label1.Text = "Level 1 Selesai!" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(18, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(484, 22)
        Label2.TabIndex = 1
        Label2.Text = "Lanjutkan ke Level 2 untuk hasil analisis lengkap Anda"
        ' 
        ' btnLanjut
        ' 
        btnLanjut.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        btnLanjut.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLanjut.ForeColor = Color.White
        btnLanjut.Location = New Point(332, 138)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(170, 38)
        btnLanjut.TabIndex = 19
        btnLanjut.Text = "Lanjut Level 2 →"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnTutup.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(18, 140)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(161, 36)
        btnTutup.TabIndex = 20
        btnTutup.Text = "Tutup Aplikasi"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(113), CByte(50), CByte(202))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnLanjut)
        Panel1.Controls.Add(btnTutup)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(48, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(519, 191)
        Panel1.TabIndex = 21
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(621, 284)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormHasil"
        Text = "Hasil Analisis"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLanjut As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents Panel1 As Panel
End Class
