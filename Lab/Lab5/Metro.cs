using System;
using System.Collections.Generic;
using System.Text;

    class Metro : Vehicle
    {
    public Metro(string _Power, int _MaxVelocity)
    {
        Power = _Power;
        MaxVelocity = _MaxVelocity;
    }

    public Metro()
    {
        Power = "unknown";
        MaxVelocity = 0;
    }

    public override string ToString()
    {
        return "This is a metro.\nPower: " + Power + "\nMetro goes as fast as it can";
    }
}