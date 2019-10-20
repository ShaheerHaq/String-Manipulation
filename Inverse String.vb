Module Module1

    Sub Main()
        Dim String1 As String
        Dim String2 As String
        Dim NextChar As Char
        Dim Count As Integer

        String1 = ""
        String2 = ""
        NextChar = ""
        Count = 0

        Console.Write("Enter the string: ")
        String1 = Console.ReadLine

        For Count = Len(String1) To 1 Step -1
            NextChar = Mid(String1, Count, 1)
            String2 = String2 & NextChar
        Next
        Console.Write("Your inversed string is " & String2)
        Console.ReadKey()

    End Sub

End Module
