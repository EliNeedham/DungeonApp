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
            //TODO 2. Create a weapon
            Weapon fryingPan = new Weapon(2, 8, "Frying Pan", 10, true);
            Weapon mapleSyrup = new Weapon(2, 8, "A squeezer bottle full of maple syrup", 6, false);
            Weapon rollingPin = new Weapon(2, 6, "Rolling Pin", 6, false);
            Weapon meatMan = new Weapon(0, 6, "Meat Man", 12, true);
            Weapon keyboard = new Weapon(2, 6, "Gene's Keyboard", 6, false);
            Weapon ninjaStar = new Weapon(4, 8, "Bob's credit card cut into a ninja star", 6, false);
            Weapon spatula = new Weapon(2, 4, "Burger Spatula", 16, false);
            Weapon cheeseGrater = new Weapon(2, 4, "Cheese Grater", 14, false);

            //TODO 1. Create a player
            //Louise
            //Bob
            //Tina
            //Linda
            //Gene
            //20 sided di 1-20 is hit chance - if you have block of 20 then you have to roll at least a 10 to even hit them - you could add armor to make yourself hard to hit, block - damage absorption is 
            //
            Player pLouise = new Player("Louise Belcher", 79, 4, 40, 40, Flavor.Louise, ninjaStar);
            Player pBob = new Player("Bob Belcher", 65, 8, 36, 40, Flavor.Bob, spatula);
            Player pTina = new Player("Tina Belcher", 65, 8, 40, 40, Flavor.Tina, meatMan);
            Player pLinda = new Player("Linda Belcher", 70, 6, 40, 40, Flavor.Linda, rollingPin);
            Player pGene = new Player("Gene Belcher", 63, 10, 40, 40, Flavor.Gene, keyboard);
            Player pJimmyJunior = new Player("Jimmy Junior", 63, 6, 38, 40, Flavor.JimmyJunior, cheeseGrater);
            Player pCanadianJesus = new Player("Canadian Jesus", 70, 4, 40, 48, Flavor.CanadianJesus, mapleSyrup);


            //TODO 3. Create a loop for the room and the monster

            //TODO 4. Create a room
            //bob's burgers kitchen
            //the morgue
            //mr frond's classroom
            //the basement of bob's burgers
            //the food truck

            Console.WriteLine(GetRoom());//TODO this might need to be changed later in order to assign a specific monster to a room - not sure how to do that yet

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
            {"You find yourself on the grounds of a 2.5 story Victorian manor house with a tower centered above the front doors. Most noticeable, the formal garden with eerily lit statues, an overgrown hedge maze (from which strange lonely sounds are emanating), a tree house (where Felix lives due to being kicked out of the main house because of his sleep apnea), and a field out back where old, broken Wonder Wharf rides are kept. The only thing more terrifying than a carnival ride, is a broken one. Who are we kidding, they're all broken the workers just don't tell you about how little Davey fell off last week due to faulty wiring... That’s right, you’re at Mr Fischoeder’s Mansion!",
            "You are greeted with the dulcet tones of synth music, billowing fog swirls around your legs and floating circles of light wander along the walls reflecting off the disco ball suspended from the ceiling tiles. You’re affronted by the sickly-sweet smell of the smoke machine (most likely purchased from What the Tech Superstore). That’s right, it’s Tina’s 13th birthday party. It’s a boy/girl party, with mingling. Gene is djing, “Come on boys, you’re the peanut butter. Girls, you’re the jelly. Let’s make some sandwiches!” You ask yourself, “What's The Worcestershire That Could Happen?”",
            "You're in Mr Frond's office (guidance counselor). Enter Mr Frond, “Attention! There has been a grisly crime committed in my office! (If looks could kale you'd already be dead.) My therapy dolls have been mutilated\" Theo Theo’s stuffing has been ripped out and he is hanging from the ceiling from his yarntrails. Lynne Secure is now finally secured – to the desk – at least what’s left of her….. Pierre Pressure suffered a similar end. The others will have to be identified from yarn records What sick twisted, but really creative kid did this?   Beets Me!",
            "A very distinct crooning fills your ears. Crooning? Maybe we should’ve said screeching… Linda is on a makeshift stage in the diner, swinging a microphone around at the diners in a concerning and slightly aggressive display. You interrupt her favorite number – her wrath and twisted creative genius is now turned toward you. Dinner Theater has created a Muenster",
            "Welcome to the freezer dome! It's the Final Kraut Down. You’re dressed in 80’s wrestling gear, a pink leather vest, fuchsia feather boa, a sequined cowboy hat and well, best not to describe the rest… The Belcher children have turned the walk in cooler of Bob’s Burger’s into an ice-skating rink by sneakind down in the middle of the night to dump water on the freezer floor..... The newly dubbed freezer dome is now a fight club slip show. Two kids enter – one kid leaves!",
            "You enter a dark, cold room. The basement of Bob’s Burgers. Spanning the walls all around are shelves filled with…. Pickled things. Mostly…. oh, mostly pickles. There is a meat grinder on a table in the center, one wrong move could lead to onion-tended consequences….",

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
