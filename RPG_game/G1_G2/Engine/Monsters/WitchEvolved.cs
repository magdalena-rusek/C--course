using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class WitchEvolved : Monster
    {
        // example monster: witch evolved - with hurricane
        public WitchEvolved(int witchLevel)
        {
            Health = 100 + 8 * witchLevel;
            Strength = 60 + witchLevel;
            Armor = 0;
            Precision = 90;
            MagicPower = 70;
            Stamina = 75;
            XPValue = 80 + witchLevel;
            Name = "monster0008";
            BattleGreetings = "Ha ha haaa... <scary laughter> \nYou defeated me but now I'm back with hurricane!";
        }

        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                return new List<StatPackage>() 
                {
                    new StatPackage("fire", MagicPower + 3, "Witch uses Magic Wand! (" + (MagicPower + 3) + " fire damage)"),
                    new StatPackage("air", 30, "You are kidnapped by hurricanes")
                };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Witch has no energy to attack anymore!") };
            }
        }
    }
}