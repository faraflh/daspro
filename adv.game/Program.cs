
/*
Made by : Farah Tsabitah Aflah (2207111394)
*/
using System;

namespace adv._game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n[Intro music playing]\n");
            Console.WriteLine("Insert name...\n");
            
            Novice player = new Novice();

            player.Name = Console.ReadLine();
            int level = 1;
            string diff = "Normal";
            Console.WriteLine("");
            Console.WriteLine("||==================================================||");
            Console.WriteLine("||         Welcome to Resident Evil Village         ||");
            Console.WriteLine("||Player     : {0,37}||",player.Name);
            Console.WriteLine("||Difficulty : {0,37}||",diff);
            Console.WriteLine("||Level      : {0,37}||",level);
            Console.WriteLine("||==================================================||\n");
            Console.WriteLine("The game will begin shortly. Do you want to proceed?\n");
            Console.WriteLine("Yes");
            Console.WriteLine("No\n");

            string startG = Console.ReadLine();
            
            if (startG == "Yes" | startG == "yes" | startG == "Y" | startG == "y")
            {
                Console.WriteLine($"\n{player.Name} is entering The Village...");
                Enemy e1 = new Enemy("Lady Dimitrescu");
                Console.WriteLine($"In level 1 you will encounter your first enemy, {e1.Name}.");
                Console.WriteLine("Press any key to proceed.\n");
                Console.ReadKey();
                Console.WriteLine($"{e1.Name} is attacking you!");
                Console.WriteLine("What is your move?");
                Console.WriteLine("1. Melee Attack");
                Console.WriteLine("2. Fire LEMI");
                Console.WriteLine("3. Dodge Attack");
                Console.WriteLine("4. Run Away\n");

                while (!player.IsDead && !e1.IsDead)
                {
                    string pAction = Console.ReadLine();

                    switch(pAction)
                    {
                        case "1":
                            Console.WriteLine($"\n{player.Name} is going for Melee Attack!");
                            e1.GetHit(player.AttackPower);
                            player.Experience += 0.5f;
                            Console.WriteLine($"{e1.Name} is striking back!!");
                            e1.Attack(e1.AttackPower);
                            player.GetHit(e1.AttackPower);
                            Console.WriteLine($"Player Health: {player.Health}");
                            Console.WriteLine($"{e1.Name} Health: {e1.Health}\n");
                            break;
                        
                        case "2":
                            Console.WriteLine($"\n{player.Name} is firing shots!");
                            player.Fire();
                            e1.GetHit(player.AttackPower);
                            player.Experience += 1.5f;
                            Console.WriteLine("");
                            Console.WriteLine($"Player Health: {player.Health}");
                            Console.WriteLine($"{e1.Name} Health: {e1.Health}\n");
                            break;

                        case "3":
                            player.Recharge();
                            Console.WriteLine($"\n{player.Name} is dodging {e1.Name}'s attack.");
                            e1.Dodged(e1.AttackPower);
                            Console.WriteLine("Recharging energy...\n");
                            break;

                        case "4":
                            Console.WriteLine($"\n{player.Name} is running away...\n");
                            break;
                    }

                    if (e1.IsDead)
                    {
                        Console.WriteLine("You've finished level 1!");
                    }
                }

                Console.WriteLine($"{player.Name} gets {player.Experience} experience point.\n");
            }
            else
            {
                Console.WriteLine("\nGame is closed.");
                Console.Read();
            }
        }
    }

    class Novice
    {
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int AttackPower { get; set; }
        Random rnd = new Random();

        public Novice()
        {
            Name = "New Player";
            Experience = 0f;
            Health = 100;
            Energy = 2;
            AttackPower = 1;
        }

        public void Fire()
        {
            if (Energy > 0)
            {
                Console.WriteLine("Shots fired");
                AttackPower += rnd.Next(3,10);
                Energy--;
            }
            else
            {
                Console.WriteLine("Mag's empty! Press R to reload...");
                string rld =  Console.ReadLine();
                if (rld == "R" || rld == "r")
                {
                    Console.WriteLine("Reloading...");
                    Console.WriteLine("Firing shots!");
                    Energy += 5;
                }
            }
        }

        public void GetHit(int hitValue)
        {Console.WriteLine($"{Name} got hit by {hitValue}\n");
            Health = Health - hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Recharge()
        {
            Energy = 5;
            AttackPower = 1;
        }

        public void Die()
        {
            Console.WriteLine($"You're dead. Game over.");
            IsDead = true;
        }
    }

    class Enemy
    {
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Name = name;
            Health = 50;
            AttackPower = 1;
        }

        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1,10);
        }

        public void Dodged(int dodge)
        {
            AttackPower--;
            Console.WriteLine($"{Name} missed! {Name}'s power is {AttackPower}.\n");
        }

        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name} got hit by {hitValue}");
            Health = Health - hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine($"{Name} is dead.");
            IsDead = true;
        }
    }
}
