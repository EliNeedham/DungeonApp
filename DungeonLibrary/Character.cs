using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
            
        //fields
        private int _life;

        //properties
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                //biz rule life should not be more than max life
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }

            }
        }

        //ctors
        //since we do not inherit ctors we will not create any here we will still get the default parameterless ctro, however bc this class is abstract we will NOT be able to create an instance of Character

        //single soruce of truth for properties that are shared between player and monster

        //methods
        //no noeed to override the two string not creating instances of character
        //belw we will dfine methods that we want to be inherited by player and monster so we are creating default versions of each method here. the child classes wil either use this defaul functionality or overide it to create custom functionality.

        public virtual int CalcBlock()
        {
            //to be able to override this in a child class, we MUST make it virtual
            //This basic version will just return BLock property. Child classes will modify
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
            //this functionality will be customized in Child Classes. 
        }
    }//end class
}// end namespace
