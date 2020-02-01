using System;
class Program
{
    static void Main(string[] args)
    {
        //--Program Faktorial

        //Deklarasi Variabel
        int angka;
        int hasil = 1;

        //Deklarasi Input
        String input;

        //--Membuat Judul Program
        System.Console.WriteLine("--Program Faktorial--\n");

        //Input Angka
        System.Console.Write("Masukkan Angka : ");
        input = Console.ReadLine();
        int.TryParse(input, out angka);

        System.Console.Write("Hasil faktorial dari " + angka + " adalah = ");
        //Proses dan output
        for (int x = 1; x <= angka; x++)
        {
            if (angka == 1)
            {
                System.Console.Write(hasil);
            }
            else
            {
                if (x == angka)
                {
                    System.Console.Write(x + " ");
                }
                else
                {
                    System.Console.Write(x + " * ");
                }
            }
            hasil = hasil * x;
        }
        System.Console.WriteLine("= " + hasil);
        System.Console.Write("\n--Program by Imamfh24--");
    }
}