using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;

namespace Game.Engine.Skills.ExtraSkills
{
    [Serializable]
    class Rage : Skill
    {
        public Rage() : base("Rage", 12, 2)
        {
            PublicName = "Rage: 50 more damage with health less than 40 [stab]";
            RequiredItem = "Axe";
        }

        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("stab");
            if(player.Health < 40)
            {
                response.HealthDmg = 50;
                response.CustomText = "You use Rage! (" + 50 + "stab damage)";
            }
            return new List<StatPackage>() { response };
        }
    }
}
