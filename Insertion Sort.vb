Module Module1
    Dim Score(8) As Integer
    Dim arraysize, Temp, Position As Integer

    Sub Main()

        arraysize = 8

        For x = 1 To 8
            Console.WriteLine("Enter Number" & " " & x & ":")
            Score(x) = Console.ReadLine
        Next

        Console.WriteLine()
        ShowUnsortedArray()

    For Pointer = 1 To 8
        Temp = Score(Pointer)
        Position = Pointer  
            Do While (Position > 1) And (Score(Position - 1) > Temp) ' ">" will sort in ascending order while "<" will sort in descending order
                Score(Position) = Score(Position - 1)
                Score(Position - 1) = Temp
                Position = Position - 1
            Loop
        Next

        Console.WriteLine()
        ShowSortedArray()
        Console.ReadKey()

    End Sub

    Sub ShowSortedArray()

        Console.WriteLine("Sorted array :")
        For x = 1 To 8
            Console.WriteLine(Score(x))
        Next

    End Sub

    Sub ShowUnsortedArray()

        Console.WriteLine("Unsorted array :")
        For x = 1 To 8
            Console.WriteLine(Score(x))
        Next

    End Sub

End Module
