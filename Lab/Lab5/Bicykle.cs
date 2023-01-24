using System;
using System.Collections.Generic;
using System.Text;

    class Bicykle : Vehicle
    {
    public Bicykle(string _Power, int _MaxVelocity)
    {
        Power = _Power;
        MaxVelocity = _MaxVelocity;
    }

    public Bicykle()
    {
        Power = "unknown";
        MaxVelocity = 0;
    }

    public override string ToString()
    {
        return "This is a bicykle.\nPower: " + Power + "\nVelocity limit: " + MaxVelocity + "km/h";
    }
}