Module Module1

    Sub Main()
        Dim str1 As String = ""
        Dim char1 As Char = ""
        Dim count As Integer = 0
        Dim count2 As Integer = 0

        Console.Write("Enter a string : ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)

            char1 = Mid(str1, count, 1)

            If char1 = "a" Or char1 = "e" Or char1 = "i" Or char1 = "o" Or char1 = "u" Then

                count2 = count2 + 1

            End If

        Next

        Console.Write("Number of vowels : " & count2)

        Console.ReadKey()
    End Sub

End Module
