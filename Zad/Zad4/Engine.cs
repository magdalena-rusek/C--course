using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public abstract class Engine
    {
        private Fuel fuel1;

        public Fuel Fuel1
        {
            get { return fuel1; }
            set { fuel1 = value; }
        }

        public void CheckSupplies() 
        {
            fuel1.HowMuchLeft();
        }

        public Engine() 
        {
            fuel1 = new Fuel();
        }

        public virtual void OneDayOfTravel() 
        {
            fuel1.Amount -= 0.00001;
            Console.WriteLine("One Day Of Travel passed");
            CheckSupplies();
        }

        public virtual double Refill(double amount) 
        {
            return fuel1.Amount + amount; 
        }
    }
}