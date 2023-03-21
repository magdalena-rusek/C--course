using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items
{
    [Serializable]
    class GreatStaff : Staff
    {
        public GreatStaff() : base("item0009")
        {
            PublicName = "Great Staff";
            PublicTip = "Magic Power higher by 0.1*strength and 14% lower damage";
            GoldValue = 50;
            MgcMod = 20;
        }
        public override void ApplyBuffs(Engine.CharacterClasses.Player currentPlayer, List<string> otherItems)
        {
            currentPlayer.MagicPowerBuff += MgcMod + currentPlayer.Strength / 10;
        }

        public override StatPackage ModifyOffensive(StatPackage pack, List<string> otherItems)
        {
            pack.HealthDmg = 86 * pack.HealthDmg / 100;

            return pack;
        }
    }
}
