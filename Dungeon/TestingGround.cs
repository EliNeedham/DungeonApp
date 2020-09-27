using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using DungeonMonster;

namespace Dungeon
{
    class TestingGround
    {
        static void Main(string[] args)
        {
            Console.Title = "Elizabeth's Bob's Burgers Dungeon\n";
            Console.WriteLine("Welcome to our humble commode! Abode? Whatever, it's a dungeon....\n with a real burger taste!\n\n");

            #region Player Choice Switch
            Console.WriteLine("Please choose your player.\nA) Louise\nB) Bob\nC) Tina\nD) Linda\nE) Gene\nF) Jimmy Junior\nG) Canadian Jesus \nX) Exit\n;");



            bool exitPlayerSwitch = false;

            while (exitPlayerSwitch == false)
            {

                ConsoleKey userPlayer = Console.ReadKey(true).Key;
                switch (userPlayer)

                {
                    case ConsoleKey.A:
                        Console.WriteLine("Good idea, I knew you were smarter than you looked!\n");
                        Console.ReadLine();
                        Console.WriteLine("Winner gets to read Tina’s diary\n");
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("Hit me with your best shallot!\n");
                        Console.ReadLine();
                        Console.WriteLine("Winner gets to come up with tomorrow's \"Burger of the Day\"\n");
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("uhhhhhhhhhhhh\n Tina groans from stagefright...\nTime for the charm bomb to explode.\n");
                        Console.ReadLine();
                        Console.WriteLine("Winner gets to kiss Jimmy Junior's cheeks\n");
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("I love showers and mornings and bologna and turtles!\n");
                        Console.ReadLine();
                        Console.WriteLine("If anything happens don’t call AAA because we don’t have them and we owe them money from when we did.\n");
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("You should know when you hold hands with me, you are holding hands with everything I've ever eaten.\n");
                        Console.ReadLine();
                        Console.WriteLine("I'm not taking the burger suit off. Even if we win.\n");
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine("I'm the Katniss to your Pita bread.\n");
                        Console.ReadLine();
                        Console.WriteLine("You haven't won until you've beaten me in a dance off!\n");
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine("Seriously? I'm not even from Canada....\n");
                        Console.ReadLine();
                        Console.WriteLine("May the best... may someone win so we can get this over with.\n");
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine("Whatever.\n");
                        Console.ReadLine();
                        exitPlayerSwitch = true;
                        break;
                    default:
                        Console.WriteLine("uuuuuuhhhhhh\n That didn't make any sense. Try again\n");
                        exitPlayerSwitch = true;
                        break;
                }

            }
            //while (exitPlayerSwitch)
            //{


            //}
            Console.Clear();


            #endregion

        }//end main ()
    }//end class
}//end namespace
