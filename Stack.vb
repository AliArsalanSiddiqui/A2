Module Module1
    Dim TopOfStack As Integer
    Dim stack(10) As String
    Dim item As String
    
    Sub Push(ByVal item As String)
        If TopOfStack < stack.Length - 1 Then
            TopOfStack = TopOfStack + 1
            stack(TopOfStack) = item
        Else
            Console.WriteLine("stack is full")
        End If
    End Sub

    Function pop()
        If TopOfStack = -1 Then
            Console.WriteLine("stack is empty")
        Else
            item = stack(TopOfStack)
            stack(TopOfStack) = ""
            TopOfStack = TopOfStack - 1
        End If
        Return Item
    End Function
    Sub Main()
        TopOfStack = -1
        
        'insert any name of your choice in Push()
        'push() can be called as many times as the index of the stack like in this case 10 times
        Call Push("umer")
        Call Push("Ali")
        Call Push("ahad")
        Call Push("Farhan")
        Call Push("Hasnain")
        Console.WriteLine("Stack after Push:")
        For x = 0 To 9
            Console.WriteLine(stack(x))
        Next
        
        'pop() can be called as many times as the index of the stack like in this case 10 times
        Call pop()
        Call pop()
        Call pop()
        Console.WriteLine("Stack after pop:")
        For x = 0 To 9
            Console.WriteLine(stack(x))
        Next

        Console.ReadKey()

    End Sub

End Module
