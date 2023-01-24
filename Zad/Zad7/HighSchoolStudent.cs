using System;
using System.Collections.Generic;
using System.Text;

class HighSchoolStudent
{
    string name;
    string surname;
    int classs;

    public HighSchoolStudent(string _name, string _surname, int _class) 
    {
        name = _name;
        surname = _surname;
        classs = _class;
    }

    public void DoTask(string subject, int time, int exerciseNumber)
    {
        Console.WriteLine("I am " + name + " " + surname + ". I am in high school in class: " + classs);
        Console.WriteLine("Now I am doing exercise " + exerciseNumber + " from the subject: " + subject);
        int task=0;

        for (int i=0; i<=time; i++)
        {
            task++;
            Console.WriteLine("Doing task " + task + "...");
            i += 4;           
        }
        Console.WriteLine("During " + time + " minutes I have done " + task + " tasks.");
        Console.WriteLine();
    }
}