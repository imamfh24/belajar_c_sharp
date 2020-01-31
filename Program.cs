using System;
class Program
{
    static void Main(string[] args)
    {
        //----Program mencari Luas persegi panjang dengan input----

        //Deklarasi Variabel
        int p, l, L;

        //Deklarasi Variabel Input String
        /*Input pada C# menggunakan Console.ReadLine() yang bertipe string, maka diperlukan variabel input berupa string*/
        String input;

        //---Beri Judul Program---
        System.Console.WriteLine("---Program mencari Luas Persegi Panjang dengan input--- \n");

        //---Beri Statement Input---
        //Input Panjang

        System.Console.Write("Masukkan Panjang : ");
        input = Console.ReadLine();

        /*Karena inputan berupa integer, maka digunakan Tryparse yang statementnya
        tipedata.TryParse(variabelInputString, out namaVariabel);
        */
        int.TryParse(input, out p);

        //Input Lebar (lakukan hal yang sama dengan input panjang)

        System.Console.Write("Masukkan Lebar : ");
        input = Console.ReadLine();
        int.TryParse(input, out l);

        //Proses
        L = p * l;

        //Output
        System.Console.Write("Luas = " + L + "\n---Program By imamfh24---");
    }
}