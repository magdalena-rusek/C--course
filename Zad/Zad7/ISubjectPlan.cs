using System;
using System.Collections.Generic;
using System.Text;

interface ISubjectPlan
{
    void Perform(); 
    void Remove(List<ICommand> points, int which);
    void Add(List<ICommand> points);
}