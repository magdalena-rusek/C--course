using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.ItemFactories
{
    [Serializable]
    class StaffFactory : ItemFactory
    {
        // produce Staff types /items
        public Item CreateItem()
        {
            List<Item> itemStaff = new List<Item>()
            {
                new BasicStaff(),
                new GreatStaff(),
                new RareStaff(),
                new EpicStaff()
            };
            return itemStaff[Index.RNG(0, itemStaff.Count)];
        }
        public Item CreateNonMagicItem()
        {
            return null;
        }
        public Item CreateNonWeaponItem()
        {
            return null;
        }
    }
}
