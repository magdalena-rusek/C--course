using System;
using System.Collections.Generic;
using System.Text;

class Context
{
    MathsAlgorithm strategy;

    public void SetAlgorithm(MathsAlgorithm _strategy)
    {
        strategy = _strategy;
    }

    public double Calculate(List <double> list)
    {
        return strategy.Calculate(list);
    }
}