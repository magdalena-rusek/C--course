using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class ScientificProbe : ITool
    {
        public void Conserve() 
        {
            Console.WriteLine("I am conserving scientific probe...");
        }

        public void GatherData() 
        {
            Console.WriteLine("I am gathering data...");
        }
    }
}