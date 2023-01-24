using System;
using System.Collections.Generic;
using System.Text;

interface IYouTube
{
    void Subscribed(Observer observer);
    void Unsubscribed(Observer observer);
    void Notify();
}