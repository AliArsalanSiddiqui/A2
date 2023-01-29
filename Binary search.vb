Module Module1

    Sub Main()
        Dim namesArr(5) As String
        Dim sName As String
        Dim a As Integer
        Dim isFound As Boolean
        Dim lb, ub, m As Integer
        lb = 0
        ub = 5
        isFound = False

        'Initialisation
        For a = 0 To 5
            namesArr(a) = ""
        Next

        'populate
        For a = 0 To 5
            Console.Write("Enter name " & a & ":" & " ")
            sName = Console.ReadLine
            namesArr(a) = sName
        Next

        'output all
        For a = 0 To 5
            Console.WriteLine(namesArr(a))
        Next

        'searching
        Console.Write("Enter Name to search for: ")
        sName = Console.ReadLine
        While lb <= ub And isFound = False
            m = (lb + ub) \ 2 '\ is DIV function in VB
            If sName = namesArr(m) Then
                isFound = True
            End If
            If sName < namesArr(m) Then
                ub = m - 1
            End If
            If sName > namesArr(m) Then
                lb = m + 1
            End If
        End While
        If isFound = False Then
            Console.WriteLine("Name was not found.")
        Else
            Console.WriteLine("Name found.")
        End If
        Console.WriteLine("Location name found at is: " & m)
        Console.ReadKey()


    End Sub

End Module
