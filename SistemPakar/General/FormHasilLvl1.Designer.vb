<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasilLvl1
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.lblNamaHasil = New System.Windows.Forms.Label()
        Me.lblCF = New System.Windows.Forms.Label()
        Me.txtPesan = New System.Windows.Forms.TextBox()
        Me.btnLanjut = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.LabelHeader)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(600, 80)
        Me.PanelHeader.TabIndex = 0
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelHeader.ForeColor = System.Drawing.Color.White
        Me.LabelHeader.Location = New System.Drawing.Point(20, 20)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(262, 45)
        Me.LabelHeader.TabIndex = 0
        Me.LabelHeader.Text = "HASIL ANALISIS"
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblIntro.ForeColor = System.Drawing.Color.Gray
        Me.lblIntro.Location = New System.Drawing.Point(25, 100)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(326, 28)
        Me.lblIntro.TabIndex = 1
        Me.lblIntro.Text = "Berdasarkan jawabanmu, kamu cocok masuk ke:"
        '
        'lblNamaHasil
        '
        Me.lblNamaHasil.AutoSize = True
        Me.lblNamaHasil.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaHasil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblNamaHasil.Location = New System.Drawing.Point(22, 130)
        Me.lblNamaHasil.Name = "lblNamaHasil"
        Me.lblNamaHasil.Size = New System.Drawing.Size(437, 54)
        Me.lblNamaHasil.TabIndex = 2
        Me.lblNamaHasil.Text = "TEKNIK INFORMATIKA"
        '
        'lblCF
        '
        Me.lblCF.AutoSize = True
        Me.lblCF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCF.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCF.Location = New System.Drawing.Point(25, 190)
        Me.lblCF.Name = "lblCF"
        Me.lblCF.Size = New System.Drawing.Size(248, 30)
        Me.lblCF.TabIndex = 3
        Me.lblCF.Text = "Tingkat Keyakinan: 0%"
        '
        'txtPesan
        '
        Me.txtPesan.BackColor = System.Drawing.Color.White
        Me.txtPesan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPesan.Location = New System.Drawing.Point(30, 240)
        Me.txtPesan.Multiline = True
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.ReadOnly = True
        Me.txtPesan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPesan.Size = New System.Drawing.Size(540, 150)
        Me.txtPesan.TabIndex = 4
        Me.txtPesan.Text = "Deskripsi detail hasil analisis..."
        '
        'btnLanjut
        '
        Me.btnLanjut.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLanjut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLanjut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLanjut.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLanjut.ForeColor = System.Drawing.Color.White
        Me.btnLanjut.Location = New System.Drawing.Point(30, 410)
        Me.btnLanjut.Name = "btnLanjut"
        Me.btnLanjut.Size = New System.Drawing.Size(540, 55)
        Me.btnLanjut.TabIndex = 5
        Me.btnLanjut.Text = "LANJUT KE TAHAP BERIKUTNYA >>"
        Me.btnLanjut.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.Transparent
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline)
        Me.btnTutup.ForeColor = System.Drawing.Color.Gray
        Me.btnTutup.Location = New System.Drawing.Point(30, 480)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(540, 35)
        Me.btnTutup.TabIndex = 6
        Me.btnTutup.Text = "Tutup Aplikasi"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'FormHasilLvl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 550)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnLanjut)
        Me.Controls.Add(Me.txtPesan)
        Me.Controls.Add(Me.lblCF)
        Me.Controls.Add(Me.lblNamaHasil)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormHasilLvl1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hasil Analisis Level 1"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelHeader As Label
    Friend WithEvents lblIntro As Label
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblCF As Label
    Friend WithEvents txtPesan As TextBox
    Friend WithEvents btnLanjut As Button
    Friend WithEvents btnTutup As Button
End Class