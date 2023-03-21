using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class Witch : Monster
    {
        // example monster: witch
        public Witch(int witchLevel)
        {
            Health = 90 + 8 * witchLevel;
            Strength = 54 + witchLevel;
            Armor = 0;
            Precision = 81;
            MagicPower = 50;
            Stamina = 87;
            XPValue = 70 + witchLevel;
            Name = "monster0007";
            BattleGreetings = "Ha ha haaa... <scary laughter>";
        }

        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                return new List<StatPackage>() { new StatPackage("fire", MagicPower + 3, "Witch uses Magic Wand! (" + (MagicPower + 3) + " fire damage)") };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Witch has no energy to attack anymore!") };
            }
        }
    }
}