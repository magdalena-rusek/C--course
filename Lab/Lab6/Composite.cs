using System;
using System.Collections.Generic;
using System.Text;

class Composite : IQuestion
{
    public string Question { get; private set; }
    public int Points { get; private set; }

    List<IQuestion> questions = new List<IQuestion>();

    public Composite(string q, int p)
    {
        Question = q;
        Points = p;
    }

    public Composite()
    {
        Question = "";
        Points = 0;
    }

    public void Ask()
    {
        Console.WriteLine("Composite {");

        foreach(IQuestion quest in questions)
        {
            quest.Ask();
        }

        Console.WriteLine("}");
    }

    public void Add(IQuestion q)
    {
        questions.Add(q);
    }
}