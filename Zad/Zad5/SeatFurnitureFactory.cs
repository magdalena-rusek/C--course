using System;
using System.Collections.Generic;
using System.Text;

    class SeatFurnitureFactory: FurnitureFactory
    {
    public Furniture CreateComfortable() 
    {
        Armchair armchair = new Armchair(600, "Comfortable");
        return armchair;
    }

    public Furniture CreateCheap()
    {
        Chair chair = new Chair(100, "Uncomfortable");
        return chair;
    }

}