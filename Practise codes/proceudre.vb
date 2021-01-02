Module Module1

    Sub multpileofseven()

        Dim num1 As Integer = 0
        Dim remainder As Integer = 0

        Console.Write(" Enter a number : ")
        num1 = Console.ReadLine

        If remainder = num1 Mod 7 = 0 Then

            Console.Write(" The number is not a multiple of 7 . ")

        ElseIf remainder = num1 Mod 7 <> 0 Then

            Console.Write(" The number is multiple of 7 . ")

        End If


    End Sub

    Sub Main()

        multpileofseven()
        Console.ReadKey()


    End Sub

End Module
