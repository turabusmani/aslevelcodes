Module Module1

    Sub Main()

        Dim char1 As Char = ""
        Dim charnum As Integer = 0

        Console.Write(" Enter a character : ")
        char1 = Console.ReadLine

        charnum = Asc(char1)

        Console.WriteLine(" The ascii code of the character is : " & charnum)


        Console.ReadKey()

    End Sub

End Module
