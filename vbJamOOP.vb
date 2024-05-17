Imports System


Module Program

    Sub main()
        Dim domestic As New indonesia
        Dim international As New english
        domestic.sore()
        international.malam()
    End Sub

    Public Interface sapaan
        Sub pagi()
        Sub sore()
        Sub malam()
    End Interface

    Public Class indonesia : Implements sapaan

        Public Sub pagi() Implements sapaan.pagi
            Console.WriteLine("selamat pagii")
        End Sub

        Public Sub sore() Implements sapaan.sore
            Console.WriteLine("selamat sore")
        End Sub

        Public Sub malam() Implements sapaan.malam
            Console.WriteLine("selamat malam")
        End Sub
    End Class
    Public Class english : Implements sapaan

        Public Sub pagi() Implements sapaan.pagi
            Console.WriteLine("good morning")
        End Sub

        Public Sub sore() Implements sapaan.sore
            Console.WriteLine("good evening")
        End Sub

        Public Sub malam() Implements sapaan.malam
            Console.WriteLine("good night")
        End Sub
    End Class
End Module
