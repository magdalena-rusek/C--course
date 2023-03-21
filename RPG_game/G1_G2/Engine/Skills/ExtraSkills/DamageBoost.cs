using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;

namespace Game.Engine.Skills.ExtraSkills
{
    [Serializable]
    class DamageBoost : Skill
    {
        public DamageBoost() : base("Damage Boost", 15, 2)
        {
            PublicName = "Damage Boost: icreases damage by 15% [stab]";
            RequiredItem = "Spear";
        }

        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("stab");
            response.HealthDmg = response.HealthDmg * 15 / 100;
            response.CustomText = "You use Damage Boost! (" + response.HealthDmg * 15 / 100 + "stab damage)";
            return new List<StatPackage>() { response };
        }
    }
}
