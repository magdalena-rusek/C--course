using System;
using System.Collections.Generic;
using System.Text;

    class Bed : Furniture
    {
    public Bed()
    {
        Price = 0;
        Comfort = "";
    }

    public Bed(int price, string comfort)
    {
        Price = price;
        Comfort = comfort;
    }

    public override string ShowInfo()
    {
        return "This is bed.\nPrice: " + Price + " zl\nComfort: " + Comfort;
    }
}