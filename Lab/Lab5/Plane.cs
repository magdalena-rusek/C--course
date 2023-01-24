using System;

    class Plane : Vehicle
    {

    public Plane(string _Power, int _MaxVelocity)
    {
        Power = _Power;
        MaxVelocity = _MaxVelocity;
    }

    public override string ToString()
    {
        return "This is a plane.\nPower: " + Power + "\nVelocity limit: " + MaxVelocity + "km/h";
    }

    }