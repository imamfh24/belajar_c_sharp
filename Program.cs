using System;
class Program
{
    static void Main(string[] args)
    {
        //----Program input nama depan dan belakang anda----

        //Deklarasi Variabel
        String nama;

        //Deklarasi Variabel Input String
        /*Input pada C# menggunakan Console.ReadLine() yang bertipe string, maka diperlukan variabel input berupa string*/
        String nama1, nama2;

        //---Beri Judul Program---
        System.Console.WriteLine("---Program menyambungkan nama anda--- \n");

        //---Beri Statement Input---
        //Input Nama Depan

        System.Console.Write("Masukkan Nama Depan anda : ");
        nama1 = Console.ReadLine();

        //Input Nama Belakang

        System.Console.Write("Masukkan Nama Belakang anda : ");
        nama2 = Console.ReadLine();

        /*Karena inputan string, maka tidak diperlukan Tryparse */

        //Proses
        nama = nama1 + " " + nama2;

        //Output
        System.Console.Write("Nama Saya adalah = " + nama + "\n---Program By imamfh24---");
    }
}