Imports System

Module Program
    Sub Main()

        'variable added
        Dim Bil1 As Integer
        Dim Bil2 As Integer

        'print teks awal untuk inputan
        Console.Write("Masukan Bilangan Pertama :")
        Bil1 = Console.ReadLine()
        Console.Write("Masukan Bilangan Kedua :")
        Bil2 = Console.ReadLine()

        'REM Operator Aritmatika
        Console.WriteLine(Bil1 & " + " & Bil2 & ":" & Bil1 + Bil2.ToString())
        Console.WriteLine(Bil1 & " - " & Bil2 & ":" & Bil1 - Bil2.ToString())

        'Operator pembanding
        Console.WriteLine(Bil1 & " = " & Bil2 & ":" & (Bil1 = Bil2))
        Console.WriteLine(Bil1 & " <> " & Bil2 & ":" & (Bil1 <> Bil2))
    End Sub
End Module

