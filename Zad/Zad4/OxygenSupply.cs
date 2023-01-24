using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class OxygenSupply : IStorable
    {
        public double Amount { get; set; }
        public double MaxCapacity { get; set; }

        public void HowMuchLeft()
        {
            //Console.WriteLine("Maximum capasity is: " + MaxCapacity);
            Console.WriteLine("Available Oxygen Supply is: " + Amount);
        }

        public OxygenSupply(double capacity) 
        {
            MaxCapacity = capacity;
            Amount = 0;
        }
    }
}