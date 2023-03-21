using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters.MonsterFactories
{
    [Serializable]
    class BearFactory : MonsterFactory
    {
        // this factory produces bears (or evolved bears)

        private int encounterNumber = 0; 
        public override Monster Create(int playerLevel)
        {
            if (encounterNumber == 0) // if this is the first time, return a Bear
            {
                encounterNumber++;
                return new Bear(playerLevel);
            }
            else if (encounterNumber == 1) // if this is the second time, return a BearEvolved
            {
                encounterNumber++;
                return new BearEvolved(playerLevel);
            }
            else return null; // no more bears to fight
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber == 0) return new Bear(0).GetImage();
            else if (encounterNumber == 1) return new BearEvolved(0).GetImage();
            else return null;
        }
    }
}
