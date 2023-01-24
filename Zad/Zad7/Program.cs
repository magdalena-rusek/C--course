using System;
using System.Collections.Generic;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(289438, "IT");
            HighSchoolStudent hsstudent1 = new HighSchoolStudent("Adam", "Kowalski", 2);
            Student student2 = new Student(243654, "Electronics");
            Student student3 = new Student(324534, "Physics");

            CalculateCommand s1Calculate = new CalculateCommand(student1, new List<double>() {4, 5, 3, 2.5 });
            TestCommand s2Test = new TestCommand(student2, 3, "Microcontroller techniques");
            ExerciseCommand hss1Exercise = new ExerciseCommand(hsstudent1, "Maths", 30, 2);
            TestCommand s3Test = new TestCommand(student3, 7, "Medical physics");

            Lesson studentplan = new Lesson();
            studentplan.Add(s1Calculate);
            studentplan.Add(s2Test);
            studentplan.Add(hss1Exercise);
            studentplan.Add(s3Test);
            studentplan.Run();

            studentplan.Remove(hss1Exercise);
            studentplan.Run();

            LessonAdapter lAdapter = new LessonAdapter();
            List<ICommand> l1 = new List<ICommand>() { s1Calculate, s2Test, hss1Exercise };

            lAdapter.Add(l1);
            lAdapter.Perform();
            lAdapter.Remove(l1, 0);
            lAdapter.Perform();
        }
    }
}
