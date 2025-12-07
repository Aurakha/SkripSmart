Imports System
Imports MySql.Data.MySqlClient

Public Module QuestionRenderer
    ' Load questions from tb_pertanyaan and render into a Panel.
    ' Assumes ModulKoneksi.conn is opened or call ModulKoneksi.BukaKoneksi() first.
    Public Sub LoadQuestions(panel As Panel, tingkat As String, Optional idProdi As Integer? = Nothing)
        panel.Controls.Clear()
        Try
            ModulKoneksi.BukaKoneksi()
            Dim sql As String = "SELECT id, pertanyaan, variabel FROM tb_pertanyaan WHERE tingkat=@t"
            If idProdi.HasValue Then sql &= " AND id_prodi=@p"
            sql &= " ORDER BY id"

            Using cmd As New MySqlCommand(sql, ModulKoneksi.conn)
                cmd.Parameters.AddWithValue("@t", tingkat)
                If idProdi.HasValue Then cmd.Parameters.AddWithValue("@p", idProdi.Value)

                Using dr = cmd.ExecuteReader()
                    Dim topPos = 10
                    While dr.Read()
                        Dim qid = dr("id").ToString()
                        Dim text = dr("pertanyaan").ToString()
                        Dim variabel = If(dr("variabel") Is DBNull.Value, "", dr("variabel").ToString())

                        Dim gb As New GroupBox()
                        gb.Text = text
                        gb.Tag = New QuestionMeta With {.QuestionId = qid, .VarName = variabel, .Weight = 1.0}
                        gb.Width = panel.Width - 25
                        gb.Left = 5
                        gb.Top = topPos
                        gb.Height = 60

                        ' create 5 radio buttons (1..5)
                        For i As Integer = 1 To 5
                            Dim rb As New RadioButton()
                            rb.Text = i.ToString()
                            rb.Tag = i
                            rb.Left = 10 + (i - 1) * 60
                            rb.Top = 20
                            gb.Controls.Add(rb)
                        Next

                        panel.Controls.Add(gb)
                        topPos += gb.Height + 10
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal load pertanyaan: " & ex.Message)
        End Try
    End Sub
End Module
