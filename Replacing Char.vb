Module Module1

    Sub Main()
        Dim String1 As String
        Dim String2 As String
        Dim Char1 As Char
        Dim Char2 As Char
        Dim NextChar As Char
        Dim Count As Integer

        String1 = ""
        String2 = ""
        Char1 = ""
        Char2 = ""
        NextChar = ""
        Count = 0

        Console.Write("Enter the string: ")
        String1 = Console.ReadLine

        Console.Write("Enter the character to remove: ")
        Char1 = Console.ReadLine

        Console.Write("Enter the characrer to remove with: ")
        Char2 = Console.ReadLine

        For Count = 1 To Len(String1)
            NextChar = Mid(String1, Count, 1)
            If NextChar = Char1 Then
                NextChar = Char2

            End If
            String2 = String2 & NextChar
        Next
        Console.Write("Your final text is " & String2)
        Console.ReadKey()

    End Sub

End Module
