/*
Made By: Farah Tsabitah Aflah (2207111394)
*/

using System;

namespace battle_tank_2
{
    class Program
    {
        static char tank = 't';
        static char sand = '~';
        static char hit = 'X';
        static char miss = '0';
        static int dessertLength = 5;
        static int activeTank = 0;
        static int tankTot =  3;
        static int hiddenTank = tankTot;

        static void Main(string[] args)
        {
            char[,] battlefield = dessert(dessertLength, sand, tank, tankTot);
            
            printDessert(battlefield, tank, sand);

            while (hiddenTank > 0)
            {
                int[] guessCoor = yourGuess(dessertLength);
                char locviewUpd = checkAns(guessCoor, battlefield, sand, hit, miss);

                if (locviewUpd == hit)
                {
                    hiddenTank--;
                }
                battlefield = updateBattlefield(battlefield, guessCoor, locviewUpd);
                printDessert(battlefield, tank, sand);

                if (hiddenTank <= 0)
                {
                    break;
                }
            }
            Console.WriteLine("GOOD JOB! ALL TANK HAS BEEN DESTROYED!");
            Console.WriteLine("Game has ended.");
        }

        static void printDessert(char[,] battlefield, char tank, char sand)
        {
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();

            for (int row = 0; row < 5; row++)
            {
                Console.Write(row + 1 + " ");
                for (int column = 0; column < 5; column++)
                {
                    char position = battlefield[row,column];
                    if(position == tank)
                    {
                        Console.Write(sand+ " ");
                    }
                    else
                    {
                        Console.Write(position+ " ");
                    } 
                }
                Console.WriteLine();
            }
        }

        static char checkAns(int[] guessCoor, char[,] battlefield, char sand, char hit, char miss)
        {
            string popup;
            int row = guessCoor[0];
            int column = guessCoor[1];
            char target = battlefield[row,column];

            if (target == tank)
            {
                popup = "BOOM! TANK IS DESTROYED.";
                target = hit;
            }
            else if (target == sand)
            {
                popup = "TANK MISSED!";
                target = miss;
            }
            else
            {
                popup = "THIS FIELD HAS BEEN CLEARED.";
            }

            Console.WriteLine(popup+"\n");
            return target;
        }

        static char[,] updateBattlefield(char[,] battlefield, int[] guessCoor, char locviewUpd)
        {
            int row = guessCoor[0];
            int column = guessCoor[1];
            battlefield[row,column] = locviewUpd;

            return battlefield;
        }

        static int[] yourGuess(int dessertLength)
        {
            int row, column;

            Console.WriteLine("\nGuess where the tank is!");
            do
            {
                Console.Write("Row: ");
                row = Convert.ToInt32(Console.ReadLine());
            } while (row < 0 || row > dessertLength + 1);

            do
            {
                Console.Write("Column: ");
                column = Convert.ToInt32(Console.ReadLine());
            } while (column < 0 || column > dessertLength + 1);

            return new[]{row-1, column-1};
        }

        static char[,] dessert(int dessertLength, char sand, char tank, int tankTot)
        {
            char[,] battlefield = new char[dessertLength,dessertLength];
            for (int row = 0; row < dessertLength; row++)
            {
                for (int column = 0; column < dessertLength; column++)
                {
                    battlefield[row,column] = sand;
                }
            }
            return tankPlace(battlefield, tankTot, sand, tank);
        }

        static char[,] tankPlace(char [,] battlefield, int tankTot, char sand, char tank)
        {
            while (activeTank < tankTot)
            {
                int[] tankLoc = tankCoordinate(dessertLength);
                char rigtLoc = battlefield[tankLoc[0],tankLoc[1]];

                if(rigtLoc == sand)
                {
                    battlefield[tankLoc[0],tankLoc[1]] = tank;
                    activeTank++;
                }
            }
            return battlefield;
        }

        static int[] tankCoordinate(int dessertLength)
        {
            Random rnd = new Random();
            int[] coordinates = new int[2];
            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = rnd.Next(dessertLength);
            }
            return coordinates;
        }
    }
}
