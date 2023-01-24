using System;
using System.Collections.Generic;
using System.Text;

    class InterCityTransportFactory : TransportFactory
    {

        public Vehicle CreateFastest()
        {
            Plane plane = new Plane("electric", 500);
            return plane;
        }

        public Vehicle CreateCheapest()
        {
            Train train = new Train("fuel", 150);
            return train;
        }

        public Vehicle CreatePublic()
        {
            Pendolino pendolino = new Pendolino("electric", 250);
            return pendolino;
        }

        public Vehicle Create(string s, int i)
        {
            if (s == "Train")
            {
                Train train = new Train("fuel", 150);
                return train;
            }
            else if (s == "Pendolino")
            {
                Pendolino pendolino = new Pendolino("electric", 250);
                return pendolino;
            }
            else if (s == "Plane")
            {
                Plane plane = new Plane("electric", 500);
                return plane;
            }
            else
            {
                return null;
            }
        }
    }