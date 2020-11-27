Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim str_og As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim char1 As Char = ""
        Dim count As Integer = 0
        Dim char2 As Char = ""

        Console.Write("Enter a string : ")
        str1 = Console.ReadLine
        str1 = UCase(str1)


        For count = 1 To Len(str_og)

            char1 = Mid(str_og, count, 1)

            If InStr(str1, char1) = 0 Then

                char2 = "Y"

            End If


        Next

        If char2 = "Y" Then

            Console.Write(" The string is not a pangram")
        Else
            Console.Write(" The string is  a pangram")

        End If
        Console.ReadKey()


    End Sub

End Module
