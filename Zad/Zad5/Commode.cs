using System;
using System.Collections.Generic;
using System.Text;

    class Commode : Furniture
    {
    public Commode()
    {
        Price = 0;
        Comfort = "";
    }

    public Commode(int price, string comfort)
    {
        Price = price;
        Comfort = comfort;
    }

    public override string ShowInfo()
    {
        return "This is commode.\nPrice: " + Price + " zl\nComfort: " + Comfort;
    }
}