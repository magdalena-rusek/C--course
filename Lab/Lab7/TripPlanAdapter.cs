using System;
using System.Collections.Generic;
using System.Text;

class TripPlanAdapter : IJourneyPlan
{
    public void Run(List <ICommand> items)
    {
        TripPlan plan = new TripPlan();

        foreach (ICommand com in items)
        {
            plan.Add(com);
        }

        plan.Run();

    }
}