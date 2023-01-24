using System;
using System.Collections.Generic;
using System.Text;

class FindMax : MathsAlgorithm
{
    public double Calculate(List<double> list)
    {
        double k = 0;

        foreach (double d in list)
        {
            if (d > k)
            {
                k = d;
            }
        }
        return k;
    }
}