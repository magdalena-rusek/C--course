using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class BearEvolved : Monster
    {
        // example monster: evolved bear - with fire
        public BearEvolved(int bearLevel)
        {
            Health = 85 + 8 * bearLevel;
            Strength = 35 + bearLevel;
            Armor = 15;
            Precision = 59;
            MagicPower = 0;
            Stamina = 87;
            XPValue = 45 + 2 * bearLevel;
            Name = "monster0004";
            BattleGreetings = "Roooaaaaar! You defeated me but now I'm back with fire!";
        }

        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 20;
                return new List<StatPackage>()
                {
                    new StatPackage("incised", 20 + Strength, "Bear uses Scratch and Bite! (" + (20 + Strength) + " incised damage)"),
                    new StatPackage("fire", 20, "Fire burns you")
                };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Bear has no energy to attack anymore!") };
            }
        }
    }
}
