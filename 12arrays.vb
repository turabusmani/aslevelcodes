Module Module1

    Sub Main()

        Dim arrname(4) As String
        Dim count As Integer = 0
        Dim len1 As Integer = 0
        Dim count2 As Integer = 0
        Dim char1 As Char = ""
        Dim char2 As Char = ""
        Dim count3 As Integer = 0

        arrname(1) = " Turab"
        arrname(2) = "Ali"
        arrname(3) = "z"
        arrname(4) = "bulb"

        For count = 1 To 4

            len1 = Len(arrname(count))
            If len1 >= 2 Then
                count2 = count2 + 1
            End If

        Next

        For count = 1 To 4

            len1 = Len(arrname(count))

            If len1 > 1 Then

                char1 = Mid(arrname(count), 1, 1)

                char2 = Mid(arrname(count), len1, 1)


            End If



            If char1 = char2 Then

                count3 = count3 + 1

            End If


        Next

        Console.WriteLine(count2)
        Console.Write(count3)
        Console.ReadKey()

    End Sub

End Module
