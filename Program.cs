using System;
class Program
{
    static void Main(string[] args)
    {
        //--Membuat program untuk menampilkan suatu bilangan dari 1 - bilangan yang diinputkan

        //Deklarasi Variabel
        int angka;

        //Deklarasi Input
        String input;

        //--Membuat Judul Program
        System.Console.WriteLine("--Program Perulangan Angka--");

        //Input Angka
        System.Console.Write("Masukkan Angka : ");
        input = Console.ReadLine();
        int.TryParse(input, out angka);

        //Proses dan output
        for (int x = 1; x <= angka; x++)
        {
            System.Console.Write(x + " ");
        }
        System.Console.WriteLine("\n--Program by Imamfh24--");
    }
}