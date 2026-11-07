using System;
using System.Collections.Generic;
using InheritanceMinigame.Classes;

//Character hero = new Character("Hero", 100, 10);
//c.TaskDamage(20);
//c.PerformAttack(null);

//Character player = new Warrior("Aragorn");
//player.PerformAttack(new Mage("Merlin"));

namespace InheritanceMinigame
{
    class Program
    {
        static void Main(string[] args)
        {
            //all the part in the foront no need to type if using Vscode
            Console.WriteLine("WELCOME TO THE INHERITANCE ARENA");
            Console.Write("Enter your hero's name: ");
            string? heroName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(heroName))
                heroName = "Unknown Hero";

            Console.WriteLine("\nChoose your class:");
            Console.WriteLine("1. Warrior (High Health, Blocks Damage)");
            Console.WriteLine("2. Mage (Fragile, Deals Massive Fireball Damage)");
           
            Console.Write("Selection (1 or 2 ): ");
            string? choice = Console.ReadLine();
            
            Character player;

            if (choice == "2")
            {
                player = new Mage(heroName);
            }   
            else
            {
                Console.WriteLine("\nChoose your Warroir:");
                Console.WriteLine("1. Warrior" );
                Console.WriteLine("2. EliteWarrior");
                Console.Write("Selection (1 or 2 ): ");
                string? subchoice = Console.ReadLine();
                /*
                    Console.WriteLine("\nDo you want an EliteWarroir: pressY or no");

                */
                if (subchoice =="1")
                player = new Warrior(heroName);
                else
                player = new EliteWarrior(heroName);
            }

            ////step5: show 2 ways to use "is"
            //1
            if (player is Mage)
            {
                Console.WriteLine("This character is a mage.");
            }
            else
            {
                Console.WriteLine("This character is not a mage.");
            }
            //2 warrior redeclear
            if (player is Warrior warrior)
            {
                Console.WriteLine($"{warrior.Name} has a shield block of {warrior.ShieldBlock}.");
            }

            /////next step: "as" -->first define and then ask
            /// nullable
            //"?" --> should be added
            Mage? mage = player as Mage;

            if (mage != null)
            {
                Console.WriteLine($"{mage.Name} is a mage with {mage.Mana} mana.");
            }
            else
            {
                Console.WriteLine("The player is not a Mage.");
            }   

            ///
            
            //Goblin and Dragon inherit from character
            //they can live inside a single collection
            Queue<Character> dungeonEnemies = new Queue<Character>();
            dungeonEnemies.Enqueue(new Goblin("Gorg the Sneaky"));
            dungeonEnemies.Enqueue(new Goblin("Zib the Vile"));
            dungeonEnemies.Enqueue(new Dragon("Ignis the Flame-Bringer"));

            Console.WriteLine($"{player.Name} enters the dungeon!");
                        while (player.IsAlive && dungeonEnemies.Count > 0)
            {
                Character currentEnemy = dungeonEnemies.Peek();
                Console.WriteLine($"\n--------------------------------------------");
                Console.WriteLine($"💥 A wild {currentEnemy.GetType().Name} appears: {currentEnemy.Name}!");
                Console.WriteLine($"--------------------------------------------");

                while (player.IsAlive && currentEnemy.IsAlive)
                {
                    Console.WriteLine("\nPress ENTER to attack!");
                    Console.ReadLine();
                    player.PerformAttack(currentEnemy);

                    if (!currentEnemy.IsAlive)
                    {
                        Console.WriteLine($"You defeated {currentEnemy.Name}!");
                        dungeonEnemies.Dequeue();
                        break;
                    }

                    currentEnemy.PerformAttack(player);
                }
            }
            
            Console.WriteLine("\n--- END OF GAME ---");
            if (player.IsAlive)
                Console.WriteLine("CONGRATULATIONS! You cleared the dungeon and won the game!");
            else
                Console.WriteLine("YOU DID NOT SURVIVE! GAME OVER.");
            Console.WriteLine("========================================");
        }
    }
}