using System;
using System.Collections.Generic;
using System.Text;

class Lesson
{
    private List<ICommand> tasks;

    public Lesson()
    {
        tasks = new List<ICommand>();
    }

    public void Add(ICommand t)
    {
        tasks.Add(t);
    }

    public void Remove(ICommand t)
    {
        tasks.Remove(t);
    }

    public void Run()
    {
        foreach (ICommand com in tasks)
        {
            com.Execute();
        }
    }
}