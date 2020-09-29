using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonMonster
{
    public class MonsterMaster : Monster
    {
        //TODO I wanted to give the monsters superpowers here but it seems like I would need to create more than block and hit chance etc in order to really have the superpowers do anything. I might take this out based on how far I get
        public bool AcceptsBribes { get; set; }
        public bool EasilyInsulted { get; set; }

        public MonsterMaster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool acceptsBribes, bool easilyInsulted) :base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description) 
        {
            AcceptsBribes = acceptsBribes;
            EasilyInsulted = easilyInsulted;

        }

        public MonsterMaster()
        {

        }

        public override string ToString()
        {
            return string.Format("\n*******************************************************************************\n" +
                                 "\n               " + Name + "                       \n" +
                                 "\n" + Description + " \n\n" +
                                 "Life: " + Life + "\nMin Damage: " + MinDamage +
                                 "\nMax Damage: " + MaxDamage + "\nBlock: " + Block + "\n");

        }

     // =============9.28.20 after convo with Jared not sure I need to override the calcblock below, just need to set up the bribe and insult if else statements inside the switch for player choice on attack options etc

    //public override int CalcBlock()
    //    {
    //        int calculatedBlock = Block;
    //        if (HasMrBusiness || IsPopular)
    //        {
    //            calculatedBlock += calculatedBlock / 2;
    //        }
    //        return calculatedBlock;

    //    }

        
    }//end class
}//end namespace
