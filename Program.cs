using System;
class Program
{
    static void Main(string[] args)
    {
        //----Program Lampu lalu lintas----

        //Deklarasi Variabel
        string lampu;

        //---Beri Judul Program---
        System.Console.WriteLine("---Program Lampu lalu lintas--- \n");

        //---Beri Statement Input---
        //Input Tahun

        System.Console.Write("Masukkan Warna Lampu lalu lintas : ");
        lampu = Console.ReadLine();

        //Proses dan output
        if (lampu.Equals("merah", StringComparison.InvariantCultureIgnoreCase))
        {
            System.Console.WriteLine("Berhenti");
        }
        else if (lampu.Equals("kuning", StringComparison.InvariantCultureIgnoreCase))
        {
            System.Console.WriteLine("Bersiap");
        }
        else if (lampu.Equals("hijau", StringComparison.InvariantCultureIgnoreCase))
        {
            System.Console.WriteLine("Jalan");
        }
        else
        {
            System.Console.WriteLine("Warna " + lampu + " bukan warna lampu lalu lintas");
        }

        //Output
        System.Console.Write("\n---Program By imamfh24---");
    }
}