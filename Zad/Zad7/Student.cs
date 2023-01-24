using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    int id;
    string fieldOfStudy;

    public Student(int _id, string _fieldOfStudy)
    {
        id = _id;
        fieldOfStudy = _fieldOfStudy;
    }

    public void ChoiceTest(int questionNumber, string subject)
    {
        Random rand = new Random();
        Console.WriteLine("Student id: " + id + ". Field of study: " + fieldOfStudy);
        Console.WriteLine("Subject test: " + subject);
        
        for(int i=1; i<=questionNumber; i++)
        {
            Console.WriteLine("Question: " + i + " My answer: " + rand.Next(1, 5));  // ans A = 1, ans B = 2 ..
        }

        Console.WriteLine();
    }

    public void CalculateGrade(List <double> grades)
    {
        double sum=0.0, averageGrade=0.0;
        int number = 0;

        foreach (double g in grades)
        {
            sum += g;
            number++;
        }
  
        averageGrade = sum / number;

        Console.WriteLine("Student id: " + id);
        Console.WriteLine("I have already calculated my average grade. It's " + averageGrade);
        Console.WriteLine();
    }
}