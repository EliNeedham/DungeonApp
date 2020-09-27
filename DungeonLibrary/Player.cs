using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public Flavor PlayerFlavor { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int life, int maxLife, Flavor playerFlavor, Weapon equippedWeapon)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            PlayerFlavor = playerFlavor;
            EquippedWeapon = equippedWeapon;

            //we will modify the HitChance of a Player based on their flavor
            switch (PlayerFlavor)
            {
                case Flavor.Louise:
                    HitChance += 5;
                    break;
                case Flavor.Bob:
                    break;
                case Flavor.Tina:
                    HitChance -= 4;
                    break;
                case Flavor.Linda:
                    break;
                case Flavor.Gene:
                    break;
                case Flavor.JimmyJunior:
                    break;
                case Flavor.CanadianJesus:
                    HitChance -= 5;
                    break;
                default:
                    break;
            }

        }

        //methods

        public override string ToString()
        {

            string description = "";

            switch (PlayerFlavor)
            {
                case Flavor.Louise:
                    description = "Louise Belcher. Louise is the kind of person who really thrives on chaos so she tries to start it in any way she can. A young girl with a pink bunny eared hat and dark pigtails. Intelligent, ruthless, maniacal, dramatic, and manipulative. Due to her adorable little girl façade, she’s able to easily gain the trust of anyone she wants and then turn on them like a viper. She’s also excellent at not taking the blame for any of her own horrible actions due to her ability to quickly transform from cold-blooded to cutesy.";
                    break;
                case Flavor.Bob:
                    description = "Bob Belcher. Chef and owner of Bob’s Burgers. He’s a good chef by almost all accounts and people often rave about the food but the restaurant still constantly teeters on the edge of closure. Bob just has rotten luck. His interests include: spaghetti westerns, anthropomorphizing things, puns, his own terrible jokes, and burgers. Levelheaded, honest, and goofy. Often emanates a quiet irritation, and no wonder as he is father to the Belcher children.";
                    break;
                case Flavor.Tina:
                    description = "Tina Belcher. Confident yet shy, awkward yet awesome, sweet yet sexual, prone to stage fright. Tina is full of contradictions. Her insterests include: horses, writing erotic fiction about her friends and classmates, hot zombies and boys. Often heard moaning or making strange noises (quite loudly) about something she has done to embarass herself. She's a pubescent girl with large spectacles, dark hair and a single beret always worn on the same side.";
                    break;
                case Flavor.Linda:
                    description = "Linda Belcher. Eccentric, loud, excitable and suffers from foot in mouth syndrome. She loves hosting parties, bed and breakfasts, dinner theater, her kids, Bob, singing, small talk, and booze. In her own words: “Mommy doesn’t get drunk. Mommy has fun.” Lida is happy, kind, loving, and caring. Usually wearing an apron, with large horn rimmed red glasses, long black hair and very intense eyes. She can't french braid or whistle.";
                    break;
                case Flavor.Gene:
                    description = "Gene Belcher. Annoying, funny, and downright strange. Gene has about the same amount of regard for social convention as he has for nutrition. His interests include: playing the keyboard, pulling pranks, bodily functions, eating, sound effects, and jokes. Gene has an interest in performance art and dreams of being a musician – he believes that the highest calling in the world is to design catchy commercial jingles. Often wearing a hamburger body suit, a portly little boy with no regard for personal hygiene - which to him is a greeting...";
                    break;
                case Flavor.JimmyJunior:
                    description = "Jimmy Pesto Junior. Works as the busboy at Jimmy Pesto's Pizzeria. He is Tina's classmate, love interest and on-again, off-again boyfriend. He has a noticeable speech impediment, and loves dancing. He appears to be among the most popular students at Wagstaff Middle School. He is a blond pubescent boy, wearing pants he won't rip when he wants to bust a move.";
                    break;
                case Flavor.CanadianJesus:
                    description = "Canadian Jesus. A Centriq Class of December 2020 favoite. Bearded, wood working and wearing denim robes with a hint of flannel. The perfect addition to any game.";
                    break;            
            }

            return string.Format("******** {0} ***********\nLife: {1} of {2}\nHit Chance: {3}%\nWeapon: {4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                EquippedWeapon,
                Block,
                description);
        }

        public override int CalcDamage()
        {
            // return base.CalcDamage(); we don't want to return 0 which is what this will do
            //create random objet
            Random rand = new Random();

            //determine the damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //by using the . we get access to the mindamage or maxdamage that are assigned to equippedweapon

            //return the damage
            return damage;

        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
            //player can increase this - weapon
        }

    }//end class 
}//end namespace
