using System;
using System.Collections.Generic;
using System.Text;

class Observer
{
    int myLimit;
    string myName;

    public Observer(int limit, string name)
    {
        myLimit = limit;
        myName = name;
    }
    public void Received(int value)
    {
        if (value > myLimit) Console.WriteLine("Value " + value + ". Declare emergency! [" + myName + "]");
    }
}