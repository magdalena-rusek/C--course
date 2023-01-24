using System;
using System.Collections.Generic;
using System.Text;

class VisitCommand : ICommand
{
    TouristAttraction attract;
    int hour;

    public VisitCommand(TouristAttraction _attract, int _hour)
    {
        attract = _attract;
        hour = _hour;
    }

    public void Execute()
    {
        attract.ReserveTicket();
        attract.VisitHour(hour);
    }
}