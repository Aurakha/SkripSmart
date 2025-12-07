Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography ' <--- Tambahan Wajib 1
Imports System.Text ' <--- Tambahan Wajib 2

Module ModulKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public str As String

    Public Sub BukaKoneksi()
        Try
            str = "server=localhost;user id=root;password=;database=db_Sistempakar"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Bermasalah: " & ex.Message)
        End Try
    End Sub

    ' === FUNGSI TAMBAHAN UNTUK HASHING (SHA-256) ===
    Public Function BuatHash(ByVal text As String) As String
        Dim SHA256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(text)
        Dim hash As Byte() = SHA256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For Each b As Byte In hash
            stringBuilder.Append(b.ToString("x2"))
        Next

        Return stringBuilder.ToString()
    End Function

End Module