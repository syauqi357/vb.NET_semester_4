Imports System
Imports System.Runtime.InteropServices

Module Program
    Sub Main()

        'variabel statement
        Dim NIM As Integer
        Dim nama As String
        Dim tmp_lhr As String
        Dim dateBirth As Date
        Dim address As String
        Dim fakultas As String
        Dim statusSocial As String

        'input dan data di masukkan

        'mencetak tulisan di console terminal
        Console.WriteLine("masukkan NIM anda :")
        'variabel di indikasi kan sebagai input
        NIM = Console.ReadLine()
        'menghilangkan teks agar langsung berganti ke statement berikut nya
        Console.Clear()


        Console.WriteLine("masukkan nama anda:")
        nama = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("masukkan tempat lahir anda :")
        tmp_lhr = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("masukkan tanggal lahir anda:")
        dateBirth = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("masukkan alamat rumah anda :")
        address = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("masukkan fakultas anda :")
        fakultas = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("apakah anda sudah menikah? :")
        statusSocial = Console.ReadLine()
        Console.Clear()


        'data di cetak dan di sebutkan dalam console
        Console.WriteLine("NIM anda adalah" & vbTab & NIM)
        Console.WriteLine("nama anda adalah" & vbTab & nama)
        Console.WriteLine("tempat tanggal lahir anda adalah" & vbTab & tmp_lhr & "," & dateBirth.ToString())
        Console.WriteLine("Alamat anda adalah" & vbTab & address)
        Console.WriteLine("saat ini anda berada di fakultas" & vbTab & fakultas)



    End Sub
End Module
