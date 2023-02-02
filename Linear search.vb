Module Module1
    Dim Search(5) As String
    Dim DatatobeFound As String
    Dim index As Integer
    Dim found As Boolean
    Sub Main()
        For x = 1 To 5
            Console.WriteLine("Enter Data " & x & ":")
            Search(x) = Console.ReadLine
        Next
        Console.WriteLine()
        Console.WriteLine("Enter Data to search:")
        DatatobeFound = Console.ReadLine()
        Console.WriteLine()
        Do While index < 6
            If Search(index) = DatatobeFound Then
                found = True
                Exit Do
            Else
                found = False
            End If
            index = index + 1
        Loop
        If found = True Then
            Console.WriteLine("Data found at index: " & index)
        Else
            Console.WriteLine("Data not found")
        End If
        Console.ReadKey()

    End Sub

End Module
