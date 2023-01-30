Module Module1

    Dim Stack(4) As String
    Dim stackpt As Integer

    Sub Main()

        Push("Ali")
        Push("farhan")
        Push("umer")
        Push("ahad")
        Console.WriteLine("stack after push:")
        Showstack()
        Console.WriteLine()
        pop()
        Console.WriteLine()
        Console.WriteLine("stack after pop:")
        Showstack()
        Console.ReadKey()

    End Sub

    Sub Push(ByVal name As String)
        If stackpt > 4 Then
            Console.WriteLine("Stack overflow")
            Exit Sub
        End If
        stackpt = stackpt + 1
        Stack(stackpt) = name
    End Sub

    Sub pop()
        Console.WriteLine("The popped element is:" & Stack(stackpt))
        Stack(stackpt) = ""
        stackpt = stackpt - 1
    End Sub

    Sub Showstack()
        For x = 1 To 4
            Console.WriteLine(Stack(x))
        Next
    End Sub

End Module
