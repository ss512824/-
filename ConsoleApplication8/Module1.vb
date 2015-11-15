Module Module1

    Sub Main()
        Dim d, b As Integer
        Console.WriteLine("輸入有幾格數:")
        b = Val(Console.ReadLine())
        Dim q(b - 1) As Integer
        For d = 0 To q.GetUpperBound(0)
            Console.Write("第{0}個:", (d + 1).ToString())
            q(d) = Val(Console.ReadLine())
        Next
        Console.WriteLine("最大{0}", GetMax(q).ToString())
        Console.WriteLine("最小{0}", GetMin(q).ToString())
        Console.ReadLine()
    End Sub
    Function GetMax(ByVal ParamArray w() As Integer) As Integer
        Dim m As Integer
        m = w(0)
        For i As Integer = 1 To w.Length - 1
            If w(i) > m Then
                m = w(i)
            End If
        Next
        Return m
    End Function
    Function GetMin(ByVal ParamArray e() As Integer) As Integer
        Dim n As Integer
        n = e(0)
        For i As Integer = 1 To e.Length - 1
            If e(i) < n Then
                n = e(i)
            End If
        Next
        Return n
    End Function


End Module



