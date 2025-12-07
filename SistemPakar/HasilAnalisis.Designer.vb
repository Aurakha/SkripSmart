<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HasilAnalisis
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Label1 = New Label()
        Label2 = New Label()
        Chart1 = New DataVisualization.Charting.Chart()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(287, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(317, 23)
        Label1.TabIndex = 0
        Label1.Text = "Hasil Analisis Topik Skripsi Anda"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 19)
        Label2.TabIndex = 1
        Label2.Text = "Topik Rekomendasi:"
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(62, 149)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.StackedBar
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(753, 227)
        Chart1.TabIndex = 2
        Chart1.Text = "Chart1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(233, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 19)
        Label3.TabIndex = 3
        Label3.Text = "Machine Learning"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(62, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 19)
        Label4.TabIndex = 4
        Label4.Text = "Nilai Dominan:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(188, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 19)
        Label5.TabIndex = 5
        Label5.Text = "Data Science (87%)"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Button1.Location = New Point(439, 395)
        Button1.Name = "Button1"
        Button1.Size = New Size(177, 40)
        Button1.TabIndex = 6
        Button1.Text = "Simpan Riwayat"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Button2.Location = New Point(617, 395)
        Button2.Name = "Button2"
        Button2.Size = New Size(198, 40)
        Button2.TabIndex = 7
        Button2.Text = "Kembali ke Dashboard"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' HasilAnalisis
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(881, 455)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Chart1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Name = "HasilAnalisis"
        Text = "Hasil Analisis"
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
