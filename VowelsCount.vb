Module Module1

    Sub Main()
        Dim String1, Vowels As String
        Dim NextChar, VChar As String
        Dim Count, Vcount, VowelsCount As Integer

        String1 = ""
        Vowels = "AEIOUaeiou"
        NextChar = ""
        VChar = ""
        Count = 0
        Vcount = 0
        VowelsCount = 0

        Console.Write("Enter the string: ")
        String1 = Console.ReadLine

        For Count = 1 To Len(String1)
            NextChar = Mid(String1, Count, 1)
            For Vcount = 1 To Len(Vowels)
                VChar = Mid(Vowels, Vcount, 1)
                If VChar = NextChar Then
                    VowelsCount = VowelsCount + 1
                End If
            Next
        Next
        Console.Write("No. of vowels in your string are: " & VowelsCount)
        Console.ReadKey()

    End Sub

End Module
