using System;
using System.Collections.Generic;
using System.Text;

class AirPollutionSensor : ISensor
{
    List<Observer> list = new List<Observer>();
    List <int> value;

    public AirPollutionSensor()
    {
        value = new List<int>(){ 145, 154, 58};
    }

    public void Subscribed(Observer observer)
    {
        list.Add(observer);
    }

    public void Unsubscribed(Observer observer)
    {
        list.Remove(observer);
    }

    public void Run()
    {
        foreach (int i in value)
        {
            foreach (Observer o in list)
            {
                o.Received(i);
            }
            Console.WriteLine();
        }
    }
}