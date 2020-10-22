using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using DungeonMonster;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region =======================Monsters===================================

            MonsterMaster Gayle = new MonsterMaster("Gayle", 30, 36, 50, 25, 2, 6, "a bespectacled, fanny pack wearing, incredibly gullible cat lady who happens to be Linda’s younger sister. Emotionally fragile, marginally confused and destined to be single - even going so far as to play pretend every night before bed that she's taking shelter from a nuclear apocalypse in which she is the sole survivor, \"especially the men, so it's okay to sleep alone.\"  Her three cats are looking daggers at you, Jean Paw'd Van Damme, Pinkeye and Mr.Business – who really means business.", false, true);
            MonsterMaster JimmyPesto = new MonsterMaster("Jimmy Pesto", 30, 40, 55, 30, 4, 6, "Handsome (despite the cleft chin and brown pompadour) and the owner of a successful Italian restaurant, Jimmy Pesto is Bob’s nemesis.", true, false);
            MonsterMaster Fischoeder = new MonsterMaster("Mr. Fischoeder", 30, 40, 60, 40, 2, 8, "One white cat away from being a supervillain, Mr. Fischoeder wears a white suit, an eye patch, and sometimes a white cape, and drives around town in a golf buggy. Loose morals allow him to cut corners and blame others to protect himself.", true, false);
            MonsterMaster Tina = new MonsterMaster("Tina", 30, 40, 58, 40, 2, 4, "/“Uuuuuuuuhhhhhhhhh………./” You recognize Tina’s stage-fright groan anywhere. Usually harmless and disarming, this tushie loving teenager is full of raging hormones and on a mission to make Jimmy Junior her dance partner. You’re the only thing standing between her and her dreams! Well you…. Bob…. Gene….. the mailman, some people off the street (who invited them?) and that kid from next door…. But that’s not the point! You’re the first in line.", false, true);
            MonsterMaster Frond = new MonsterMaster("Mr. Frond", 30, 40, 55, 30, 4, 6, "A tall drink of annoying, Mr. Frond is a geeky, nervous, perhaps fruity and perpetually flustered guidance counselor. He used to sell hand-knitted Doctor Who scarves on Etsy until a PBS lawyer sent him a cease and desist letter and he was elected seventh grade class secretary after hiding votes for his opponent.", true, true);
            MonsterMaster Linda = new MonsterMaster("Linda", 30, 40, 55, 40, 4, 6, "Dinner Theater (more like Drink Theater in this case) brings out the crazy in her. This is not the fun-loving Linda we know so well, but the dramatic crazed Linda. \"The Show Must Go On\" and she is willing to go to any lengths to achieve the age-old adage", true, false);
            MonsterMaster Hugo = new MonsterMaster("Hugo the Health Inspector", 30, 36, 50, 25, 2, 6, "A short, blond, pear-shaped man, he’s a City Health Inspector (and former Nudist), which he takes very seriously. Hugo and Linda were briefly engaged before she dumped him for Bob via rap on his answering machine, needless to say he isn’t a fan of Bob’s Burgers. ", false, true);
            MonsterMaster Zeke = new MonsterMaster("Zeke", 30, 40, 60, 35, 4, 6, "While the other kids are dressed to impress in the Freezer Dome, this slightly tubby tank top touting kid is decked out in the most practical of costumes for the fight, shirtless with football pads. Zeke is the biggest kid in his class, and although usually protective he’s out for blood today!", true, false);
            MonsterMaster MeatMan = new MonsterMaster("Meat Man", 30, 40, 45, 35, 4, 6, "Remember that one time that Bob knocked the hambuger on the floor and Louise convinced him not to throw it all out and then made a meat golem? Yeah, it's down here. And angry, and it smells horrible - don't let it touch you!", false, false);

            MonsterMaster[] monsters = { Hugo, Fischoeder, Tina, Frond, Linda, Zeke, MeatMan, JimmyPesto, Gayle };

            //have the rooms at the same index matcht the monster

            #endregion

            #region Rooms
            string[] rooms =
            {        //=========== Bob's Burger's Diner ============================
        "\nYou find yourself in a traditional diner with a checkerboard floor, red leather swivel stools and a single row of booths. Probably one of the best burger joints in town but it’s praises are widely unsung. On a chalk board to your right, " +
        "\n                   Say It Ain't Cilantro Burger" +
        "\n (Doesn't come with cilantro. Because cilantro is terrible.) " +
        "\n\nIt's Bob's Burgers. ",
                //===================Fishoeder's Mansion===============
               
        "\nYou find yourself on the grounds of a 2.5 story Victorian manor house with a tower centered above the front doors. Most noticeable, the formal garden with eerily lit statues, an overgrown hedge maze (from which strange lonely sounds are emanating), a tree house (where Felix lives due to being kicked out of the main house because of his sleep apnea), and a field out back where old, broken Wonder Wharf rides are kept. The only thing more terrifying than a carnival ride, is a broken one. Who are we kidding, they're all broken the workers just don't tell you about how little Davey fell off last week due to faulty wiring... \n\nThat’s right, you’re at Mr Fischoeder’s Mansion!",
                //===================Tina's Birthday party===============
 
        "\nYou are greeted with the dulcet tones of synth music, billowing fog swirls around your legs and floating circles of light wander along the walls reflecting off the disco ball suspended from the ceiling tiles. You’re affronted by the sickly-sweet smell of the smoke machine (most likely purchased from What the Tech Superstore). That’s right, it’s Tina’s 13th birthday party. It’s a boy/girl party, with mingling. Gene is djing, \n“Come on boys, you’re the peanut butter. Girls, you’re the jelly. Let’s make some sandwiches!” \nYou ask yourself, “What's The Worcestershire That Could Happen?”",
        //======================= Frond's Office ===============

        "\nYou're in Mr Frond's office (guidance counselor). Enter Mr Frond, \n“Attention! There has been a grisly crime committed in my office! \n\n(If looks could kale you'd already be dead.)\n\n My therapy dolls have been mutilated\" \nTheo Theo’s stuffing has been ripped out and he is hanging from the ceiling from his yarntrails. Lynne Secure is now finally secured – to the desk – at least what’s left of her….. Pierre Pressure suffered a similar end. The others will have to be identified from yarn records. What sick twisted, but really creative kid did this?   \n\nBeets Me!",
        //======================== Dreamatorium =========================

        "\nA very distinct crooning fills your ears. Crooning? Maybe we should’ve said screeching… Linda is on a makeshift stage in the diner, swinging a microphone around at the diners in a concerning and slightly aggressive display. You interrupt her favorite number – her wrath and twisted creative genius is now turned toward you. \n\nDinner Theater has created a Muenster",
        //======================== Fight Club ============================

        "\n===========================Welcome to the freezer dome!=============================\n" +
        "It's the Final Kraut Down.\n " +
        "You’re dressed in 80’s wrestling gear, a pink leather vest, fuchsia feather boa, a sequined cowboy hat and well, best not to describe the rest… The Belcher children have turned the walk in cooler of Bob’s Burger’s into an ice-skating rink by sneakind down in the middle of the night to dump water on the freezer floor..... \nThe newly dubbed freezer dome is now a fight club slip show. \nTwo kids enter – one kid leaves!",
        //==================== Bob's Basement ===========================

        "\nYou enter a dark, cold room. The basement of Bob’s Burgers. \nSpanning the walls all around are shelves filled with…. \nPickled things. \nMostly…. oh, mostly pickles. There is a meat grinder on a table in the center, one wrong move could lead to \nonion-tended consequences….",

                //=========== Jimmy Pesto's Pizzeria ============================

        "\nIt's Pastafarian Night at Jimmy Pesto's Pizzeria. \nBesides the cheesy expected paintings of grapes and maps of Italy there is also an area dedicated to Jimmy’s trophies. \nBob’s moustache is framed on the wall like a pinned butterfly in an entomological display. The pizza being waltzed out by the staff looks distinctly as though it smells like regret.",
        // ===================== Yarnival ===================================

        "\nYou’re accosted by the sound cats screeching and hissing. One flies by your head narrowly missing clawing your face off. There are bright lights, something that might be described as live music and in the air hundreds of cats are soaring. Some of them dangling on threads of yarn, some being unceremoniously tossed onto a trampoline, and one remarkably performing a Triple Twisting Double on the trapeze…. \n\nYou are at Yarnival, it’s like Cirque du Soleil but with cats."

        };
            #endregion

            #region ==================WEAPONS===========================


            //TODO 2. Create a weapon
            Weapon fryingPan = new Weapon(2, 8, "Frying Pan", 10, true);
            Weapon mapleSyrup = new Weapon(2, 8, "A squeezer bottle full of maple syrup", 6, false);
            Weapon rollingPin = new Weapon(2, 6, "Rolling Pin", 6, false);
            Weapon meatMan = new Weapon(0, 6, "Meat Man", 12, true);
            Weapon keyboard = new Weapon(2, 6, "Gene's Keyboard", 6, false);
            Weapon ninjaStar = new Weapon(4, 8, "Bob's credit card cut into a ninja star", 6, false);
            Weapon spatula = new Weapon(2, 4, "Burger Spatula", 16, false);
            Weapon cheeseGrater = new Weapon(2, 4, "Cheese Grater", 14, false);
            Weapon mrBusiness = new Weapon(1, 2, "Mr Business", 5, false);
            #endregion

            #region ===================Players==========================


            //TODO 1. Create a player
            //d di 1-20 is hit chance - if you have block of 20 then you have to roll at least a 10 to even hit them - you could add armor to make yourself hard to hit, block - damage absorption is 
            //
            Player pLouise = new Player("Louise Belcher", 79, 4, 40, 40, Flavor.Louise, ninjaStar);
            Player pBob = new Player("Bob Belcher", 65, 8, 36, 40, Flavor.Bob, spatula);
            Player pTina = new Player("Tina Belcher", 65, 8, 40, 40, Flavor.Tina, meatMan);
            Player pLinda = new Player("Linda Belcher", 70, 6, 40, 40, Flavor.Linda, rollingPin);
            Player pGene = new Player("Gene Belcher", 63, 10, 40, 40, Flavor.Gene, keyboard);
            Player pJimmyJunior = new Player("Jimmy Junior", 63, 6, 38, 40, Flavor.JimmyJunior, cheeseGrater);
            Player pCanadianJesus = new Player("Canadian Jesus", 70, 4, 40, 48, Flavor.CanadianJesus, mapleSyrup);
            Player[] players = { pLouise, pBob, pTina, pLinda, pGene, pJimmyJunior, pCanadianJesus };
            #endregion

            Console.Title = "Elizabeth's Bob's Burgers Dungeon";
            Console.WriteLine("Welcome to our humble commode! Abode? Whatever, it's a dungeon....\n with a real burger taste!\n");
            Console.ReadLine();


            Player player = null;
            #region Player Choice Switch inside while loop
            bool exitPlayerSwitch = false;
            do
            {
                #region Player Menu

                Console.WriteLine("Pick your poison.");
                Console.WriteLine("=======================");
                Console.WriteLine("|  Player Options     |");
                Console.WriteLine("|   A) Louise         |");
                Console.WriteLine("|   B) Bob            |");
                Console.WriteLine("|   C) Tina           |");
                Console.WriteLine("|   D) Linda          |");
                Console.WriteLine("|   E) Gene           |");
                Console.WriteLine("|   F) Jimmy Junior   |");
                Console.WriteLine("|   G) Canadian Jesus |");
                Console.WriteLine("|   X) Exit           |");
                Console.WriteLine("=======================");

                #endregion

                ConsoleKey userPlayer = Console.ReadKey(true).Key;
            }
            while (exitPlayerSwitch == false)
            {


                switch (userPlayer)

                {
                    case ConsoleKey.A:
                        player = pLouise;
                        Console.WriteLine("Good idea, I knew you were smarter than you looked!\n");
                        Console.ReadLine();
                        Console.WriteLine("Winner gets to read Tina’s diary\n");
                        Console.ReadLine();
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.B:
                        player = pBob;
                        Console.WriteLine("Hit me with your best shallot!\n");
                        Console.ReadLine();
                        Console.WriteLine("Winner gets to come up with tomorrow's \"Burger of the Day\"\n");
                        Console.ReadLine();
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.C:
                        player = pTina;
                        Console.WriteLine("uhhhhhhhhhhhh\n Tina groans from stagefright...\nTime for the charm bomb to explode.\n");
                        Console.ReadLine();
                        Console.WriteLine("Winner gets to kiss Jimmy Junior's cheeks\n");
                        Console.ReadLine();
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.D:
                        player = pLinda;
                        Console.WriteLine("I love showers and mornings and bologna and turtles!\n");
                        Console.ReadLine();
                        Console.WriteLine("If anything happens don’t call AAA because we don’t have them and we owe them money from when we did.\n");
                        Console.ReadLine();
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.E:
                        player = pGene;
                        Console.WriteLine("You should know when you hold hands with me, you are holding hands with everything I've ever eaten.\n");
                        Console.ReadLine();
                        Console.WriteLine("I'm not taking the burger suit off. Even if we win.\n");
                        Console.ReadLine();
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.F:
                        player = pJimmyJunior;
                        Console.WriteLine("I'm the Katniss to your Pita bread.\n");
                        Console.ReadLine();
                        Console.WriteLine("You haven't won until you've beaten me in a dance off!\n");
                        Console.ReadLine();
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                    case ConsoleKey.G:
                        player = pCanadianJesus;
                        Console.WriteLine("Seriously? I'm not even from Canada....\n");
                        Console.ReadLine();
                        Console.WriteLine("May the best... may someone win so we can get this over with.\n");
                        Console.ReadLine();
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
                        Console.ReadLine();
                        Console.Clear();
                        exitPlayerSwitch = true;
                        break;
                }

            }


            #endregion





            //Console.WriteLine(rooms[0], monsters[0]);
            //Console.WriteLine(m);




            //TODO this might need to be changed later in order to assign a specific monster to a room - not sure how to do that yet

            //5. Create a monster

            //Create a loop for the menu of option

            #region ===================== LOOP FOR MENU OF OPTIONS ===================================
            bool exit = false;
            int roomCounter = 0;

            do
            {
                bool reload = false;
                MonsterMaster monster = monsters[roomCounter];
                string room = rooms[roomCounter];
                Console.WriteLine("=========================================================================================");
                Console.WriteLine(room);
                Console.WriteLine(
                    "==================================================================" +
                    "\nYou opponent is " + monster.Name, monster.Description);
                //display rooom before the counter updates - if it doesn't work well here then update inside of the switch
                roomCounter++;// test this to see if it works
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("======================");
                    Console.WriteLine("| Choose an action: |");
                    Console.WriteLine("|   A)ttack         |");
                    Console.WriteLine("|   H)url Insults   |");
                    Console.WriteLine("|   B)ribe          |");
                    Console.WriteLine("|   R)un Away       |");
                    Console.WriteLine("|   Q)uit           |");
                    Console.WriteLine("|   P)layer Deets   |");
                    Console.WriteLine("|   M)uenster Deets |");
                    Console.WriteLine("======================");




                    //TODO test this later

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //11. TODO handle an attack sequence
                            Console.WriteLine($"\nYou boldy advance on the monster with {player.EquippedWeapon}");
                            Combat.DoBattle(player, monster);

                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}\n", monster.Name);
                                Console.ResetColor();
                            }
                            reload = true;
                            break;
                        case ConsoleKey.H:
                            Console.WriteLine("\nYou hurl your most poignant insult at the beast.");
                            //TODO Insert the insult array here
                            if (monster.EasilyInsulted == false)
                            {
                                Console.WriteLine("Ha! Like you could break me with petty words. I'm not easily insulted!");
                            }
                            else
                            {
                                int random = new Random().Next(1, 4);
                                if (random == 3)
                                {
                                    Console.WriteLine("\nYour insult killed the beast");
                                    reload = true;
                                }
                                else
                                {
                                    //TODO could have customized responses per monster here
                                    Console.WriteLine("Nice try pipsqueak");
                                    Console.WriteLine("Your ridicule game is ridiculously lame.... try again.");
                                }
                            }
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}\n", monster.Name);
                                Console.ResetColor();
                                reload = true;
                            }

                            break;
                        case ConsoleKey.B:
                            Console.WriteLine("\nBribe");
                            if (monster.AcceptsBribes == true)
                            {
                                Console.WriteLine("Bribery you say? I'm so incensesd I find it difficult to even fight!");
                                monster.Block -= 8;
                                monster.HitChance -= 10;
                                Combat.DoAttack(monster, player);
                                if (monster.Life <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou killed {0}\n", monster.Name);
                                    Console.ResetColor();
                                    reload = true;
                                }
                            }

                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("\nAnthrax! Run for your lives!!");
                            Combat.DoAttack(monster, player);
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
                            exit = true;
                            //reload = true;
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("\nPlayer Deets");
                            Console.WriteLine(player);
                            //Console.WriteLine("Monsters Defeated: " + score);

                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("\nMeunster Deets");
                            Console.WriteLine(monster);
                            //AND MAYBE SOME INSULTS??? OR A RANDOMIZER FOR THE BURGER OF THE DAY?
                            break;
                        default:
                            Console.WriteLine("\nI'm not risking any of those bugs getting into my peach cobbler no matter how stale it is. Try again!");
                            break;
                    }
                } while (!reload && !exit);


            } while (!exit);


            #endregion
            //            //TODO 11. Handle an attack sequence

            //            //TODO 12. Handle if the player wins

            //            //TODO 13. Monster getting a free attack

            //            //TODO 14. Exiting the inner loop and getting a new room

            //            //TODO 15. Print out Player info

            //            //TODO 16. print out monster info

            //            //TODO 17. Check the players life before continuing

            //    }

            //    }

        }//end main ()


        //public static string GetMonster()
        //{


        //    string monster = monsters[0];
        //    return monster;
        //}


    }//end Class
}//end class
//end namespace
