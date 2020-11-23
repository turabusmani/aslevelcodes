Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim char1 As Char = ""
        Dim char2 As Char = ""
        Dim count As Integer = 0

        Console.Write(" Enter a string : ")
        str1 = Console.ReadLine

        char1 = Mid(str1, 1, 1)

        Console.Write(char1)

        For count = 1 To Len(str1)

            char2 = Mid(str1, count + 1, 1)



            If char2 = char1 Then

                char2 = "*"
                Console.Write(char2)
            Else

                Console.Write(char2)


            End If




        Next



        Console.ReadKey()

    End Sub

End Module
