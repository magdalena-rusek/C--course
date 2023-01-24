using System;

    class Car : Vehicle
    {

    public Car(string _Power, int _MaxVelocity)
    {
        Power = _Power;
        MaxVelocity = _MaxVelocity;
    }

    public Car()
    {
        Power = "unknown";
        MaxVelocity = 0;
    }

    public override string ToString()
    {
        return "This is a car.\nPower: " + Power + "\nVelocity limit: " + MaxVelocity + "km/h";
    }

    }