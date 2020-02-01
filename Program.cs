using System;
class Program
{
    static void Main(string[] args)
    {
        //----Program menentukan tahun kabisat----

        //Deklarasi Variabel
        int angka;

        //Deklarasi Variabel Input String
        /*Input pada C# menggunakan Console.ReadLine() yang bertipe string, maka diperlukan variabel input berupa string*/
        String input;

        //---Beri Judul Program---
        System.Console.WriteLine("---Program menentukan tahun kabisat--- \n");

        //---Beri Statement Input---
        //Input Tahun

        System.Console.Write("Masukkan Tahun : ");
        input = Console.ReadLine();

        /*Karena inputan berupa integer, maka digunakan Tryparse yang statementnya
        tipedata.TryParse(variabelInputString, out namaVariabel);
        */
        int.TryParse(input, out angka);

        //Proses dan output
        //1 Cek dulu, pastikan inputan tidak menginput angka 0
        if (angka == 0)
        {
            System.Console.WriteLine("Mohon masukkan tahun dengan benar");
        }
        else
        {
            if (angka % 4 == 0 || angka % 400 == 0)
            {
                System.Console.WriteLine(angka + " merupakan tahun kabisat");
            }
            else
            {
                System.Console.WriteLine(angka + " Bukan tahun kabisat");
            }
        }

        //Output
        System.Console.Write("\n---Program By imamfh24---");
    }
}