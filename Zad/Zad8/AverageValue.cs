using System;
using System.Collections.Generic;
using System.Text;

class AverageValue : MathsAlgorithm
{
    public double Calculate(List<double> list)
    {
        double sum = 0.0;
        int numberElements = 0;

        foreach (double d in list)
        {
            sum += d;
            numberElements++;
        }

        return sum / numberElements;
    }
}