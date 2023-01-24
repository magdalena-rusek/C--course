using System;
using System.Collections.Generic;
using System.Text;

class Observer
{
    string name;
    List<string> video;
    int videoToView;

    public Observer(string _name)
    {
        name = _name;
        video = new List<string>();
        videoToView = 0;
    }

    public void Update(string title)
    {
        video.Add(title);
        videoToView++;
        Console.WriteLine("New video on the subscribed channel - " + title + ". " + name + ", you have to see it" );
    }
}
