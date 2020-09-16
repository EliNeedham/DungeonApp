using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //fields
        //propfull tab tab
        private int _minDamage;

        //properties
        public int MaxDamage { get; set; }

        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //need mindamage to not be more than ourmax
                //can't be more than maxdamage and cannot be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    //if you tried to set a value outside of our range
                    _minDamage = 1;
                }
            }
        }

        //minilab create default and fqctor for monster - remember the assignment order inside of the fq ctor matters

        public Monster()
        {
            //default ctor
        }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            //fq ctor - need to accept parameters for ALL of the properties
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            Description = description;
        }

        //methods

        public override string ToString()
        {
            return string.Format("\n****** MONSTER ************\n{0}\nLife: {1} of {2}\nDamage: {3} to {4}\nBlock: {5}\nDescription: \n{6}\n",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                Block,
                Description);
        }

        //method that we inherited from character - able to override it bc of virutal keyword - it says you CAN override but dno't have to - abstract says you have to inherit and override for it to work. 

        //we are overriding the CalcDamage() to use the properties of MinDamage and MaxDamage
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
            //if we had a monster that had a min of 2 and a max of 8, if we passed MinDamage, MaxDamage then we would never be able to get back 8.This is because the max value in the NExt() is exclusive
        }

    }//end class
}//end namespace
