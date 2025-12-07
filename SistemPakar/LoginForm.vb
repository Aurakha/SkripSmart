Imports MySql.Data.MySqlClient

Public Class LoginForm
    ' Variabel publik untuk menyimpan id akun yang login
    Public Property IdAkunAktif As Integer = 0

    ' 1. Saat Form Login Dibuka
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Normal
        BukaKoneksi()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub

    ' 2. Tombol LOGIN (Dengan Pencocokan Hash)
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Cek input kosong
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password wajib diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' === A. PROSES HASHING INPUT USER ===
            ' User ngetik "123" -> Kita ubah jadi hash dulu
            Dim passwordInputHash As String = BuatHash(txtPassword.Text)

            ' === B. CEK KE DATABASE ===
            ' Bandingkan Username DAN Password Hash
            Dim query As String = "SELECT * FROM tb_akun WHERE username='" & txtUsername.Text & "' AND password='" & passwordInputHash & "'"
            cmd = New MySqlCommand(query, conn)

            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                ' === LOGIN SUKSES ===
                MsgBox("Login Berhasil! Selamat Datang, " & txtUsername.Text, MsgBoxStyle.Information, "Sukses")

                ' Ambil id_akun dari hasil query
                If Not IsDBNull(dr("id_akun")) Then
                    IdAkunAktif = Convert.ToInt32(dr("id_akun"))
                Else
                    IdAkunAktif = 0
                End If

                ' Sembunyikan Login, Buka Menu Utama
                Me.Hide()
                Dashboard.Show()
            Else
                ' === LOGIN GAGAL ===
                MsgBox("Username atau Password Salah!", MsgBoxStyle.Critical, "Gagal Login")
                txtPassword.Text = ""
                txtPassword.Focus()
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox("Error Database: " & ex.Message)
        End Try
    End Sub

    ' 3. Tombol BATAL / KELUAR
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Application.Exit()
    End Sub

    ' 4. Tombol DAFTAR (Pindah ke Form Register)
    ' Pastikan kamu sudah buat tombol/link label buat daftar di desain Login
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Register.Show()
        Me.Hide()
    End Sub

    ' 5. Fitur Enter Langsung Login
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint

    End Sub
End Class