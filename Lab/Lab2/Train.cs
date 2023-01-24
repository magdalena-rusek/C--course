using System;

    class Train : Vehicle
    {

    public override void ShowData()
    {
        Console.WriteLine("Vehicle type: train");
    }

    public Train()
    {
        Power = "unknown";
        MaxVelocity = 0;
    }

    public Train(string _Power, int _MaxVelocity)
    {
        Power = _Power;
        MaxVelocity = _MaxVelocity;
    }
    
    public override string ToString()  // override bo funkcja wbudowana i musimy ja nadpisac
    {
        return "This is a train.\nPower: " + Power + "\nVelocity limit: " + MaxVelocity + "km/h";
    }
}