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
            Console.WriteLine("Please choose your player.\nA) Louise\nB) Bob\nC) Tina\nD) Linda\nE) Gene\nF) Jimmy Junior\nG) Canadian Jesus \nX) Exit\n");


            // LOOP FOR MENU OF OPTIONS
            bool reload = false;

            do
            {
                Console.WriteLine("======================");
                Console.WriteLine("| Choose an action: |");
                Console.WriteLine("|   A)ttack         |");
                Console.WriteLine("|   H)url Insults   |");
                Console.WriteLine("|   R)un Away       |");
                Console.WriteLine("|   Q)uit           |");
                Console.WriteLine("|   P)layer Deets   |");
                Console.WriteLine("|   M)uenster Deets |");
                Console.WriteLine("======================");

                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();
                switch (userChoice)
                {
                    case ConsoleKey.A:
                        //11. TODO handle an attack sequence
                        Console.WriteLine("\nYou boldy advance on the monster with");
                        //12. Handle if the player wins
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("\nYou hurl your most poignant insult at the beast.");
                        //TODO handle insult sequence 1 in 4 chance of causing damage and then monster gets to attack
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("\nAnthrax! Run for your lives!!");
                        //TODO insert insult array randomizer here???
                        //13. Monster getting a free attack
                        
                        //single attack call on doattack()

                        //Console.WriteLine($"{monster.Name} attacks as you flee!");
                        //Combat.DoAttack(monster, player); //free attack - attack of opportunity
                        //Console.WriteLine();//creat empty line in console

                        //14. Exiting the inner loop and getting a new room
                        reload = true; //exiting the inner loop and will get a new room and monster
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("\nMr Frond would say that he is a knitter, not a quitter. Clearly, the same cannot be said for you.");
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("\nPlayer Deets");
                        //TODO Console.WriteLine(   PUT VAR CONTAINING PLAYER IN HERE);
                        //Console.WriteLine("Monsters Defeated: " + score);

                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("\nMeunster Deets");
                        //TODO Console.WriteLine(   PUT VAR CONTAINING MONSTER IN HERE);
                        //AND MAYBE SOME INSULTS??? OR A RANDOMIZER FOR THE BURGER OF THE DAY?
                        break;
                    default:
                        Console.WriteLine("I'm not risking any of those bugs getting into my peach cobbler no matter how stale it is. Try again!");
                        reload = true;
                        break;
                }
            } while (!reload);




            #endregion

        }//end main ()
    }//end class
}//end namespace
