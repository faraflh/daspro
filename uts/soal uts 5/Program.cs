using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soal_uts_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] quest = new string[] {"taylor", "adele", "dua", "ariana", "halsey", "camila", "niki", "demi", "rihanna", "cardi"};
            Random rnd = new Random();
            string hiddenWord = "";
            int random = rnd.Next(1,9);
            string chosenWord = quest[random];
            char[] guess = new char [chosenWord.Length];
            int mistakes = 0;
            bool wrong = false, win = false, lose = false, right = false;
            
            for (int j = 0; j < chosenWord.Length; j++)
            {
                guess[j] = '_';
            }

            while (win == false && lose == false)
            {
                Console.Write("Huruf tebakan : ");
                char yourGuess = char.Parse(Console.ReadLine());

                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (yourGuess == chosenWord[i])
                    { 
                        right = true;
                        guess[i] = yourGuess;
                    } else if (i == chosenWord.Length - 1 && right == false)
                    { 
                        wrong = true; 
                    }
                }
                hiddenWord = new String(guess);
                if (wrong == true)
                {
                    Console.WriteLine("Tebakan  salah!");
                    mistakes++;
                    wrong = false;
                }
                right = false;
                Console.WriteLine(guess);

                switch (mistakes)
                {
                    case 1:
                        Console.WriteLine("__|__");
                        break;
                    case 2:
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("__|__");
                        break;
                    case 3:
                        Console.WriteLine("  |/");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("__|__");
                        break;
                    case 4:
                        Console.WriteLine("__________");
                        Console.WriteLine("  |/");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("__|__");
                        break;
                    case 5:
                        Console.WriteLine("__________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("__|__");
                        break;
                    case 6:
                        Console.WriteLine("__________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("__|__");
                        break;
                    case 7:
                        Console.WriteLine("__________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |     \\|/");
                        Console.WriteLine("  |");
                        Console.WriteLine("  |");
                        Console.WriteLine("__|__");
                        break;
                    case 8:
                        Console.WriteLine("__________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |      \\|/");
                        Console.WriteLine("  |       |");
                        Console.WriteLine("  |");
                        Console.WriteLine("__|__");
                        break;
                    case 9:
                        Console.WriteLine("__________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |     \\|/");
                        Console.WriteLine("  |       |");
                        Console.WriteLine("  |      / \\");
                        Console.WriteLine("__|__");
                        break;
                    case 10:
                        Console.WriteLine("__________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |     \\|/");
                        Console.WriteLine("  |       |");
                        Console.WriteLine("  |      / \\");
                        Console.WriteLine("__|__");
                        break;

                    default:
                        break;
                }
                if (hiddenWord == chosenWord)
                {
                    Console.WriteLine("Selamat, Anda menang!");
                    win = true;
                }
                else if (mistakes == 10 && hiddenWord != chosenWord)
                {
                    Console.WriteLine("Yahh, Anda kurang beruntung!");
                    lose = true;
                }
            }
        }
    }
}
