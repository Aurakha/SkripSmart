Imports MySql.Data.MySqlClient

Public Class Register

    ' 1. Saat Form Dibuka
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaKoneksi()
        TextBox1.Focus() ' Fokus ke Username
    End Sub

    ' 2. Tombol DAFTAR (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' A. Validasi Input Kosong
        ' TextBox1 = Username, TextBox2 = Password, TextBox3 = Ulangi Password
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        ' B. Validasi Password Sama
        If TextBox2.Text <> TextBox3.Text Then
            MsgBox("Password dan Ulangi Password tidak cocok!", MsgBoxStyle.Critical, "Error")
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox2.Focus()
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' C. Cek Duplikat Username
            Dim queryCek As String = "SELECT * FROM tb_akun WHERE username='" & TextBox1.Text & "'"
            cmd = New MySqlCommand(queryCek, conn)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Username '" & TextBox1.Text & "' sudah dipakai! Silakan pilih username lain.", MsgBoxStyle.Exclamation, "Gagal")
                dr.Close()
                TextBox1.Focus()
                Exit Sub
            End If
            dr.Close()

            ' === D. PROSES HASHING & SIMPAN ===
            ' Password asli (TextBox2) diubah jadi Hash SHA-256
            Dim passwordAman As String = BuatHash(TextBox2.Text)

            ' Simpan Username dan Password Hash ke Database
            Dim querySimpan As String = "INSERT INTO tb_akun (username, password) VALUES ('" & TextBox1.Text & "', '" & passwordAman & "')"

            cmd = New MySqlCommand(querySimpan, conn)
            cmd.ExecuteNonQuery()

            MsgBox("Registrasi Berhasil! Silakan Login dengan akun barumu.", MsgBoxStyle.Information, "Sukses")

            ' Pindah ke Login
            LoginForm.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox("Gagal Daftar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' 3. Tombol BATAL (Button2)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm.Show()
        Me.Close()
    End Sub

End Class