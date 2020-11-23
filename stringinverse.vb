Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim len1 As Integer = 0

        Console.Write(" Enter a string to be reversed : ")
        str1 = Console.ReadLine()

        For count = 1 To Len(str1)

            str2 = Mid(str1, Len(str1) + len1, 1)

            len1 = len1 - 1

            Console.Write(str2)

        Next

        Console.ReadKey()

    End Sub

End Module
