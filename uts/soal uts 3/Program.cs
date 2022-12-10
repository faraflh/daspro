/*
made by: Farah Tsabitah Aflah (2207111394)
*/

using System;

namespace soal_uts_3
{
    class Program
    {
        static string nama;
        static int tahunLahir;
        static decimal harga;
        static int tahunIni = 2022;
        static int usia;

        static void Main(string[] args)
        {
            Console.Write("Nama: ");
            nama = Console.ReadLine();

            Console.Write("Tahun Kelahiran: ");
            tahunLahir = Convert.ToInt32(Console.ReadLine());

            CekUsia();
            CekHarga();
            printTicket();
        }

        static void printTicket()
        {
            Console.WriteLine("\n|***************************|");
            Console.WriteLine("|       -- Studio 1 --      |");
            Console.WriteLine("|Nama    : {0,17}|",nama);
            Console.WriteLine("|Harga   : Rp {0,14}|",harga);
            Console.WriteLine("|***************************|");

        }

        static void CekUsia ()
        {
            usia = tahunIni - tahunLahir;
        }

        static void CekHarga()
        {
            if (usia < 10 || usia > 60)
            {
                harga = 10000.00m;
            }
            else
            {
                harga = 25000.00m;
            }
        }
    }
}
