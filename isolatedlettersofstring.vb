Module Module1



    Sub Main()

        Dim str1 As String = ""
        Dim char1 As Char = ""
        Dim count As Integer = 0
        Dim i As Integer = 1

        Console.Write(" Enter a string : ")
        str1 = Console.ReadLine()



        For count = 1 To Len(str1)

            char1 = Mid(str1, i, 1)

            i = i + 1

            Console.Write(char1 & " , ")

        Next


        Console.ReadKey()

    End Sub

End Module
