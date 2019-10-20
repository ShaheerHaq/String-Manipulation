Module Module1

    Sub Main()
        Dim String1, Alphabets As String
        Dim Count As Integer
        Dim IsPangram As Boolean
        Dim NextChar As Char

        String1 = ""
        Alphabets = "abcdefghijklmnopqrstuvwxyz"
        Count = 0
        IsPangram = True
        NextChar = ""

        Console.Write("Enter the string: ")
        String1 = Console.ReadLine
        String1 = LCase(String1)

        For Count = 1 To Len(Alphabets)
            NextChar = Mid(Alphabets, Count, 1)
            If InStr(String1, NextChar) = 0 Then
                IsPangram = False
            End If
        Next
        If IsPangram = True Then
            Console.Write("It is a pangram")
        ElseIf IsPangram = False Then
            Console.Write("It is not a pangram")
        End If
        Console.ReadKey()

    End Sub

End Module
