/*
made by: farah tsabitah aflah (2207111394)
*/

using System;

namespace soal_uts_1
{
    class Program
    {
        static string nama;
        static string nim;
        static string konsentrasi;

        static void Main(string[] args)
        {
            
            Console.Write("Nama: ");
            nama = Console.ReadLine();

            Console.Write("NIM: ");
            nim = Console.ReadLine();           

            Console.Write("Konsentrasi (RPL/KCV/Jaringan): ");
            konsentrasi = Console.ReadLine();

            printCard();
        }

        static void printCard()
        {
            Console.WriteLine("\n|***************************|");
            Console.WriteLine("|          NAMETAG          |");
            Console.WriteLine("|Nama: {0,21}|",nama);
            Console.WriteLine("|{0,27}|",nim);
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|{0,27}|",konsentrasi);
            Console.WriteLine("|***************************|");
        }
    }
}