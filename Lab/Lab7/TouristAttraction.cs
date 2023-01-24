using System;
using System.Collections.Generic;
using System.Text;

class TouristAttraction
{
    string attraction;

    public TouristAttraction(string _attraction)
    {
        attraction = _attraction;
    }

    public TouristAttraction()
    {
        attraction = "";
    }

    public void ReserveTicket()
    {
        Console.WriteLine("Tickets reserved for: " + attraction);
    }

    public void VisitHour(int hour)
    {
        Console.WriteLine(hour + ":00 visiting " + attraction);
    }

    public void Sleep()
    {
        Console.WriteLine("Today I am sleeping in " + attraction);
    }
}