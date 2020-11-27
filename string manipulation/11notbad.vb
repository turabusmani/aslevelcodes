Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim not1 As Integer = 0
        Dim bad1 As Integer = 0


        Console.Write(" Enter a string : ")
        str1 = Console.ReadLine

        not1 = InStr(str1, "not")
        bad1 = InStr(str1, "bad")


        str1 = Mid(str1, 1, not1 - 1) & "goo" & Mid(str1, bad1 + 2, Len(str1) - bad1)

        Console.Write(" The corrected string is : " & str1)

        Console.ReadKey()
    End Sub

End Module
