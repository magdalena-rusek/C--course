using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items
{
    [Serializable]
    class EpicStaff : Staff
    {
        public EpicStaff() : base("item0011")
        {
            PublicName = "Epic Staff";
            PublicTip = "Magic Power higher by 2*Strength and (10% less damage if magic damage) or (45% less damage if other damage)";
            GoldValue = 70;
            MgcMod = 55;
        }

        public override void ApplyBuffs(Engine.CharacterClasses.Player currentPlayer, List<string> otherItems)
        {
            currentPlayer.MagicPowerBuff += MgcMod + 2 * currentPlayer.Strength;
        }

        public override StatPackage ModifyDefensive(StatPackage pack, List<string> otherItems)
        {
            if (pack.DamageType == "poison")
            {
                pack.HealthDmg = 55 * pack.HealthDmg / 100;
            }
            else if(pack.DamageType == "fire" || pack.DamageType == "water" || pack.DamageType == "air" || pack.DamageType == "earth")
            {
                pack.HealthDmg = 90 * pack.HealthDmg / 100;
            }
            return pack;
        }
    }
}
