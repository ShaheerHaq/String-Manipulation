Module Module1

    Sub Main()
        Dim NextChar, NextChar1 As Char
        Dim Count, Counter, Sum, Value As Integer
        Dim validBinaryString As Boolean
        Dim BinaryNum As String

        NextChar = ""
        NextChar1 = ""
        Count = 0
        Counter = 0
        Sum = 0
        Value = 0
        validBinaryString = True
        BinaryNum = ""

        Console.Write("Enter the binary number between 1 to 8 digits")
        BinaryNum = Console.ReadLine
        If Len(BinaryNum) < 1 Or Len(BinaryNum) > 8 Then
            Console.Write("Not a valid string...")
            validBinaryString = False
        End If
        If validBinaryString = True Then
            For Count = 1 To Len(BinaryNum)
                NextChar = Mid(BinaryNum, Count, 1)
                If NextChar <> "0" And NextChar <> "1" Then
                    Console.Write("Not a valid string....")
                    validBinaryString = False
                    Exit For
                End If
            Next
        End If
        For Counter = 1 To Len(BinaryNum)
            NextChar1 = Right(BinaryNum, Counter)
            If NextChar1 = "1" Then
                Value = 2 ^ (Counter - 1)
                Sum = Sum + Value
            End If
        Next
        Console.Write("Denary equivalent to your binary number is " & Sum)
        Console.ReadKey()

    End Sub

End Module
