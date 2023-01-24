using System;
using System.Collections.Generic;
using System.Text;

    class SleepFurnitureFactory : FurnitureFactory
    {
    public Furniture CreateComfortable()
    {
        Bed bed = new Bed(4000, "Very comfortable");
        return bed;
    }

    public Furniture CreateCheap()
    {
        Sofa sofa = new Sofa(800, "Uncomfortable");
        return sofa;
    }

}