Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim count As Integer = 0
        Dim str3 As String = ""
        Dim str4 As String = ""


        Console.Write(" Enter a string : ")
        str1 = Console.ReadLine
        Console.Write(" Enter another string : ")
        str2 = Console.ReadLine

        str3 = Mid(str1, 1, 2)
        str4 = Mid(str2, 1, 2)

        str1 = str4 & Mid(str1, 3, Len(str1))
        str2 = str3 & Mid(str2, 3, Len(str2))

        Console.Write("Your result is : " & str1 & " , " & str2)




        Console.ReadKey()
    End Sub

End Module
