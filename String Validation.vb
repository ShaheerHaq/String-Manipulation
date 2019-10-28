Module Module1

    Sub Main()
        Dim String1 As String
        Dim NextChar As Char
        Dim Count As Integer
        Dim IsValid As Boolean

        String1 = ""
        NextChar = ""
        Count = 0
        IsValid = True

        Console.Write("Enter a string in AAAA-999-aa format")
        String1 = Console.ReadLine

        If Len(String1) <> 11 Then
            IsValid = False
        End If

        If IsValid = True Then
            If Mid(String1, 5, 1) <> "-" Or Mid(String1, 9, 1) <> "-" Then
                IsValid = False
            End If
        End If

        If IsValid = True Then
            For Count = 1 To 4
                NextChar = Mid(String1, Count, 1)
                If NextChar < "A" Or NextChar > "Z" Then
                    IsValid = False
                    Exit For
                End If
            Next
        End If

        If IsValid = True Then
            For Count = 6 To 8
                NextChar = Mid(String1, Count, 1)
                If NextChar < "0" Or NextChar > "9" Then
                    IsValid = False
                    Exit For
                End If
            Next
        End If

        If IsValid = True Then
            For Count = 10 To 11
                NextChar = Mid(String1, Count, 1)
                If NextChar < "a" Or NextChar > "z" Then
                    IsValid = False
                    Exit For
                End If
            Next
        End If

        If IsValid = True Then
            Console.Write("It is a valid string")
        Else
            Console.Write("It is not a valid string")
        End If
        Console.ReadKey()

    End Sub


End Module
