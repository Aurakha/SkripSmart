Imports MySql.Data.MySqlClient

Public Class FormRegister

    ' 1. Saat Form Dibuka
    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaKoneksi()
        txtUsername.Focus()
    End Sub

    ' 2. Tombol DAFTAR (Dengan Hashing)
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        ' A. Validasi Input Kosong
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtKonfirmasi.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        ' B. Validasi Password Sama
        If txtPassword.Text <> txtKonfirmasi.Text Then
            MsgBox("Password dan Ulangi Password tidak cocok!", MsgBoxStyle.Critical, "Error")
            txtPassword.Text = ""
            txtKonfirmasi.Text = ""
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' C. Cek Duplikat Username (Biar gak ada user kembar)
            Dim queryCek As String = "SELECT * FROM tb_akun WHERE username='" & txtUsername.Text & "'"
            cmd = New MySqlCommand(queryCek, conn)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MsgBox("Username '" & txtUsername.Text & "' sudah dipakai! Silakan pilih username lain.", MsgBoxStyle.Exclamation, "Gagal")
                dr.Close()
                txtUsername.Focus()
                Exit Sub
            End If
            dr.Close()

            ' === D. PROSES HASHING & SIMPAN ===
            ' Password asli diubah jadi Hash SHA-256
            Dim passwordAman As String = BuatHash(txtPassword.Text)

            ' Simpan Username dan Password Hash ke Database
            Dim querySimpan As String = "INSERT INTO tb_akun (username, password) VALUES ('" & txtUsername.Text & "', '" & passwordAman & "')"

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

    ' 3. Tombol KEMBALI (Ke Login)
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint

    End Sub
End Class