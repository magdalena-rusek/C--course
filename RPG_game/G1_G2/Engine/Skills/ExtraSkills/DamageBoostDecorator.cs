using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;

namespace Game.Engine.Skills.ExtraSkills
{
    class DamageBoostDecorator : SkillDecorator
    {
        public DamageBoostDecorator(Skill skill) : base("Damage Boost", 15, 2, skill)
        {
            MinimumLevel = Math.Max(1, skill.MinimumLevel) + 2;
            PublicName = "COMBO - Rage: icreases damage by 15% [stab] AND " + decoratedSkill.PublicName.Replace("COMBO: ", "");
            RequiredItem = "Spear";
        }

        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("stab");
            response.HealthDmg = response.HealthDmg * 15 / 100;
            response.CustomText = "You use Damage Boost! (" + response.HealthDmg * 15 / 100 + "stab damage)";
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(response);
            return combo;
        }
    }
}
