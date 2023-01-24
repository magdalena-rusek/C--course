using System;
using System.Collections.Generic;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            YTChannel passionIT = new YTChannel();
            Observer observer1 = new Observer("James");
            Observer observer2 = new Observer("Alice");

            passionIT.Subscribed(observer1);
            passionIT.Subscribed(observer2);
            
            passionIT.AddVideo("MySQL course");
            passionIT.Notify();

            Observer observer3 = new Observer("John");
            passionIT.Subscribed(observer3);

            passionIT.AddVideo("Windows server");
            passionIT.Notify();

            passionIT.Unsubscribed(observer2);
            passionIT.AddVideo("PHP course");
            passionIT.Notify();

            /////////////////////////////////////////////////////////////////////
            
            List<double> list1 = new List<double>() { 3.5, 2, 4, 4.5, 5, 5, 3 };

            Context c = new Context();
            c.SetAlgorithm(new FindMax());
            Console.WriteLine("Max number in my list is: " + c.Calculate(list1));

            c.SetAlgorithm(new AverageValue());
            Console.WriteLine("\nAverage value: " + c.Calculate(list1));
        }
    }
}
