using System;

namespace soal_uts_2
{
    class Program
    {
        static decimal rateUSD = 15355.20m;
        static decimal jumlahUSD;
        static decimal hasilConv;

        static void Main(string[] args)
        {
            Console.WriteLine("Rate USD ke RP:");
            Console.WriteLine(rateUSD);

            Console.WriteLine("Jumlah USD:");
            jumlahUSD = Convert.ToInt32(Console.ReadLine());

            hitungRate();

            Console.WriteLine("Hasil Konversi: ");
            Console.WriteLine(hasilConv);
        }

        static void hitungRate()
        {
            hasilConv = rateUSD * jumlahUSD;
        }
    }
}
