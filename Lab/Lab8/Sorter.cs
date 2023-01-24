using System;
using System.Collections.Generic;
using System.Text;

class Sorter
{
    SortingAlgorithm strategy;

    public void SetAlgorithm(SortingAlgorithm _algorithm)
    {
        strategy = _algorithm;
    }

    public List<int> Sort(List <int> list)
    {
        return strategy.Sort(list);
    }
}