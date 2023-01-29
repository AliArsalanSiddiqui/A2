Module Module1

    Sub Main()
        Dim NUM(5) As Integer
        Dim x, y, temp, n As Integer


        For x = 1 To 5
            NUM(x) = 0
        Next

        For x = 1 To 5
            Console.Write("Enter Value." & x & ":")
            temp = Console.ReadLine
            NUM(x) = temp
        Next
        n = 4
        For x = 1 To 4
            For y = 1 To n
                If NUM(y) > NUM(y + 1) Then
                    temp = NUM(y)
                    NUM(y) = NUM(y + 1)
                    NUM(y + 1) = temp
                End If
            Next
            n = n - 1
        Next
        For x = 1 To 5
            Console.WriteLine(NUM(x))
        Next
        Console.ReadKey()
    End Sub

End Module
