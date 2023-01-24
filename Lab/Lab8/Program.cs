using System;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AirPollutionSensor mySensor = new AirPollutionSensor();
            Observer DE = new Observer(50, "Germany");
            Observer FR = new Observer(80, "France");
            Observer PL = new Observer(150, "Poland");

            mySensor.Subscribed(DE);
            mySensor.Subscribed(FR);
            mySensor.Subscribed(PL);
            mySensor.Run();
            mySensor.Unsubscribed(PL);
            mySensor.Run();
            

            Sorter mySorter = new Sorter();
            mySorter.SetAlgorithm(new InsertionSort());
            List<int> myList = new List<int>() { 6, 2, 3, 5, 1 };
            myList = mySorter.Sort(myList);
            foreach (int i in myList) Console.Write(i);
        }
    }
}
