Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim count As Integer = 0
        Dim char1 As Char = ""
        Dim charnum As Integer = 0
        Dim len1 As Integer = 0
        Dim charsum As Integer = 0
        Dim charsum2 As Integer = 0

        Console.Write(" Enter a string : ")
        str1 = Console.ReadLine

        Console.Write(" Enter another string : ")
        str2 = Console.ReadLine

   

        For count = 1 To Len(str1)

            char1 = Mid(str1, 1 + len1, 1)
            len1 = len1 + 1

            charnum = Asc(char1)
            Charsum = charnum + charsum

        Next

        len1 = 0

        For count = 1 To Len(str2)

            char1 = Mid(str2, 1 + len1, 1)
            len1 = len1 + 1

            charnum = Asc(char1)
            charsum2 = charnum + charsum2

        Next

        If Len(str1) = Len(str2) And charsum = charsum2 Then

            Console.WriteLine(" The strings are an anagram ")

        Else

            Console.WriteLine(" The strings are not an anagram ")

        End If


        Console.ReadKey()







    End Sub

End Module
