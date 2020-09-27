using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        //this class will not have fields, properties or any custom constructors, it is just a "warehouse" for different methods

        //one that controls overall battle seq - player attack monster - monster attack player

        //make method that handles indi attacks first

        public static void DoAttack(Character attacker, Character defender)
        //trying ot make it generic so that we can reuse for both player and attacker
        {
            //get random number from 1-100 as our dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(30);//paus to simulate battle
                                              //could haveadded using statment but only using it once
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))//take diff between attackers hit chance and dice roll but you could use random numbers instead. this is the place where you decide how you determine the way the battle goes
            {
                //the attacker hit
                int damageDealt = attacker.CalcDamage();

                //assign the damage
                defender.Life -= damageDealt;

                //write the result on to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
                //could put something funny in here about the battle
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} missed", attacker.Name);
            }
        }

        public static void DoBattle(Player player, Monster monster)
        {
            //player attacks first
            DoAttack(player, monster);

            //monster gets to attack next if they are still alive
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }






    }//end class
}//end namespace

