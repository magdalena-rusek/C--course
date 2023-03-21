using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;

namespace Game.Engine.Skills.ExtraSkills
{
    class ShieldGuardDecorator : SkillDecorator
    {
        public ShieldGuardDecorator(Skill skill) : base("Shield Guard", 30, 2, skill)
        {
            MinimumLevel = Math.Max(1, skill.MinimumLevel) + 2;
            PublicName = "COMBO - Rage: armor increase by 0.2 * player's stamina if precision is > 30 AND " + decoratedSkill.PublicName.Replace("COMBO: ", "");
            RequiredItem = "Axe";
        }

        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("incised");
            if (player.Precision > 30)
            {
                response.ArmorDmg = 20 / 100 * player.Stamina;
                response.CustomText = "You use Shield Guard! (+" + 20 / 100 * player.Stamina + " armor)";
            }
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(response);
            return combo;
        }
    }
}
