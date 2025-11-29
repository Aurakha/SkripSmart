<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        pnlPertanyaan = New FlowLayoutPanel()
        btnLanjut = New Button()
        PanelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        PanelHeader.Controls.Add(LabelJudul)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Margin = New Padding(2, 2, 2, 2)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(560, 48)
        PanelHeader.TabIndex = 0
        ' 
        ' LabelJudul
        ' 
        LabelJudul.AutoSize = True
        LabelJudul.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LabelJudul.ForeColor = Color.White
        LabelJudul.Location = New Point(17, 12)
        LabelJudul.Margin = New Padding(2, 0, 2, 0)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(276, 30)
        LabelJudul.TabIndex = 0
        LabelJudul.Text = "Kuesioner Minat (Level 1)"
        ' 
        ' pnlPertanyaan
        ' 
        pnlPertanyaan.AutoScroll = True
        pnlPertanyaan.BackColor = Color.WhiteSmoke
        pnlPertanyaan.Dock = DockStyle.Top
        pnlPertanyaan.FlowDirection = FlowDirection.TopDown
        pnlPertanyaan.Location = New Point(0, 48)
        pnlPertanyaan.Margin = New Padding(2, 2, 2, 2)
        pnlPertanyaan.Name = "pnlPertanyaan"
        pnlPertanyaan.Padding = New Padding(14, 12, 14, 12)
        pnlPertanyaan.Size = New Size(560, 300)
        pnlPertanyaan.TabIndex = 1
        pnlPertanyaan.WrapContents = False
        ' 
        ' btnLanjut
        ' 
        btnLanjut.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnLanjut.Cursor = Cursors.Hand
        btnLanjut.FlatStyle = FlatStyle.Flat
        btnLanjut.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnLanjut.ForeColor = Color.White
        btnLanjut.Location = New Point(140, 360)
        btnLanjut.Margin = New Padding(2, 2, 2, 2)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(280, 36)
        btnLanjut.TabIndex = 2
        btnLanjut.Text = "CEK HASIL ANALISIS"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(560, 420)
        Controls.Add(btnLanjut)
        Controls.Add(pnlPertanyaan)
        Controls.Add(PanelHeader)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Pakar - Tes Level 1"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LabelJudul As Label
    Friend WithEvents pnlPertanyaan As FlowLayoutPanel
    Friend WithEvents btnLanjut As Button
End Class