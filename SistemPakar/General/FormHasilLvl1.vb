Public Class FormHasilLvl1

    ' Variabel global untuk menyimpan kode hasil agar bisa dipakai tombol Lanjut
    Private KodeHasil As String = ""

    ' Constructor (Sub New) khusus untuk menerima data saat form dibuat
    Public Sub New(pesanLengkap As String, kode As String, nama As String, nilaiCF As Double)
        ' Wajib ada untuk inisialisasi desain
        InitializeComponent()

        ' Simpan kode untuk navigasi
        Me.KodeHasil = kode

        ' Tampilkan data ke label-label
        lblNamaHasil.Text = nama
        lblCF.Text = "Tingkat Keyakinan: " & (nilaiCF * 100).ToString("0.0") & "%"
        txtPesan.Text = pesanLengkap

        ' Logika Tombol Lanjut
        If kode = "UMUM" Or kode = "ERROR" Then
            btnLanjut.Enabled = False
            btnLanjut.BackColor = Color.Gray
            btnLanjut.Text = "Hasil Tidak Spesifik (Selesai)"
        Else
            btnLanjut.Text = "LANJUT KE KUESIONER " & kode & " >>"
        End If
    End Sub

    ' Tombol Lanjut: Pindah ke Form Level 2 sesuai Prodi
    Private Sub btnLanjut_Click(sender As Object, e As EventArgs)
        Hide ' Sembunyikan form hasil

        ' Navigasi berdasarkan Kode Hasil (TI/TMJ/TMD)
        Select Case KodeHasil
            Case "TI"
                ' Pastikan kamu punya FormKonsulTI1
                Dim frm As New FormKonsulTI
                frm.Show
            Case "TMJ"
                ' Pastikan kamu punya FormKonsulTMJ1
                Dim frm As New FormKonsulTMJ
                frm.Show
            Case "TMD"
                ' Pastikan kamu punya FormKonsulTMD1
                Dim frm As New FormKonsulTMD
                frm.Show
            Case Else
                MsgBox("Form untuk prodi ini belum tersedia.", MsgBoxStyle.Information)
                Show
        End Select
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs)
        Application.Exit
    End Sub


End Class