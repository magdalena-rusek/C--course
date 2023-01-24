using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class FoodSupply : IStorable
    {
        public double Amount { get; set; }

        public void HowMuchLeft()
        {
            Console.WriteLine("Available Food Supply is: " + Amount);
        }
    }
}