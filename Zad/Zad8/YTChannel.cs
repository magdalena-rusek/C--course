using System;
using System.Collections.Generic;
using System.Text;

class YTChannel : IYouTube
{
    List<Observer> list;
    List<string> video;

    public YTChannel()
    {
        list = new List<Observer>();
        video = new List<string>();
    }

    public void Subscribed(Observer observer)
    {
        list.Add(observer);
    }

    public void Unsubscribed(Observer observer)
    {
        list.Remove(observer);
    }

    public void Notify()
    {
        int i = 0;
        foreach (string s in video)
        {
            i++;
        }
        
        foreach (Observer o in list)
        {
            o.Update(video[i-1]);
        }
        Console.WriteLine();
    }

    public void AddVideo(string _video)
    {
        video.Add(_video);
    }
}