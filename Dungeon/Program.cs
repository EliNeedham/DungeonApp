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
            //TODO 1. Create a player
            //Louise
            //Bob
            //Tina
            //Linda
            //Gene

            //TODO 2. Create a weapon
            Weapon fryingPan = new Weapon(2, 8, "Frying Pan", 10, true);
            Weapon butcherKnife = new Weapon(2, 8, "Butcher's Knife", 6, false);
            Weapon rollingPin = new Weapon(2, 6, "Rolling Pin", 6, false);
            Weapon meatMan = new Weapon(0, 6, "Meat Man", 12, true);
            Weapon keyboard = new Weapon(2, 6, "Gene's Keyboard", 6, false);
            Weapon ninjaStar = new Weapon(4, 8, "Bob's credit card cut into a ninja star", 6, false);
            Weapon spatula = new Weapon(2, 4, "Burger Spatula", 16, false);
            Weapon cheeseGrater = new Weapon(2, 4, "Cheese Grater", 14, false);



            //TODO 3. Create a loopf or the room and the monster

            //TODO 4. Create a room
            //bob's burgers kitchen
            //the morgue
            //mr frond's classroom
            //the basement of bob's burgers
            //the food truck

            //TODO 5. Create a monster
            //Gayle
            //Mr Fischoeder
            //Mr Frond
            //Jimmy Pesto
            //Hugo the Health Inspector
            //Kenny Loggins - I know - we are crossing over here a bit from Archer, it's fine....

            //TODO 6. Create a loop for the menu of optino

            //TODO 7. Create a menu of options

            //TODO 8. Catch the user choice

            //TODO 9. Clear the Console

            //TODO 10. build out the switch for user choice

            //TODO 11. Handle an attack sequence

            //TODO 12. Handle if the player wins

            //TODO 13. Monster getting a free attack

            //TODO 14. Exiting the inner loop and getting a new room

            //TODO 15. Print out Player info

            //TODO 16. print out monster info

            //TODO 17. Check the players life before continuing



        }//end main ()

        private static string GetRoom()
        {
            //collection initialization syntax - we pass in values 
            //in canvas there is a room description generator module 4 dungeon room descriptions
            string[] rooms =
            {

            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
            //we could make this shorter
            //return rooms[new Random().Next(rooms.Lenrth)]; walk the line between good readable code and efficient
        }

    }//end Class
}//end class
}//end namespace
