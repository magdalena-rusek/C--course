using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class Scientist : Human
    {
        public ScientificProbe MyProbe { get; set; }

        public Scientist(double s) : base(s)
        {
            Salary = s;
        }

        public void Work() 
        {
            Console.WriteLine("Scientist: 'I am working...'");
            MyProbe.Conserve();
        }
    }
}