Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim str3 As String = ""
        Dim count As Integer = 0

        Console.Write(" Enter a string : ")
        str1 = Console.ReadLine

        If Len(str1) <= 2 Then

            str1 = ""
            Console.Write("Your result is: " & str1)

        Else

            str2 = Mid(str1, 1, 2)
            str3 = Mid(str1, Len(str1) - 1, 2)

            Console.WriteLine("Your result is : " & str2 & str3)

        End If


        Console.ReadKey()

    End Sub

End Module
