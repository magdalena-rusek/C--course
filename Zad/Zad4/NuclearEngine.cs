using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class NuclearEngine : Engine
    {
        private Waste nuclearWaste;

        public new void CheckSupplies() 
        {
            Fuel1.HowMuchLeft();
            Console.Write("Nuclear waste: ");
            nuclearWaste.HowMuchLeft();
        }

        public NuclearEngine() : base()
        {
            Waste w = new Waste("");
            nuclearWaste = w;
        }

        public override void OneDayOfTravel()
        {
            Fuel1.Amount -= 1.2;
            Console.WriteLine("One Day Of Travel passed");
            CheckSupplies();
        }

        public override double Refill(double amount)
        {
            return Fuel1.Amount + amount;
        }
    }
}