using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class DieselEngine : Engine
    {
        public override void OneDayOfTravel() 
        {
            Fuel1.Amount -= 2.0;
            Console.WriteLine("One Day Of Travel passed");
            CheckSupplies();
        }

        public override double Refill(double amount) 
        {
            return Fuel1.Amount + amount;
        }
    }
}
