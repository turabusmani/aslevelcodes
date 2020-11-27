Module Module1

    Sub Main()

        ' Creating an array

        Dim arrlength As Integer = 0
        Dim charconv As Char = ""
        Dim charnum As Integer = 0
        Dim count As Integer = 0

        Console.Write(" Enter the lenght of the array : ")
        arrlength = Console.ReadLine

        Dim arrnum(arrlength) As Char

        For count = 1 To arrlength

            charconv = Chr(charnum)

            arrnum(count) = charconv

            charnum = charnum + 1
        Next

        ' Linear search algorithm

        Dim charfind As Char = ""


        Console.Write(" Enter a character to find : ")
        charfind = Console.ReadLine

        For count = 1 To arrlength

            If arrnum(count) = charfind Then

                Console.Write(" The character is at index position : " & count)


            End If


        Next

            Console.ReadKey()
    End Sub

End Module
