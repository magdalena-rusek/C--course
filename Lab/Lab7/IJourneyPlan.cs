using System;
using System.Collections.Generic;
using System.Text;

interface IJourneyPlan
{
    public void Run(List<ICommand> items);
}