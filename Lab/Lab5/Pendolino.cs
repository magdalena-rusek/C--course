using System;
using System.Collections.Generic;
using System.Text;

    class Pendolino : Vehicle
    {
    public Pendolino()
    {
        Power = "unknown";
        MaxVelocity = 0;
    }

    public Pendolino(string _Power, int _MaxVelocity)
    {
        Power = _Power;
        MaxVelocity = _MaxVelocity;
    }

    public override string ToString()  // override bo funkcja wbudowana i musimy ja nadpisac
    {
        return "This is a pendolino.\nPower: " + Power + "\nVelocity limit: " + MaxVelocity + "km/h";
    }
}