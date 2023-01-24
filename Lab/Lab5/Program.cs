using System;
using System.Collections.Generic;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // C2 
            List<Vehicle> myTransport1 = new List<Vehicle>();
            myTransport1.Add(new Train("Electric", 90));
            myTransport1.Add(new Car("Hybrid", 120));
            foreach (Vehicle v in myTransport1)
            {
                Console.WriteLine(v);
            }
            
            // C5 zadanie 1
            List<VehicleFactory> myFactories = new List<VehicleFactory>();
            myFactories.Add(new TrainFactory());
            myFactories.Add(new CarFactory());
            // tu moga dziac sie rozne rzeczy
            foreach (VehicleFactory factory in myFactories)
            {
                Vehicle v = factory.Create();
                Console.WriteLine(v);
            }
            Console.WriteLine();
            */
            // C5 zadanie 2
            List<Vehicle> myTransport2 = new List<Vehicle>();
            CityTransportFactory myFactory = new CityTransportFactory();
            // chce dojechac na miejsce jak najszybciej, niewazne jakim srodkiem transportu
            myTransport2.Add(myFactory.CreateFastest());
            // nie spieszy mi sie, tym razem wole jechac jak najmniejszym kosztem
            myTransport2.Add(myFactory.CreateCheapest());
            // poprosze dowolny srodek transportu publicznego
            myTransport2.Add(myFactory.CreatePublic());
            // czasami wiem dokladnie czego chce i moge podac parametry
            myTransport2.Add(myFactory.Create("Car",50));
            // moge tez zazadac pojazdu ktorego jeszcze nie da sie wyprodukowac, ale moze wkrotce programista go dokodzi
            // w takim wypadku fabryka bedzie tymczasowo zwracala null, dzieki czemu nie zepsuje reszty kodu
            myTransport2.Add(myFactory.Create("Flying Car",50));
            // i potencjalnie wiele innych mozliwosci

            foreach (Vehicle v in myTransport2) Console.WriteLine(v+"\n");
        }
    }
}
