using System;
using System.Collections.Generic;
using System.Text;

    class Sofa : Furniture
    {
    public Sofa()
    {
        Price = 0;
        Comfort = "";
    }

    public Sofa(int price, string comfort)
    {
        Price = price;
        Comfort = comfort;
    }

    public override string ShowInfo()
    {
        return "This is sofa.\nPrice: " + Price + " zl\nComfort: " + Comfort;
    }
}