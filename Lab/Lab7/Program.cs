using System;
using System.Collections.Generic;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            TouristAttraction schonbrunn = new TouristAttraction("Schonbrunn");
            TouristAttraction museum = new TouristAttraction("Kunsthistorisches Museum");
            TouristAttraction kahlenberg = new TouristAttraction("Kahlenberg");
            TouristAttraction tiergarten = new TouristAttraction("Tiergarten");

            VisitCommand visitSchonbrunn = new VisitCommand(schonbrunn, 11);
            VisitCommand visitMuseum = new VisitCommand(museum, 11);
            VisitCommand visitKahlenberg = new VisitCommand(kahlenberg, 13);
            VisitCommand visitTiergarten = new VisitCommand(tiergarten, 12);
            SleepCommand sleep = new SleepCommand(schonbrunn);

            TripPlan planA = new TripPlan();
            planA.Add(visitSchonbrunn);
            planA.Add(visitMuseum);
            planA.Add(visitKahlenberg);
            planA.Add(visitTiergarten);
            planA.Add(sleep);
            planA.Run();

            TripPlanAdapter tpa = new TripPlanAdapter();
            tpa.Run(new List<ICommand>() { visitKahlenberg, visitMuseum });


        }
    }
}
