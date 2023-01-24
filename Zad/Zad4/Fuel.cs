using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class Fuel : IStorable
    {
        public double Amount { get; set; }

        public void HowMuchLeft()
        {
            Console.WriteLine("Available Fuel is: " + Amount);
        }
    }
}