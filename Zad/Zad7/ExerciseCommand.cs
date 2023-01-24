using System;
using System.Collections.Generic;
using System.Text;

class ExerciseCommand : ICommand 
{
    HighSchoolStudent hsstudent;
    string subject;
    int time;
    int exerciseNumber;

    public ExerciseCommand(HighSchoolStudent _hsstudent, string _subject, int _time, int _exerciseNumber)
    {
        hsstudent = _hsstudent;
        subject = _subject;
        time = _time;
        exerciseNumber = _exerciseNumber;
    }

    public void Execute()
    {
        hsstudent.DoTask(subject, time, exerciseNumber);
    }
}