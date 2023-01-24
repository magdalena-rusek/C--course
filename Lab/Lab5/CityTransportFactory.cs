using System;
using System.Collections.Generic;
using System.Text;

    class CityTransportFactory : TransportFactory
    {

    public Vehicle CreateFastest()
    {
        Metro m = new Metro("electric", 100);
        return m;
    }

    public Vehicle CreateCheapest()
    {
        Bicykle b = new Bicykle("Human", 30);
        return b;
    }

    public Vehicle CreatePublic()
    {
        Bus bus = new Bus("electric", 50);
        return bus;
    }

    public Vehicle Create(string s, int i)
    {
        if (s == "Bus")
        {
            Bus bus = new Bus("electric", i);
            return bus;
        }
        else if (s == "Car")
        {
            Car car = new Car("diesel", i);
            return car;
        }
        else if (s == "Bicykle")
        {
            Bicykle b = new Bicykle("Human", i);
            return b;
        }
        else if (s == "Metro")
        {
            Metro m = new Metro("electric", i);
            return m;
        }
        else
        {
            return null;
        }
    }
}