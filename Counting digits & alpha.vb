Module Module1

    Sub Main()
        Dim String1 As String
        Dim NextChar As Char
        Dim Count, Digit, Alpha As Integer

        String1 = ""
        NextChar = ""
        Count = 0
        Digit = 0
        Alpha = 0

        Console.Write("Enter the string: ")
        String1 = Console.ReadLine
        For Count = 1 To Len(String1)
            NextChar = Mid(String1, Count, 1)
            If NextChar >= "0" And NextChar <= "9" Then
                Digit = Digit + 1
            Else
                Alpha = Alpha + 1
            End If
        Next
        Console.WriteLine("No. of digits: " & Digit)
        Console.WriteLine("No. of alphabets: " & Alpha)
        Console.ReadKey()

    End Sub

End Module
