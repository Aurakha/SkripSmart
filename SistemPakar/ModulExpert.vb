Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class QuestionMeta
    Public Property QuestionId As String
    Public Property VarName As String
    Public Property Weight As Double = 1.0
End Class

Public Class Condition
    Public Property VarName As String
    Public Property MinValue As Double? = Nothing
    Public Property MaxValue As Double? = Nothing
End Class

Public Class Rule
    Public Property Prodi As String
    Public Property Conditions As List(Of Condition)
    Public Sub New()
        Conditions = New List(Of Condition)()
    End Sub
End Class

Public Module ModulExpert
    ' Mengumpulkan jawaban dari panel yang berisi GroupBox per pertanyaan
    Public Function AggregateAnswers(pnl As Panel) As Dictionary(Of String, List(Of Double))
        Dim map As New Dictionary(Of String, List(Of Double))(StringComparer.OrdinalIgnoreCase)

        For Each ctrl As Control In pnl.Controls
            Dim gb = TryCast(ctrl, GroupBox)
            If gb Is Nothing Then Continue For

            Dim metaObj = gb.Tag
            If metaObj Is Nothing Then Continue For
            Dim meta = TryCast(metaObj, QuestionMeta)
            If meta Is Nothing Then Continue For

            Dim value As Double = 0
            For Each c As Control In gb.Controls
                Dim rb = TryCast(c, RadioButton)
                If rb IsNot Nothing AndAlso rb.Checked Then
                    If rb.Tag IsNot Nothing Then
                        Try
                            value = Convert.ToDouble(rb.Tag)
                        Catch ex As Exception
                            value = 0
                        End Try
                    End If
                    Exit For
                End If
            Next

            If Not map.ContainsKey(meta.VarName) Then
                map(meta.VarName) = New List(Of Double)()
            End If
            map(meta.VarName).Add(value * meta.Weight)
        Next

        Return map
    End Function

    ' Hitung rata-rata sederhana per variable
    Public Function ComputeAverages(agg As Dictionary(Of String, List(Of Double))) As Dictionary(Of String, Double)
        Dim res As New Dictionary(Of String, Double)(StringComparer.OrdinalIgnoreCase)
        For Each kvp In agg
            Dim list = kvp.Value
            If list Is Nothing OrElse list.Count = 0 Then
                res(kvp.Key) = 0
            Else
                res(kvp.Key) = list.Sum() / list.Count
            End If
        Next
        Return res
    End Function

    ' Evaluasi rules: kembalikan nama prodi pertama yang cocok
    Public Function EvaluateRules(averages As Dictionary(Of String, Double), rules As List(Of Rule)) As String
        If rules IsNot Nothing Then
            For Each rule In rules
                Dim ok As Boolean = True
                For Each cond In rule.Conditions
                    Dim val As Double = 0
                    If averages.ContainsKey(cond.VarName) Then val = averages(cond.VarName)
                    If cond.MinValue.HasValue AndAlso val < cond.MinValue.Value Then ok = False : Exit For
                    If cond.MaxValue.HasValue AndAlso val > cond.MaxValue.Value Then ok = False : Exit For
                Next
                If ok Then
                    Return rule.Prodi
                End If
            Next
        End If

        ' fallback: pilih variabel dengan nilai tertinggi
        If averages Is Nothing OrElse averages.Count = 0 Then Return "Tidak ada rekomendasi"
        Dim best = averages.OrderByDescending(Function(x) x.Value).First()
        Return String.Format("Rekomendasi berdasarkan variabel: {0} (score={1:0.##})", best.Key, best.Value)
    End Function

    ' Contoh rules statis — Anda bisa memuat dari DB nanti
    Public Function GetDefaultRules() As List(Of Rule)
        Dim list As New List(Of Rule)()

        Dim r1 As New Rule()
        r1.Prodi = "TI"
        r1.Conditions.Add(New Condition With {.VarName = "A", .MinValue = 4})
        r1.Conditions.Add(New Condition With {.VarName = "C", .MinValue = 3.5})
        list.Add(r1)

        Dim r2 As New Rule()
        r2.Prodi = "TMD"
        r2.Conditions.Add(New Condition With {.VarName = "K", .MinValue = 4})
        list.Add(r2)

        Dim r3 As New Rule()
        r3.Prodi = "TMJ"
        r3.Conditions.Add(New Condition With {.VarName = "H", .MinValue = 4})
        list.Add(r3)

        Return list
    End Function

    ' ---------------------- Additional helpers from previous implementation ----------------------
    Private Function Avg(list As List(Of Integer)) As Double
        If list Is Nothing OrElse list.Count = 0 Then Return 0
        Dim sum As Integer = 0
        For Each v In list
            sum += v
        Next
        Return sum / CDbl(list.Count)
    End Function

    Private Function Level(x As Double) As String
        If x >= 4 Then
            Return "high"
        ElseIf x >= 3 Then
            Return "med"
        Else
            Return "low"
        End If
    End Function

    ' generalAnswers: qid -> 1..5
    Public Function DetermineProdi(ByVal generalAnswers As Dictionary(Of String, Integer)) As Tuple(Of String, Dictionary(Of String, Double))
        Dim varsScores As New Dictionary(Of String, List(Of Integer)) From {
            {"A", New List(Of Integer)()},
            {"C", New List(Of Integer)()},
            {"K", New List(Of Integer)()},
            {"H", New List(Of Integer)()}
        }

        ' Map answers into variable buckets.
        For Each kvp In generalAnswers
            Dim qid As String = kvp.Key
            Dim val As Integer = kvp.Value
            If qid.StartsWith("A") Then varsScores("A").Add(val) : Continue For
            If qid.StartsWith("C") Then varsScores("C").Add(val) : Continue For
            If qid.StartsWith("K") Then varsScores("K").Add(val) : Continue For
            If qid.StartsWith("H") Then varsScores("H").Add(val) : Continue For

            Dim parts() As String = qid.Split("_"c)
            If parts.Length > 1 Then
                Dim suffix As String = parts(parts.Length - 1).ToUpper()
                If varsScores.ContainsKey(suffix) Then
                    varsScores(suffix).Add(val)
                    Continue For
                End If
            End If

            varsScores("A").Add(val)
        Next

        Dim varAvg As New Dictionary(Of String, Double)
        varAvg("A") = Avg(varsScores("A"))
        varAvg("C") = Avg(varsScores("C"))
        varAvg("K") = Avg(varsScores("K"))
        varAvg("H") = Avg(varsScores("H"))

        Dim A_l As String = Level(varAvg("A"))
        Dim C_l As String = Level(varAvg("C"))
        Dim K_l As String = Level(varAvg("K"))
        Dim H_l As String = Level(varAvg("H"))

        If A_l = "high" AndAlso C_l = "high" AndAlso K_l = "low" Then
            Return Tuple.Create("TI", varAvg)
        End If

        If H_l = "high" AndAlso A_l = "med" AndAlso C_l = "med" Then
            Return Tuple.Create("TMJ", varAvg)
        End If

        If K_l = "high" AndAlso (A_l = "low" OrElse A_l = "med") Then
            Return Tuple.Create("TMD", varAvg)
        End If

        Dim topVar As String = "A"
        Dim maxVal As Double = varAvg("A")
        For Each kv In varAvg
            If kv.Value > maxVal Then
                maxVal = kv.Value
                topVar = kv.Key
            End If
        Next

        Dim mapping As New Dictionary(Of String, String) From {{"A", "TI"}, {"C", "TI"}, {"K", "TMD"}, {"H", "TMJ"}}
        Dim mapped As String = "TI"
        If mapping.ContainsKey(topVar) Then mapped = mapping(topVar)

        Return Tuple.Create(mapped, varAvg)
    End Function

    ' EvaluateFields: simple average-based ranking
    ' specificMap: Dictionary field -> List(Of qid)
    ' specificAnswers: qid->score
    Public Function EvaluateFields(ByVal specificMap As Dictionary(Of String, List(Of String)), ByVal specificAnswers As Dictionary(Of String, Integer)) As List(Of KeyValuePair(Of String, Double))
        Dim scores As New Dictionary(Of String, Double)
        For Each field In specificMap.Keys
            Dim qlist = specificMap(field)
            Dim s As Double = 0
            Dim cnt As Integer = 0
            For Each qid In qlist
                If specificAnswers.ContainsKey(qid) Then
                    s += specificAnswers(qid)
                    cnt += 1
                End If
            Next
            Dim avgScore As Double = If(cnt > 0, s / cnt, 0)
            scores(field) = avgScore
        Next

        Dim ranked = New List(Of KeyValuePair(Of String, Double))(scores)
        ranked.Sort(Function(a, b) b.Value.CompareTo(a.Value))
        Return ranked
    End Function
End Module
