using System;
using System.Collections.Generic;
using System.Text;

class SleepCommand : ICommand
{
    TouristAttraction attract;

    public SleepCommand(TouristAttraction _attract)
    {
        attract = _attract;
    }

    public void Execute()
    {
        attract.Sleep();
    }
}