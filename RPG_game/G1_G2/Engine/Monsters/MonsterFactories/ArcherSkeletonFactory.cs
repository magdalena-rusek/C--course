using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters.MonsterFactories
{
    [Serializable]
    class ArcherSkeletonFactory : MonsterFactory
    {
        // this factory produces archer skeletons (or evolved archer skeletons)

        private int encounterNumber = 0; 
        public override Monster Create(int playerLevel)
        {
            if (encounterNumber == 0) // if this is the first time, return a ArcherSkeleton
            {
                encounterNumber++;
                return new ArcherSkeleton(playerLevel);
            }
            else if (encounterNumber == 1) // if this is the second time, return a ArcherSkeletonEvolved
            {
                encounterNumber++;
                return new ArcherSkeletonEvolved(playerLevel);
            }
            else return null; // no more Archer Skeletons to fight
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber == 0) return new ArcherSkeleton(0).GetImage();
            else if (encounterNumber == 1) return new ArcherSkeletonEvolved(0).GetImage();
            else return null;
        }
    }
}
