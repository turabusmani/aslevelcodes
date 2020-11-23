Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim char1 As Char = ""
        Dim char2 As Char = ""
        Dim char3 As Char = ""
        Dim count As Integer = 0
        Dim count2 As Integer = 0
        Dim count3 As Integer = 0
        Dim high As Integer = 0

        Console.Write(" Enter a string : ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)

            char1 = Mid(str1, count, 1)

            count3 = 0

            For count2 = 1 To Len(str1)

                char2 = Mid(str1, count2, 1)

                If char2 = char1 Then count3 = count3 + 1

            Next


            If count3 > high Then

                high = count3
                char3 = char1

            End If

        Next

        Console.Write(" The most repeated character is : " & char3 & " and it appeared " & high & " number of times ")


        Console.ReadKey()

    End Sub

End Module
