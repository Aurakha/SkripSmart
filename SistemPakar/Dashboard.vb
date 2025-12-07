Public Class Dashboard
    Private Sub DetailKonsultasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailKonsultasiToolStripMenuItem.Click
        Try
            ' Buka form konsultasi utama (Form1) jika ada
            Dim f As Form = Nothing
            Try
                f = New Dashboard()
            Catch ex As Exception
                f = Nothing
            End Try

            If f IsNot Nothing Then
                f.StartPosition = FormStartPosition.CenterScreen
                f.Show()
            Else
                MessageBox.Show("Form konsultasi (Form1) tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membuka form konsultasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        ' Placeholder: bisa digunakan untuk inisialisasi saat GroupBox di-focus
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' Contoh: tunjukkan info singkat saat label diklik
        MessageBox.Show("Dashboard - Klik menu untuk membuka konsultasi atau melihat hasil.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub HasilRekomendasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HasilRekomendasiToolStripMenuItem.Click
        Try
            ' Coba temukan dan buka form hasil rekomendasi jika ada (tipe bernama FormHasilRekomendasi)
            Dim typeName = "SistemPakar.FormHasilRekomendasi"
            Dim t = Type.GetType(typeName)
            If t IsNot Nothing Then
                Dim inst = Activator.CreateInstance(t)
                Dim frm = TryCast(inst, Form)
                If frm IsNot Nothing Then
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.Show()
                    Return
                End If
            End If

            ' fallback: jika tidak ada form khusus, arahkan ke Form1
            Dim f As Form = Nothing
            Try
                f = New Dashboard()
            Catch ex As Exception
                f = Nothing
            End Try

            If f IsNot Nothing Then
                MessageBox.Show("Form hasil khusus belum tersedia. Membuka form utama.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                f.StartPosition = FormStartPosition.CenterScreen
                f.Show()
            Else
                MessageBox.Show("Form hasil rekomendasi belum tersedia di proyek.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membuka hasil rekomendasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handler untuk tombol "Mulai Konsultasi" (Button1 di Designer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim frm As Form = Nothing
            Try
                ' Class pada file General\FormKonsulGeneral1.vb adalah "Konsultasi"
                frm = New Konsultasi()
            Catch ex As Exception
                ' Fallback: coba create instance dengan Type.GetType jika berbeda namespace
                Dim typeName = "SistemPakar.Konsultasi" ' sesuaikan namespace bila perlu
                Dim t = Type.GetType(typeName)
                If t IsNot Nothing Then
                    Dim inst = Activator.CreateInstance(t)
                    frm = TryCast(inst, Form)
                End If
            End Try

            If frm IsNot Nothing Then
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.Show()
                ' Sembunyikan dashboard saat konsultasi dibuka
                Me.Hide()
            Else
                MessageBox.Show("Form konsultasi tidak ditemukan. Periksa nama class di General\FormKonsulGeneral1.vb.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membuka form konsultasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class