using System;
class Program
{
    static void Main(string[] args)
    {
        //----Program menentukan bilangan ganjil genap----

        //Deklarasi Variabel
        int angka;

        //Deklarasi Variabel Input String
        /*Input pada C# menggunakan Console.ReadLine() yang bertipe string, maka diperlukan variabel input berupa string*/
        String nama1, nama2;

        //---Beri Judul Program---
        System.Console.WriteLine("---Program menentukan bilangan ganjil genap--- \n");

        //---Beri Statement Input---
        //Input Nama Depan

        System.Console.Write("Masukkan Angka : ");
        input = Console.ReadLine();

        /*Karena inputan berupa integer, maka digunakan Tryparse yang statementnya
        tipedata.TryParse(variabelInputString, out namaVariabel);
        */
        int.TryParse(input, out angka);

        //Proses dan output
        if (angka % 2 == 0)
        {
            System.Console.WriteLine("Angka " + angka + " merupakan angka Genap");
        }
        else
        {
            System.Console.WriteLine("Angka " + angka + " merupakan angka Ganjil");
        }

        //Output
        System.Console.Write("\n---Program By imamfh24---");
    }
}