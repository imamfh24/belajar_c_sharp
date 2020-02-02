using System;
class Program
{
    static void Main(string[] args)
    {
        //--Program Array 1 Dimensi

        //Judul Program
        System.Console.WriteLine("--Random Angka--");

        //Input String
        String input;

        //Statement
        System.Console.Write("Masukkan banyak angka yang akan dirandom : ");
        input = Console.ReadLine();
        int.TryParse(input, out int angka);

        //Deklarasi Variabel Array
        // Rumus deklarasi variabel array yaitu tipedata[] namavariabel = new tipedata[jumlah array];
        int[] loker = new int[angka];

        //Fungsi random angka
        int random;
        Random rnd = new Random();

        for (int x = 0; x < loker.Length; x++)
        {
            random = rnd.Next(1, angka);
            loker[x] = random;
            System.Console.Write(loker[x] + " ");
        }
    }
}