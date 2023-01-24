using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public interface IStorable
    {
        public double Amount { get; set; }

        void HowMuchLeft();
    }
}