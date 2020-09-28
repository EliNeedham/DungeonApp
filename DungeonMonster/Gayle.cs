using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonMonster
{
    public class Gayle : Monster
    {

        public Weapon EquippedWeapon { get; set; }

        //ctors

        //we can use the constructor from the monster class
        public Gayle(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, Weapon equippedWeapon) : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            EquippedWeapon = equippedWeapon;
        }

        //set some values for a basic monster of this type in the default ctor
        public Gayle()
        {
            //default ctor no parameters
            //set some basic values - want to do this to quickly create a monster in a game that always has the same values
            MaxLife = 10;
            MaxDamage = 3;
            Name = "Gayle";
            Life = 5;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "A bespectacled, fanny pack wearing, incredibly gullible cat lady who happens to be Linda’s younger sister. Emotionally fragile, marginally confused and destined to be single - even going so far as to play pretend every night before bed that she's taking shelter from a nuclear apocalypse in which she is the sole survivor, \"especially the men, so it's okay to sleep alone.\"  Her three cats are looking daggers at you, Jean Paw'd Van Damme, Pinkeye and Mr.Business – who really means business.";
            EquippedWeapon = mrBusiness;
        }

        //methods
        //override the calcblock to say if they are fluffy they will get a bonus of 50% to their block

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2; //takign half the value of what is already there
            }
            return calculatedBlock;
        }

    }//end class
}//end namespace
