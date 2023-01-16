Imports System

Module Program
    Sub Main(args As String())
        Const ULOGMAX As ULong = 18446744073709551615UL
        Console.Write("Я умею считать факториал. Введите число N: ")
    Dim N As Integer, F As ULong
        F = 1
        N = CInt(Console.ReadLine())
        For i = 1 To N 
            If (F < ULOGMAX / I) Then
            F = F * i
                Else 
                    Console.Write("Переполнение памяти. Расчет выполнен для N=")
                    Console.WriteLine(i - 1)
                    Exit For
                    End If
        Next
        Console.Write("N!=")
        Console.WriteLine(F)
        End Sub
End Module
