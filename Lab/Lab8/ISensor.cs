using System;
using System.Collections.Generic;
using System.Text;

interface ISensor
{
    void Subscribed(Observer observer);
    void Unsubscribed(Observer observer);
    void Run();
}