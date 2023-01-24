using System;
using System.Collections.Generic;
using System.Text;

    interface TransportFactory
    {
    Vehicle CreateCheapest();
    Vehicle CreateFastest();
    Vehicle CreatePublic();
    Vehicle Create(string data, int maxVel);
    }