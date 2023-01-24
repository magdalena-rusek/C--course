using System;

    class Bus : IVehicle    // VS podkresla nazwe klasy na czerwono bo nie ma 
    {                       // zaimplementowanej metody ShowData()

    public void ShowData()
    {
        Console.WriteLine("This is Inteface - Car"); 
    }

    }