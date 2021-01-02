Module Module1

    Sub Main()

        Dim num1 As Integer = 0
        Dim num2 As Integer = 1
        Dim numnext As Integer = 0

        Console.WriteLine(num1)
        Console.WriteLine(num2)

        For count = 1 To 10

            numnext = num1 + num2
            num1 = num2
            num2 = numnext

            Console.WriteLine(numnext)
        Next

        Console.ReadKey()
    End Sub

End Module
