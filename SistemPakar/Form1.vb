Imports MySql.Data.MySqlClient
Imports System.Diagnostics
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Form1

    ' Struktur data sederhana untuk menyimpan info pertanyaan di UI
    Private Class InfoPertanyaan
        Public Property ID As String
        Public Property Variabel As String ' A, C, K, atau H
    End Class

    ' 1. Saat Form Dibuka: Load Pertanyaan dari Database
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaKoneksi()
        TampilkanPertanyaan()
    End Sub

    Private Sub TampilkanPertanyaan()
        Try
            ' QUERY PENTING: Mengambil pertanyaan Level 1 dari database kamu
            Dim query As String = "SELECT id, pertanyaan, variabel FROM tb_pertanyaan WHERE tingkat='1' ORDER BY id ASC"
            cmd = New MySqlCommand(query, conn)
            dr = cmd.ExecuteReader()

            pnlPertanyaan.Controls.Clear()

            While dr.Read()
                Dim idSoal As String = dr("id").ToString()
                Dim teksSoal As String = dr("pertanyaan").ToString()
                Dim varSoal As String = dr("variabel").ToString()

                ' Buat Wadah per Soal (GroupBox)
                Dim gb As New GroupBox()
                gb.Text = "" ' Judul kosong biar rapi
                gb.Size = New Size(720, 110)
                gb.Font = New Font("Segoe UI", 10)
                ' Simpan ID dan Variabel di Tag supaya bisa diambil nanti saat hitung skor
                gb.Tag = New InfoPertanyaan With {.ID = idSoal, .Variabel = varSoal}

                ' Buat Label Pertanyaan
                Dim lbl As New Label()
                lbl.Text = teksSoal
                lbl.Location = New Point(10, 15)
                lbl.AutoSize = True
                lbl.MaximumSize = New Size(700, 0) ' Biar wrap kalau teks panjang
                gb.Controls.Add(lbl)

                ' Buat 5 Pilihan RadioButton (1-5)
                Dim xPos As Integer = 10
                For i As Integer = 1 To 5
                    Dim rb As New RadioButton()
                    rb.Text = i.ToString()
                    rb.AutoSize = True
                    rb.Location = New Point(xPos, 60)
                    rb.Tag = i ' Nilai skor (1, 2, 3, 4, 5) disimpan di Tag

                    ' Opsional: Tambah tooltip (1=Sangat Tidak Paham, 5=Sangat Paham)
                    If i = 1 Then rb.Text &= " (Tidak)"
                    If i = 5 Then rb.Text &= " (Sangat)"

                    gb.Controls.Add(rb)
                    xPos += 130 ' Geser posisi tombol berikutnya
                Next

                ' Masukkan ke Panel
                pnlPertanyaan.Controls.Add(gb)
            End While
            dr.Close()

        Catch ex As Exception
            dr.Close()
            MsgBox("Gagal memuat pertanyaan: " & ex.Message)
        End Try
    End Sub

    ' 2. Saat Tombol Ditekan: Hitung Skor -> Kirim ke Python
    ' 2. Saat Tombol Ditekan: Hitung Skor -> Kirim ke Python
    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click
        ' --- (Bagian hitung skor di atas SAMA AJA, gak perlu diubah) ---
        ' ... (Copy paste dari kode lamamu atau biarkan yang atas) ...

        ' KITA UBAH DARI SINI KE BAWAH:

        Dim skorA As Integer = 0
        Dim skorC As Integer = 0
        Dim skorK As Integer = 0
        Dim skorH As Integer = 0

        Dim jumlahTerjawab As Integer = 0

        ' Loop hitung skor (SAMA SEPERTI SEBELUMNYA)
        For Each ctrl As Control In pnlPertanyaan.Controls
            If TypeOf ctrl Is GroupBox Then
                Dim gb As GroupBox = CType(ctrl, GroupBox)
                Dim info As InfoPertanyaan = CType(gb.Tag, InfoPertanyaan)
                Dim adaJawaban As Boolean = False
                For Each subCtrl As Control In gb.Controls
                    If TypeOf subCtrl Is RadioButton Then
                        Dim rb As RadioButton = CType(subCtrl, RadioButton)
                        If rb.Checked Then
                            Dim nilai As Integer = CInt(rb.Tag)
                            Select Case info.Variabel
                                Case "A" : skorA += nilai
                                Case "C" : skorC += nilai
                                Case "K" : skorK += nilai
                                Case "H" : skorH += nilai
                            End Select
                            adaJawaban = True
                            Exit For
                        End If
                    End If
                Next
                If adaJawaban Then jumlahTerjawab += 1
            End If
        Next

        ' Cek kelengkapan
        If jumlahTerjawab < pnlPertanyaan.Controls.Count Then
            MsgBox("Jawab semua dulu dong bang!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Hitung Rata-rata
        Dim rataA As Integer = HitungRataRata(skorA, "A")
        Dim rataC As Integer = HitungRataRata(skorC, "C")
        Dim rataK As Integer = HitungRataRata(skorK, "K")
        Dim rataH As Integer = HitungRataRata(skorH, "H")

        ' === [PERUBAHAN PENTING DI SINI] ===
        ' Jangan kirim JSON. Kirim angka berjejer pakai spasi.
        ' Contoh hasil: "5 4 2 1"
        Dim dataKirim As String = $"{rataA} {rataC} {rataK} {rataH}"

        ' Panggil Python
        Dim hasilJson As String = JalankanPython("logic.py", dataKirim)
        TampilkanHasil(hasilJson)
    End Sub

    ' Fungsi Bantu Hitung Rata-Rata (Pembulatan ke bawah/atas sederhana)
    Private Function HitungRataRata(totalSkor As Integer, kodeVar As String) As Integer
        ' Cari tahu ada berapa soal untuk variabel tersebut di Level 1
        ' Cara cepat: Hardcode jumlah soal jika sudah pasti, atau query lagi.
        ' Berdasarkan SQL kamu: A=3 soal, C=3 soal, K=3 soal, H=3 soal.
        ' Total soal 12.
        Dim jumlahSoal As Integer = 3

        If jumlahSoal = 0 Then Return 0
        Return CInt(Math.Round(totalSkor / jumlahSoal))
    End Function

    Private Sub TampilkanHasil(jsonStr As String)
        Try
            ' 1. Cek dulu apakah string kosong
            If String.IsNullOrWhiteSpace(jsonStr) Then
                MsgBox("Python tidak mengembalikan apa-apa (Kosong).", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim obj As JObject = JObject.Parse(jsonStr)

            ' 2. CEK APAKAH ADA ERROR DARI PYTHON?
            ' Kalau logic.py masuk ke 'except', dia biasanya kirim kunci "error"
            If obj("error") IsNot Nothing Then
                MsgBox("Terjadi Error di Logic Python:" & vbCrLf & obj("error").ToString(), MsgBoxStyle.Critical)
                Exit Sub
            End If

            ' 3. CEK APAKAH KUNCI 'PRODI' ADA?
            ' Ini untuk mencegah error NullReference yang kamu alami barusan
            If obj("prodi") Is Nothing Then
                MsgBox("Python merespon, tapi formatnya salah!" & vbCrLf &
                       "Isi respon asli: " & jsonStr, MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' 4. Kalau aman, baru ambil datanya
            Dim prodi As String = obj("prodi").ToString()
            Dim pesan As String = ""

            ' Cek pesan juga biar aman
            If obj("pesan") IsNot Nothing Then
                pesan = obj("pesan").ToString()
            End If

            MsgBox("Hasil Analisis Python:" & vbCrLf &
                   "Rekomendasi Prodi: " & prodi & vbCrLf &
                   pesan, MsgBoxStyle.Information, "Hasil Level 1")

            ' TODO: Nanti di sini kita lanjut ke Form Level 2

        Catch ex As Exception
            MsgBox("Gagal membaca hasil dari Python." & vbCrLf &
                   "Pesan Error: " & ex.Message & vbCrLf &
                   "Data Asli: " & jsonStr, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function JalankanPython(namaScript As String, argumen As String) As String
        Try
            Dim p As New Process()

            ' === [MULAI PERUBAHAN] TEMBAK LANGSUNG ALAMAT PYTHON ===
            ' 1. Cek folder default Python 3.13 untuk user 'khair'
            Dim pathPython As String = "C:\Users\khair\AppData\Local\Programs\Python\Python313\python.exe"

            ' 2. Kalau file tidak ketemu di sana, coba cek versi 3.12 (jaga-jaga)
            If Not File.Exists(pathPython) Then
                pathPython = "C:\Users\khair\AppData\Local\Programs\Python\Python312\python.exe"

                ' 3. Kalau masih tidak ketemu juga, coba pakai launcher universal 'py'
                If Not File.Exists(pathPython) Then
                    pathPython = "py"
                End If
            End If

            ' Set FileName dengan alamat yang sudah ditemukan
            p.StartInfo.FileName = pathPython
            ' === [AKHIR PERUBAHAN] =================================

            p.StartInfo.Arguments = $"""{namaScript}"" ""{argumen}"""
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.StartInfo.RedirectStandardError = True ' Tetap baca error
            p.StartInfo.CreateNoWindow = True
            p.Start()

            Dim output As String = p.StandardOutput.ReadToEnd()
            Dim errorMsg As String = p.StandardError.ReadToEnd() ' Tangkap pesan error
            p.WaitForExit()

            ' Cek apakah Python ngomel (ada error)
            If Not String.IsNullOrEmpty(errorMsg) Then
                ' Filter pesan "System cannot find file specified" bawaan Windows jika path salah
                If errorMsg.Contains("is not recognized") Or errorMsg.Contains("cannot find") Then
                    Return "{""prodi"": ""ERROR"", ""pesan"": ""PYTHON TIDAK DITEMUKAN di: " & pathPython & """}"
                End If

                Dim pesanError As String = errorMsg.Replace(vbCrLf, " ").Replace("""", "'")
                Return "{""prodi"": ""ERROR"", ""pesan"": ""PYTHON CRASH: " & pesanError & """}"
            End If

            If String.IsNullOrEmpty(output) Then
                Return "{""prodi"": ""ERROR"", ""pesan"": ""Python tidak menghasilkan output apa-apa.""}"
            End If

            Return output

        Catch ex As Exception
            Return "{""prodi"": ""ERROR"", ""pesan"": ""Gagal Start Python: " & ex.Message & """}"
        End Try
    End Function

End Class