using System;
class Program
{
    static void Main(string[] args)
    {
        //----Program mencari Luas Lingkaran dengan input jari-jari lingkaran----

        //Deklarasi Variabel
        //Karena phi merupakan variabel yang tidak akan pernah berubah, maka digunakan konstanta
        const double phi = 3.14;
        double r, L;

        //Deklarasi Variabel Input String
        /*Input pada C# menggunakan Console.ReadLine() yang bertipe string, maka diperlukan variabel input berupa string*/
        String input;

        //---Beri Judul Program---
        System.Console.WriteLine("---Program mencari Luas Lingkaran dengan input jari-jari lingkaran--- \n");

        //---Beri Statement Input---
        //Input Jari-Jari

        System.Console.Write("Masukkan Jari-Jari Lingkaran : ");
        input = Console.ReadLine();

        /*Karena inputan yang kemungkinan ada berupa double, maka digunakan Tryparse yang statementnya
        tipedata.TryParse(variabelInputString, out namaVariabel);
        */
        double.TryParse(input, out r);

        //Proses
        L = phi * (r * r);

        //Output
        System.Console.Write("Luas = " + L + "\n---Program By imamfh24---");
    }
}