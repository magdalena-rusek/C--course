using System;
using System.Collections.Generic;
using System.Text;

    class ClothesFurnitureFactory : FurnitureFactory
    {
    public Furniture CreateComfortable()
    {
        SlidingWardrobe wardrobe = new SlidingWardrobe(3000, "Comfortable");
        return wardrobe;
    }

    public Furniture CreateCheap()
    {
        Commode commode = new Commode(700, "Medium comfortable");
        return commode;
    }

}