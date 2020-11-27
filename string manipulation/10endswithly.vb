Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim count As Integer = 0
        Dim nexts As Boolean = False

        Console.Write(" Enter a string : ")
        str1 = Console.ReadLine

        If Len(str1) > 3 And str1.EndsWith("ing") Then

            nexts = True  

        Else

            str1 = str1 & "ing"

            Console.Write("Your result is : " & str1)

            nexts = False

        End If


        If str1.EndsWith("ing") And nexts = True Then

            str1 = str1 & "ly"
            Console.Write("Your result is : " & str1)
        Else

            str1 = str1


        End If


        Console.ReadKey()


    End Sub

End Module
