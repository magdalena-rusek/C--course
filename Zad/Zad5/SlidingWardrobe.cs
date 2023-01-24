using System;
using System.Collections.Generic;
using System.Text;

    class SlidingWardrobe : Furniture
    {
    public SlidingWardrobe()
    {
        Price = 0;
        Comfort = "";
    }

    public SlidingWardrobe(int price, string comfort)
    {
        Price = price;
        Comfort = comfort;
    }

    public override string ShowInfo()
    {
        return "This is sliding wardrobe.\nPrice: " + Price + " zl\nComfort: " + Comfort;
    }
}
