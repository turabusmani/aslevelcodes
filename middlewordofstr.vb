Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim myword As String = ""
        Dim first_space As Integer = 0
        Dim second_space As Integer = 0


        Console.Write(" Enter a 3 word name : ")
        str1 = Console.ReadLine


        first_space = InStr(str1, " ")
        second_space = InStr(first_space + 1, str1, " ")


        myword = Mid(str1, first_space, second_space - first_space)

        Console.Write(" Your result is : ")
        Console.WriteLine(myword)
       
        Console.ReadKey()
    End Sub

End Module
