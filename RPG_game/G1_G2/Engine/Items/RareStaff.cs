using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items
{
    [Serializable]
    class RareStaff : Staff
    {
        public RareStaff() : base("item0010")
        {
            PublicName = "Rare Staff";
            PublicTip = "Magic Power higher by 0.5*strength and 40% lower fire damage - 5 * magic power damage / 20";
            GoldValue = 60;
            MgcMod = 30;
        }

        public override void ApplyBuffs(Engine.CharacterClasses.Player currentPlayer, List<string> otherItems)
        {
            currentPlayer.MagicPowerBuff += MgcMod + currentPlayer.Strength/2;
        }

        public override StatPackage ModifyDefensive(StatPackage pack, List<string> otherItems)
        {
            if (pack.DamageType == "fire")
            {
                pack.HealthDmg = 60 * pack.HealthDmg / 100 - 5 * pack.MagicPowerDmg / 20;
            }
            return pack;
        }
    }
}
