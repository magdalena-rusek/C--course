using System;
using System.Collections.Generic;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v = new Vehicle();   BLAD - nie mozna utworzyc obiektu klasy abstrakcyjnej

            Train train1 = new Train();     
            train1.ShowData();              // "Vehicle type: train"

            Vehicle train2 = new Train();   // nic: "Unspecified vehicle"
            train2.ShowData();             // override (przy metodzie w Train): "Vehicle type: train"

            ///////////////////////////////////////////////////////////////////////////////////////////////

            Train train3 = new Train("Electric", 100);
            Console.WriteLine(train3);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            List<Vehicle> myTransport = new List<Vehicle>();
            myTransport.Add(new Train("Electric", 100));
            myTransport.Add(new Car("Hybrid", 160));
            myTransport.Add(new Plane("Fuel", 500));

            foreach(Vehicle v in myTransport)
            {
               Console.WriteLine(v.ToString());
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // klasa abstrakcyjna rozni sie od interfejsu tym, ze moze ona posiadac ciala 
            // i informacje, a interfejs ma tylko deklaracje metod bez implementacji
            // klasa moze dziedziczyc po wielu interfejsach, ale TYLKO po 1 klasie
           
            Bus bus1 = new Bus();
            bus1.ShowData();
        }
    }
}
