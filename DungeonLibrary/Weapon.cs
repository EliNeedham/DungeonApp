using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        //define property for every field

        //properties
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        //set rule to protect data for the min hit range thign
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //need to make sure that the value can't be more than max damage and con't be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    //tried to pass value that didn't fit
                    _minDamage = 1;
                }
            }
        }

        //contructors
        //fully qualifid constructor (FQCTOR)
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)//ctor tab tab shortcut
        {
            //if you have properties that have business rules that tely on other properties, you must set the other's property's value first - min damage relies on max damage so we had to do max first
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            IsTwoHanded = isTwoHanded;
        }

        //no default ctor here, we do not want to allow anyone to create an empty weapon. 
        //you only have to have one constructor

        //methods

        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\nBonus Hit: {3}% \t{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                IsTwoHanded ? "Two handed" : "One-Handed");
        }

    }//class Method ()
}//end Namespcae
