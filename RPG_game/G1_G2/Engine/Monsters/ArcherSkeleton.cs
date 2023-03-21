using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class ArcherSkeleton : Monster
    {
        // example monster: archer skeleton

        public ArcherSkeleton(int archerLevel)
        {
            Health = 62 + 6 * archerLevel;
            Strength = 20 + archerLevel;
            Armor = 8;
            Precision = 90;
            MagicPower = 5;
            Stamina = 65;
            XPValue = 45 + 2 * archerLevel;
            Name = "monster0005";
            BattleGreetings = "I'am immortal";
        }

        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 15;
                return new List<StatPackage>() { new StatPackage("stab", 10 + Precision, "ArcherSkeleton uses Arrow! (" + (10 + Precision) + " stab damage)") };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "ArcherSkeleton has no energy to attack anymore!") };
            }
        }
    }
}