using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class Captain : Human
    {
        public Captain(double s) : base(s) 
        {
            Salary = s;
        }
    }
}