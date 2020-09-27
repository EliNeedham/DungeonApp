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
        public bool HasMrBusiness { get; set; }
        public bool ABS { get; set; }
        public bool IsPopular { get; set; }
        public bool CanShutDownYourBusiness { get; set; }
        public bool CanEvictYou { get; set; }
        public bool DangerZone { get; set; }

        public MonsterMaster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool hasMrBusiness, bool aBS, bool isPopular, bool canShutDownYourBusiness, bool canEvictYou, bool dangerZone) :base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description) 
        {
            HasMrBusiness = hasMrBusiness;
            ABS = aBS;
            IsPopular = isPopular;
            CanShutDownYourBusiness = canShutDownYourBusiness;
            CanEvictYou = canEvictYou;
            DangerZone = dangerZone;
        }

        public MonsterMaster()
        {

        }

        public override string ToString()
        //{
        //    return base.ToString() +
        //                    HasMrBusiness  +
        //                    //== false ? " " : HasMrBusiness tried to figure out if we coudl turn what prints out on or off based on bool being true or not
        //                    ABS +
        //                    IsPopular +
        //                    CanShutDownYourBusiness  +           
        //                    CanEvictYou +
        //                    DangerZone;
        //}
        {
            //return base.ToString() + $"{!HasMrBusiness ? " " : HasMrBusiness";
                            //== false ? " " : HasMrBusiness tried to figure out if we coudl turn what prints out on or off based on bool being true or not
                            //ABS +
                            //IsPopular +
                            //CanShutDownYourBusiness +
                            //CanEvictYou +
                            //DangerZone;
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (HasMrBusiness || IsPopular)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;

        }

        
    }//end class
}//end namespace
