using System;
using System.Collections.Generic;
using System.Text;

    class Chair : Furniture
    {
    public Chair()
    {
        Price = 0;
        Comfort = "";
    }

    public Chair(int price, string comfort)
    {
        Price = price;
        Comfort = comfort;
    }

    public override string ShowInfo()
    {
        return "This is chair.\nPrice: " + Price + " zl\nComfort: " + Comfort;
    }
}