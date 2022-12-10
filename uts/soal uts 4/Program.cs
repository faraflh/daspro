/*
made by: farah tsabitah aflah (2207111394)
*/
using System;
using System.Text.RegularExpressions;

namespace soal_uts_4
{
    class Program
    {
        static string alfabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string input;
        static string hasilEnkripsi;
        static bool isValid = true;

        static void Main(string[] args)
        {
            Console.Clear();
            while (isValid)
            {
                Console.Write("Teks: ");
                input = Console.ReadLine();
                bool validation = CekInvalidKarakter();

                if (!validation)
                {
                    Console.WriteLine("Karakter yang anda masukkan tidak valid!");
                    Console.WriteLine("Input ulang teks.\n");
                }
                else
                {
                    break;
                }
            }

            CekInput();

            Console.WriteLine("Hasil Enkripsi: " +hasilEnkripsi);
        }

        static void CekInput()
        {
            foreach (char j in input)
            {
                char x = ' ';
                for (int i = 0; i < alfabet.Length; i++)
                {
                    char wrd = alfabet[i];
                    if (j.Equals(wrd))
                    {
                        x = alfabet[i+3];
                    }
                    else if (j.Equals(x))
                    {
                        x = ' ';
                    }
                }
                hasilEnkripsi = hasilEnkripsi + x;
            }
        }
        static bool CekInvalidKarakter()
        {
            string pattern = "[A-Z a-z]";
            Regex re = new Regex(pattern);
            if (re.IsMatch(input) || string.IsNullOrEmpty(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
