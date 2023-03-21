using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;

namespace Game.Engine.Skills.ExtraSkills
{
    [Serializable]
    class RageDecorator : SkillDecorator
    {
        public RageDecorator(Skill skill) : base("Rage", 12, 2, skill)
        {
            MinimumLevel = Math.Max(1, skill.MinimumLevel) + 2;
            PublicName = "COMBO - Rage: 50 more damage with health less than 40 [stab] AND " + decoratedSkill.PublicName.Replace("COMBO: ", "");
            RequiredItem = "Axe";
        }

        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("stab");
            if (player.Health < 40)
            {
                response.HealthDmg = 50;
                response.CustomText = "You use Rage! (" + 50 + "stab damage)";
            }
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(response);
            return combo;
        }
    }
}
