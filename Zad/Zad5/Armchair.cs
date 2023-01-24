using System;
using System.Collections.Generic;
using System.Text;

    class Armchair : Furniture
    {
    public Armchair()
    {
        Price = 0;
        Comfort = "";
    }

    public Armchair(int price, string comfort)
    {
        Price = price;
        Comfort = comfort;
    }

    public override string ShowInfo()
    {
        return "This is armchair.\nPrice: " + Price + " zl\nComfort: " + Comfort;
    }
}