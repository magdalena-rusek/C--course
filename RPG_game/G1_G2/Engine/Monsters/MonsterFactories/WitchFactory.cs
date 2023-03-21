using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters.MonsterFactories
{
    [Serializable]
    class WitchFactory : MonsterFactory
    {
        // this factory produces witches (or evolved witches)

        private int encounterNumber = 0; 
        public override Monster Create(int playerLevel)
        {
            if (encounterNumber == 0) // if this is the first time, return a Witch
            {
                encounterNumber++;
                return new Witch(playerLevel);
            }
            else if (encounterNumber == 1) // if this is the second time, return a WitchEvolved
            {
                encounterNumber++;
                return new WitchEvolved(playerLevel);
            }
            else return null; // no more witches to fight
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber == 0) return new Witch(0).GetImage();
            else if (encounterNumber == 1) return new WitchEvolved(0).GetImage();
            else return null;
        }
    }
}