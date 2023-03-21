using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class Bear : Monster
    {
        // example monster: bear
        public Bear(int bearLevel)
        {
            Health = 40 + 8 * bearLevel;
            Strength = 11 + bearLevel;
            Armor = 0;
            Precision = 59;
            MagicPower = 0;
            Stamina = 55;
            XPValue = 40 + 2 * bearLevel;
            Name = "monster0003";
            BattleGreetings = "Roooaaaaar";
        }

        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 20;
                return new List<StatPackage>() { new StatPackage("incised", 20 + Strength, "Bear uses Scratch and Bite! (" + (20 + Strength) + " incised damage)") };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Bear has no energy to attack anymore!") };
            }
        }
    }
}
