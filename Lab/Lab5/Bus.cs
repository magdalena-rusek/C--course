using System;
using System.Collections.Generic;
using System.Text;

    class Bus : Vehicle
    {
    public Bus(string _Power, int _MaxVelocity)
    {
        Power = _Power;
        MaxVelocity = _MaxVelocity;
    }

    public Bus()
    {
        Power = "unknown";
        MaxVelocity = 0;
    }

    public override string ToString()
    {
        return "This is a bus.\nPower: " + Power + "\nVelocity limit: " + MaxVelocity + "km/h";
    }
}