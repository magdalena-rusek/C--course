using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class ArcherSkeletonEvolved : Monster
    {
        // example monster: archer skeleton evolved - with freeze

        public ArcherSkeletonEvolved(int archerLevel)
        {
            Health = 85 + 6 * archerLevel;
            Strength = 24 + archerLevel;
            Armor = 12;
            Precision = 95;
            MagicPower = 5;
            Stamina = 80;
            XPValue = 47 + 2 * archerLevel;
            Name = "monster0006";
            BattleGreetings = "You defeated me but now I'm back with freeze!";
        }

        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 15;
                return new List<StatPackage>() 
                { 
                    new StatPackage("stab", 10 + Precision, "ArcherSkeleton uses Arrow! (" + (10 + Precision) + " stab damage)"),
                    new StatPackage("freeze", 8, "Cold spreads over your body (8 freeze damage)")
                };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "ArcherSkeleton has no energy to attack anymore!") };
            }
        }
    }
}