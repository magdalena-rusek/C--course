using System;
using System.Collections.Generic;
using System.Text;

class CalculateCommand : ICommand
{
    Student student;
    List<double> grades;

    public CalculateCommand(Student _student, List<double> _grades)
    {
        student = _student;
        grades = _grades;
    }

    public void Execute()
    {
        student.CalculateGrade(grades);
    }
}