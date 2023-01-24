using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class Crewmember : Human
    {
        public Crewmember(double s) : base(s)
        {
            Salary = s;
        }
    }
}