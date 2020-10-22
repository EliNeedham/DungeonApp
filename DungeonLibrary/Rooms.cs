using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Rooms
    {
        public static string GetRoom()
        {
            //collection initialization syntax - we pass in values 
            //in canvas there is a room description generator module 4 dungeon room descriptions
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

            string room = rooms[0];
            return room;


            //Random rand = new Random();
            //int indexNbr = rand.Next(rooms.Length);
            //string room = rooms[indexNbr];
            //return room;


        }
    }// end class
}// end namespace
