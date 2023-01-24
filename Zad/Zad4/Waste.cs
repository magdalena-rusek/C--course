using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class Waste : IStorable
    {
        string name;
        public double Amount { get; set; }

        public void HowMuchLeft() 
        {
            Console.WriteLine("Available Waste " + name + " is: " + Amount);
        }

        public Waste(string s) 
        {
            name = s;
        }
    }
}