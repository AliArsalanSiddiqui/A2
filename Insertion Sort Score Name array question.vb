Module Module1
    Dim Score(5) As Integer
    Dim Name(0 To 5, 2) As String
    Dim Temp1, Position As Integer
    Dim Temp2, Temp3 As String
    Sub Main()

        For x = 1 To 5
            Console.Write("Enter Number " & x & ": ")
            Score(x) = Console.ReadLine
            Console.Write("Enter FirstName " & x & ": ")
            Name(x, 1) = Console.ReadLine
            Console.Write("Enter LastName " & x & ": ")
            Name(x, 2) = Console.Read
        Next

        Console.WriteLine()
        ShowUnsortedScore()

        For Pointer = 1 To 5
            Temp1 = Score(Pointer)
            Temp2 = Name(Pointer, 1)
            Temp3 = Name(Pointer, 2)
            Position = Pointer
            Do While (Position > 1) And (Score(Position - 1) > Temp1)
                Score(Position) = Score(Position - 1)
                Score(Position - 1) = Temp1
                Name(Position, 1) = Name(Position - 1, 1)
                Name(Position - 1, 1) = Temp2
                Name(Position, 2) = Name(Position - 1, 2)
                Name(Position - 1, 2) = Temp3
                Position = Position - 1
            Loop
        Next

        Console.WriteLine()
        ShowSortedScore()
        Console.ReadKey()

    End Sub

    Sub ShowUnsortedScore()
        Console.WriteLine("Unsorted Score with their corresponding first and last names:")
        For x = 1 To 5
            Console.WriteLine(Score(x) & ":" & Name(x, 1) & ":" & Name(x, 2))
        Next
    End Sub

    Sub ShowSortedScore()
        Console.WriteLine("sorted Score with their corresponding first and last names:")
        For x = 1 To 5
            Console.WriteLine(Score(x) & ":" & Name(x, 1) & ":" & Name(x, 2))
        Next
    End Sub

End Module
