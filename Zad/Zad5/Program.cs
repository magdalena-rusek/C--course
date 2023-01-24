using System;
using System.Collections.Generic;
using System.Text;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> myFurniture = new List<Furniture>();

            SleepFurnitureFactory myFactory1 = new SleepFurnitureFactory();
            ClothesFurnitureFactory myFactory2 = new ClothesFurnitureFactory();
            SeatFurnitureFactory myFactory3 = new SeatFurnitureFactory();

            myFurniture.Add(myFactory1.CreateComfortable());
            myFurniture.Add(myFactory2.CreateCheap());
            myFurniture.Add(myFactory3.CreateCheap());

            foreach(Furniture f in myFurniture)
            {
                Console.WriteLine(f.ShowInfo()+"\n");
            }
        }
    }
}
