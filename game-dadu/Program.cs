/*
Program made by: Farah Tsabitah Aflah (2207111394)
*/
using System;

namespace daspro
{
    class Program
    {
        public static int skorAnda = 0;
        public static int skorKomp = 0;
        public static int nilaiKomp;
        public static int nilaiAnda;

        public static void Main(string[] args)
        {
            Console.WriteLine("Pada game ini anda dan komputer aja bermain 10 ronde");
            Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang akan menang? Selamat berjuang!\n");
            Console.WriteLine("Klik enter untuk memulai...\n");
                
            Console.ReadKey();
            
            for(int rnd = 1; rnd <= 10; rnd++)
            {
                PlayGame(rnd);
                
                Console.WriteLine("Skor anda: " +skorAnda);
                Console.WriteLine("Skor komputer: " +skorKomp);
                Console.WriteLine("Pencet tombol apa saja untuk melanjutkan\n");
                Console.ReadKey();
            }
            Closing();
        }
        
        public static void PlayGame(int rnd)
        {
            Random rng = new Random();
            
            nilaiKomp = rng.Next(1,6);
            nilaiAnda = rng.Next(1,6);
            
            Console.WriteLine("Ronde " +rnd+ "\n");
            Console.WriteLine("Nilai Komputer: " +nilaiKomp);
            
            Console.WriteLine("Lempar dadu anda...");
            Console.WriteLine("Nilai anda: " +nilaiAnda);

            if(nilaiAnda == nilaiKomp)
            {
                Console.WriteLine("Ronde ini seri!");
            }
            else if(nilaiAnda > nilaiKomp)
            {
                Console.WriteLine("Anda memenangkan ronde ini.");
                skorAnda++;
            }
            else if(nilaiAnda < nilaiKomp)
            {
                Console.WriteLine("Komputer memenangkan ronde ini.");
                skorKomp++;
            }
        }
        
        public static void Closing()
        {
            Console.WriteLine("Skor akhir anda: " +skorAnda);
            Console.WriteLine("Skor akhir komputer: " +skorKomp);
            
            if(skorKomp > skorAnda)
            {
                Console.WriteLine("\nYahhh... Komputer telah memenangkan permainan ini.");
            }
            else
            {
                Console.WriteLine("\nYayyy!!! Anda telah memenangkan permainan ini!");
            }
        }
        
    }
}
