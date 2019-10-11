Module Module1

    Sub Main()
        Dim String1, String2, FinalText, FirstWord, SecondWord As String
        Dim SpacePos As Integer

        String1 = ""
        String2 = ""
        FinalText = ""
        FirstWord = ""
        SecondWord = ""
        SpacePos = 0

        Console.Write("Enter Stiring 1: ")
        String1 = Console.ReadLine
        SpacePos = InStr(String1, " ")
        FirstWord = Left(String1, SpacePos - 1)

        Console.Write("Enter String 2: ")
        String2 = Console.ReadLine
        SpacePos = InStr(String2, " ")
        SecondWord = Right(String2, Len(String2) - SpacePos)

        FinalText = FirstWord & " " & SecondWord
        Console.WriteLine("Your final text is: " & FinalText)
        Console.ReadKey()



    End Sub

End Module
