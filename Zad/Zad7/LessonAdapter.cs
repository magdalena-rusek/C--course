using System;
using System.Collections.Generic;
using System.Text;

class LessonAdapter : ISubjectPlan
{
    Lesson lesson = new Lesson();

    public void Add(List<ICommand> points)
    {
        foreach (ICommand command in points)
        {
            lesson.Add(command);
        }
    }

    public void Perform()
    { 
        lesson.Run();
    }

    public void Remove(List<ICommand> points, int which)
    {
        ICommand what = points[which];
        lesson.Remove(what);
        //lesson.Run();       
    }
}