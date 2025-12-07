Imports System.IO

Public Class LoginNew
    Private Sub LoginNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = TextBox3.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim filePath As String = "users.txt"

        If Not File.Exists(filePath) Then
            MessageBox.Show("File user tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim loginSukses As Boolean = False

        For Each line As String In File.ReadAllLines(filePath)
            Dim data() As String = line.Split(";"c)

            If data.Length = 2 Then
                If data(0) = username AndAlso data(1) = password Then
                    loginSukses = True
                    Exit For
                End If
            End If
        Next

        If loginSukses Then
            MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Contoh berpindah form
            Dim frm As New Register()
            frm.Show()
            Me.Hide()

        Else
            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        ' Arahkan ke Form Register
        Dim frm As New FormRegister()
        frm.Show()
        Me.Hide()
    End Sub
End Class