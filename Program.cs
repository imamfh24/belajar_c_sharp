using System;
class Program
{
    static void Main(string[] args)
    {
        //--Program menampilkan bilangan ganjil

        //Deklarasi Variabel
        int angka;

        //Deklarasi Input
        String input;

        //--Membuat Judul Program
        System.Console.WriteLine("--Program Menampilkan Bilangan Ganjil--");

        //Input Angka
        System.Console.Write("Masukkan Angka : ");
        input = Console.ReadLine();
        int.TryParse(input, out angka);

        System.Console.Write("Angka Ganjil : ");
        //Proses dan output
        for (int x = 1; x <= angka; x++)
        {
            if (x % 2 != 0)
            {
                System.Console.Write(x + " ");
            }
        }
        System.Console.WriteLine("\n--Program by Imamfh24--");
    }
}