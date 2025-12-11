Imports MySql.Data.MySqlClient

Public Class Konsultasi

    ' Local model untuk pertanyaan
    Private Class Question
        Public Property Id As String
        Public Property Text As String
        Public Property Variabel As String ' A, C, K, H
    End Class

    ' ====== BAGIAN LOGIKA (Ditanam di sini sesuai request) ======

    Public Class HasilAnalisis
        Public Property Kode As String      ' Contoh: TI, DS, S
        Public Property Nama As String      ' Contoh: Teknik Informatika
        Public Property Pesan As String     ' Penjelasan hasil
        Public Property NilaiCF As Double   ' Nilai keyakinan (0.0 - 1.0)
    End Class

    ' --- RUMUS DASAR CF ---
    ' Rumus: (Nilai - 1) / 4
    Public Function HitungCF(skor As Double) As Double
        Dim hasil As Double = (skor - 1) / 4.0
        If hasil < 0 Then hasil = 0
        Return hasil
    End Function

    ' ==========================================
    ' ANALISIS RULE-BASED LEVEL 1 (TI / TMJ / TMD)
    ' ==========================================
    Private Class RuleCond
        Public Property VarName As String
        Public Property MinCF As Double
        Public Sub New(v As String, mincf As Double)
            VarName = v
            Me.MinCF = mincf
        End Sub
    End Class

    Private Class RuleSpec
        Public Property Prodi As String
        Public Property Nama As String
        Public Property Conds As List(Of RuleCond)
        Public Sub New(p As String, n As String)
            Prodi = p
            Nama = n
            Conds = New List(Of RuleCond)()
        End Sub
    End Class

    Private Function GetLevel1Rules() As List(Of RuleSpec)
        Dim TINGGI As Double = 0.75
        Dim KUAT As Double = 0.6
        Dim SEDANG As Double = 0.5

        Dim list As New List(Of RuleSpec)()

        ' --- RULES TI ---
        Dim r1 = New RuleSpec("TI", "Teknik Informatika")
        r1.Conds.Add(New RuleCond("A", TINGGI)) : r1.Conds.Add(New RuleCond("C", TINGGI))
        list.Add(r1)

        Dim r2 = New RuleSpec("TI", "Teknik Informatika")
        r2.Conds.Add(New RuleCond("A", TINGGI)) : r2.Conds.Add(New RuleCond("C", KUAT))
        list.Add(r2)

        Dim r3 = New RuleSpec("TI", "Teknik Informatika")
        r3.Conds.Add(New RuleCond("A", KUAT)) : r3.Conds.Add(New RuleCond("C", TINGGI))
        list.Add(r3)

        Dim r4 = New RuleSpec("TI", "Teknik Informatika")
        r4.Conds.Add(New RuleCond("A", KUAT)) : r4.Conds.Add(New RuleCond("C", KUAT))
        list.Add(r4)

        Dim r5 = New RuleSpec("TI", "Teknik Informatika")
        r5.Conds.Add(New RuleCond("A", SEDANG)) : r5.Conds.Add(New RuleCond("C", SEDANG))
        list.Add(r5)

        ' --- RULES TMJ ---
        Dim t1 = New RuleSpec("TMJ", "Teknik Multimedia Jaringan")
        t1.Conds.Add(New RuleCond("H", TINGGI)) : t1.Conds.Add(New RuleCond("A", SEDANG))
        list.Add(t1)

        Dim t2 = New RuleSpec("TMJ", "Teknik Multimedia Jaringan")
        t2.Conds.Add(New RuleCond("H", TINGGI)) : t2.Conds.Add(New RuleCond("C", SEDANG))
        list.Add(t2)

        Dim t3 = New RuleSpec("TMJ", "Teknik Multimedia Jaringan")
        t3.Conds.Add(New RuleCond("K", KUAT)) : t3.Conds.Add(New RuleCond("A", SEDANG))
        list.Add(t3)

        Dim t4 = New RuleSpec("TMJ", "Teknik Multimedia Jaringan")
        t4.Conds.Add(New RuleCond("H", KUAT)) : t4.Conds.Add(New RuleCond("A", SEDANG))
        list.Add(t4)

        ' --- RULES TMD ---
        Dim m1 = New RuleSpec("TMD", "Teknik Multimedia Digital")
        m1.Conds.Add(New RuleCond("K", TINGGI)) : m1.Conds.Add(New RuleCond("A", SEDANG))
        list.Add(m1)

        Dim m2 = New RuleSpec("TMD", "Teknik Multimedia Digital")
        m2.Conds.Add(New RuleCond("K", TINGGI)) : m2.Conds.Add(New RuleCond("C", SEDANG))
        list.Add(m2)

        Dim m3 = New RuleSpec("TMD", "Teknik Multimedia Digital")
        m3.Conds.Add(New RuleCond("K", KUAT)) : m3.Conds.Add(New RuleCond("A", SEDANG))
        list.Add(m3)

        Dim m4 = New RuleSpec("TMD", "Teknik Multimedia Digital")
        m4.Conds.Add(New RuleCond("K", KUAT)) : m4.Conds.Add(New RuleCond("C", SEDANG))
        list.Add(m4)

        Return list
    End Function

    ' Fungsi Utama Analisis
    Public Function AnalisisLevel1_ByRules(rataA As Double, rataC As Double, rataK As Double, rataH As Double) As HasilAnalisis
        Dim cfA = HitungCF(rataA)
        Dim cfC = HitungCF(rataC)
        Dim cfK = HitungCF(rataK)
        Dim cfH = HitungCF(rataH)

        Dim cfMap As New Dictionary(Of String, Double)(StringComparer.OrdinalIgnoreCase) From {
            {"A", cfA}, {"C", cfC}, {"K", cfK}, {"H", cfH}
        }

        Dim rules = GetLevel1Rules()
        Dim applicable As New List(Of Tuple(Of RuleSpec, Double))()

        ' 1. Cek Strict Rules (Semua syarat terpenuhi)
        For Each r In rules
            Dim ok = True
            Dim vals As New List(Of Double)
            For Each c In r.Conds
                Dim val = 0.0
                If cfMap.ContainsKey(c.VarName) Then val = cfMap(c.VarName)
                If val < c.MinCF Then ok = False : Exit For
                vals.Add(val)
            Next
            If ok AndAlso vals.Count > 0 Then
                ' Nilai kekuatan rule = nilai terendah dari kondisi (Min)
                Dim strength = vals.Min()
                applicable.Add(Tuple.Create(r, strength))
            End If
        Next

        Dim hasil As New HasilAnalisis()

        ' Jika ada rule yang tembus
        If applicable.Count > 0 Then
            Dim best = applicable.OrderByDescending(Function(t) t.Item2).First()
            hasil.Kode = best.Item1.Prodi
            hasil.Nama = best.Item1.Nama
            hasil.NilaiCF = best.Item2
            hasil.Pesan = "Rekomendasi berdasarkan aturan pakar: " & hasil.Nama
            Return hasil
        End If

        ' 2. Fallback: Soft Rules (Cari yang paling mendekati jika tidak ada yang pas)
        Dim softList As New List(Of Tuple(Of RuleSpec, Double))()
        For Each r In rules
            Dim vals As New List(Of Double)
            For Each c In r.Conds
                Dim valSoft = 0.0
                If cfMap.ContainsKey(c.VarName) Then valSoft = cfMap(c.VarName)
                vals.Add(valSoft)
            Next
            If vals.Count > 0 Then softList.Add(Tuple.Create(r, vals.Min()))
        Next

        If softList.Count > 0 Then
            Dim bestSoft = softList.OrderByDescending(Function(t) t.Item2).First()
            hasil.Kode = bestSoft.Item1.Prodi
            hasil.Nama = bestSoft.Item1.Nama
            hasil.NilaiCF = bestSoft.Item2
            hasil.Pesan = "Rekomendasi (pendekatan) berdasarkan kemiripan pola: " & hasil.Nama
            Return hasil
        End If

        ' 3. Fallback Terakhir: Variabel Tertinggi
        Dim maxCf = cfMap.OrderByDescending(Function(kv) kv.Value).First()
        Dim mapping As New Dictionary(Of String, String) From {{"A", "TI"}, {"C", "TI"}, {"K", "TMD"}, {"H", "TMJ"}}
        Dim mapped As String = If(mapping.ContainsKey(maxCf.Key), mapping(maxCf.Key), "UMUM")

        hasil.Kode = mapped
        hasil.Nama = mapped
        hasil.NilaiCF = maxCf.Value
        hasil.Pesan = "Rekomendasi berdasarkan minat dominanmu."
        Return hasil
    End Function

    ' ====== VARIABLES & FORM EVENTS ======

    Private questions As New List(Of Question)()
    Private currentIndex As Integer = 0

    Private answersByVar As New Dictionary(Of String, List(Of Integer)) From {
        {"A", New List(Of Integer)()},
        {"C", New List(Of Integer)()},
        {"K", New List(Of Integer)()},
        {"H", New List(Of Integer)()}
    }

    Private Sub Konsultasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BukaKoneksi()
            LoadLevel1Questions()

            If questions.Count = 0 Then
                MessageBox.Show("Tidak ada pertanyaan Level 1 di database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Return
            End If

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = questions.Count
            ProgressBar1.Value = 0
            currentIndex = 0
            ShowQuestion(currentIndex)

        Catch ex As Exception
            MessageBox.Show("Gagal inisialisasi konsultasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadLevel1Questions()
        questions.Clear()
        Try
            If conn Is Nothing OrElse conn.State = ConnectionState.Closed Then
                BukaKoneksi()
            End If

            Dim q As String = "SELECT id, pertanyaan, variabel FROM tb_pertanyaan WHERE tingkat='1' ORDER BY id ASC"
            cmd = New MySqlCommand(q, conn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                questions.Add(New Question With {
                    .Id = dr("id").ToString(),
                    .Text = dr("pertanyaan").ToString(),
                    .Variabel = dr("variabel").ToString()
                })
            End While
            dr.Close()
        Catch ex As Exception
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            Throw
        End Try
    End Sub

    Private Sub ShowQuestion(index As Integer)
        If index < 0 OrElse index >= questions.Count Then Return

        Dim q As Question = questions(index)
        Label6.Text = q.Text

        ' Reset pilihan
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False

        ' Update UI Labels
        Label5.Text = $"Level 3: 0/0"
        Label4.Text = $"Level 2: 0/0"
        Label3.Text = $"Level 1: {index + 1}/{questions.Count}"

        Button3.Text = If(index = questions.Count - 1, "Selesai", "Selanjutnya →")
    End Sub

    Private Function GetSelectedValue() As Integer
        If RadioButton1.Checked Then Return 1
        If RadioButton2.Checked Then Return 2
        If RadioButton3.Checked Then Return 3
        If RadioButton4.Checked Then Return 4
        If RadioButton5.Checked Then Return 5
        Return 0
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            Dim val = GetSelectedValue
            If val = 0 Then
                MessageBox.Show("Pilih salah satu jawaban terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            ' 1. Simpan Jawaban
            Dim q = questions(currentIndex)
            Dim varKey = If(String.IsNullOrWhiteSpace(q.Variabel), "A", q.Variabel.ToUpper)

            If Not answersByVar.ContainsKey(varKey) Then
                answersByVar(varKey) = New List(Of Integer)
            End If
            answersByVar(varKey).Add(val)

            ProgressBar1.Value = currentIndex + 1

            ' 2. Cek Navigasi
            currentIndex += 1
            If currentIndex < questions.Count Then
                ShowQuestion(currentIndex)
            Else
                ' === SELESAI & HITUNG HASIL ===

                ' Hitung Rata-rata Skor (1-5)
                Dim avgA = If(answersByVar("A").Count > 0, answersByVar("A").Average, 1.0)
                Dim avgC = If(answersByVar("C").Count > 0, answersByVar("C").Average, 1.0)
                Dim avgK = If(answersByVar("K").Count > 0, answersByVar("K").Average, 1.0)
                Dim avgH = If(answersByVar("H").Count > 0, answersByVar("H").Average, 1.0)

                ' Hitung CF (0-1)
                Dim cfA = HitungCF(avgA)
                Dim cfC = HitungCF(avgC)
                Dim cfK = HitungCF(avgK)
                Dim cfH = HitungCF(avgH)

                ' Jalankan Logika Rule-Based
                Dim hasil = AnalisisLevel1_ByRules(avgA, avgC, avgK, avgH)

                ' Buat Detail Perhitungan (Untuk ditampilkan di Form Hasil)
                Dim detail = "Rincian Skor:" & vbCrLf &
                                      $"Analytics (A): {avgA:0.0} (CF: {cfA:0.00})" & vbCrLf &
                                      $"Coding (C): {avgC:0.0} (CF: {cfC:0.00})" & vbCrLf &
                                      $"Creativity (K): {avgK:0.0} (CF: {cfK:0.00})" & vbCrLf &
                                      $"Hardware (H): {avgH:0.0} (CF: {cfH:0.00})" & vbCrLf & vbCrLf

                Dim pesanLengkap = hasil.Pesan & vbCrLf & vbCrLf & detail

                ' === INTEGRASI KE FORM HASIL BARU ===
                ' Membuka FormHasilLvl1 dengan parameter hasil hitungan
                Dim frmHasil As New FormHasilLvl1(pesanLengkap, hasil.Kode, hasil.Nama, hasil.NilaiCF)
                frmHasil.Show

                ' Sembunyikan form soal ini
                Hide
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class