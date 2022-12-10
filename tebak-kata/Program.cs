
/*
made by: farah aflah (2207111394)
*/

using System;
//khusus untuk list, stack, dll
using System.Collections.Generic;

namespace tebak_kata
{
    class Program
    {
        static int chances = 5;
        static string mysteryWord = "midnights";
        static List<string> guessList = new List<string>{};

        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            Endgame();
        }

        static void Intro()
        {
            Console.WriteLine("Welcome! Today we're gonna play Guess the Word !!");
            Console.WriteLine($"You have {chances} chances to guess today's mystery word.");
            Console.WriteLine("Clue: Taylor Swift's upcoming album");
            Console.WriteLine($"The word is {mysteryWord.Length} letters long");
            Console.WriteLine("What is the name of the album?");
            Console.WriteLine("\nPress enter to start");
            Console.ReadKey();
        } 

        static void PlayGame()
        {
            while (chances > 0)
            {
                Console.Write("\nGuess the letter (pick from a to z): ");
                string input = Console.ReadLine();
                guessList.Add(input);

                if(CheckAns(mysteryWord, guessList))
                {
                    
                    Console.WriteLine(CheckLetter(mysteryWord, guessList));
                    Console.WriteLine("Congratulations!! You've guessed the word!");
                    Console.WriteLine($"Today's mystery word is {mysteryWord}");
                    break;
                }
                else if(mysteryWord.Contains(input))
                {
                    Console.WriteLine("You guessed the right letter!");
                    Console.WriteLine(CheckLetter(mysteryWord, guessList));
                    Console.WriteLine("Pick another letter");
                }
                else
                {
                    Console.WriteLine("Ouch!! Wrong letter!");
                    Console.WriteLine(CheckLetter(mysteryWord, guessList));
                    chances--;
                    Console.WriteLine($"Chances left: {chances}");
                    Console.WriteLine("Pick another letter");
                }

                if(chances == 0)
                {
                    Endgame();
                    break;
                }
            }
        }

        static bool CheckAns(string secretWord, List<string> list)
        {
            bool stat = false;

            for(int i = 0; i < secretWord.Length; i++)
            {
                string wrd = Convert.ToString(secretWord[i]);
                if(list.Contains(wrd))
                {
                    stat = true;
                }
                else
                {
                    return stat = false;
                }
            }
            
            return stat;
        }

        static string CheckLetter(string secretWord, List<string> list)
        {
            string x = "";

            for(int i = 0; i < secretWord.Length; i++)
            {
                string wrd = Convert.ToString(secretWord[i]);
                if(list.Contains(wrd))
                {
                    x = x + wrd;
                }
                else
                {
                    x = x + "_";
                }
            }
            return x;
        }

        static void Endgame()
        {
            Console.WriteLine("Game has ended.");
            Console.WriteLine("");
        }
    }
}
