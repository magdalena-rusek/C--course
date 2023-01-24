using System;

namespace zad4
{
    public abstract class Human
    {
        public static double MedianSalary = 4950.94;
        private readonly Random random;

        public double Salary { get; set; }

        public int Breathe() 
        {
            return random.Next(); 
        }

        public double Eat() 
        { 
            return random.NextDouble(); 
        }

        public Human(double s) 
        {
            random = new Random((int)DateTime.Now.Ticks);
            random.NextDouble();

            Salary = s;
        }
    }
}