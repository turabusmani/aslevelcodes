Module Module1

    Sub Main()

        Dim count As Integer = 0

        Console.Write(" Enter the number of donuts : ")
        count = Console.ReadLine

        If count >= 10 Then

            Console.Write(" Number of donuts : many ")

        Else

            Console.WriteLine(" Number of donuts : " & count)

        End If


        Console.ReadKey()
    End Sub

End Module
