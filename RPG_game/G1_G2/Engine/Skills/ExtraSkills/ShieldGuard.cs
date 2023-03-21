using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;

namespace Game.Engine.Skills.ExtraSkills
{
    [Serializable]
    class ShieldGuard : Skill
    {
        public ShieldGuard() : base("Shield Guard", 30, 2)
        {
            PublicName = "Shield Guard: armor increase by 0.2 * player's stamina if precision is > 30 [incised]";
            RequiredItem = "Sword";
        }

        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("incised");
            if (player.Precision > 30)
            {
                response.ArmorDmg = 20 / 100 * player.Stamina;
                response.CustomText = "You use Shield Guard! (" + 20 / 100 * player.Stamina + " armor)";
            }
            return new List<StatPackage>() { response };
        }
    }
}
