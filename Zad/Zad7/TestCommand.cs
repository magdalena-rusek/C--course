using System;
using System.Collections.Generic;
using System.Text;

class TestCommand : ICommand
{
    Student student;
    int questionNumber;
    string subject;

    public TestCommand(Student _student, int _questionNumber, string _subject)
    {
        student = _student;
        questionNumber = _questionNumber;
        subject = _subject;
    }

    public void Execute()
    {
        student.ChoiceTest(questionNumber, subject);
    }
}