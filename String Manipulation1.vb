Module Module1

    Sub Main()
        Dim String1, String2 As String
        Dim NotChar, NextChar As Char
        Dim Count, NoOfChar As Integer

        String1 = ""
        String2 = ""
        NotChar = ""
        NextChar = ""
        Count = 0
        NoOfChar = 0

        Console.Write("Enter the String: ")
        String1 = Console.ReadLine
        NoOfChar = Len(String1)

        Console.Write("Enter which character to remove: ")
        NotChar = Console.ReadLine

        For Count = 1 To NoOfChar
            NextChar = Mid(String1, Count, 1)
            If NextChar <> NotChar Then
                String2 = String2 & NextChar
            End If
        Next
        Console.WriteLine("Your final text is: " & String2)
        Console.ReadKey()

    End Sub

End Module
