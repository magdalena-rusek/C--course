using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ExamQuestion q1 = new ExamQuestion("Prosze zapisac zasady dynamiki Newtona", 2);
            ExamQuestion q2 = new ExamQuestion("Prosze wyprowadzic wzor na grawitacyjna energie potencjalna", 3);
            ExamQuestion q3 = new ExamQuestion("Prosze wyznaczyc spadek napiecia na elementach w ponizszym obwodzie RLC", 5);
            Composite s = new Composite();

            s.Add(q1);
            s.Add(q2);
            s.Add(q3);
            s.Ask();
            */

            IWeatherAlert monday = new RainAlert();
            monday = new WindDecorator(monday);

            IWeatherAlert tuesday = new NoAlert();
            tuesday = new FogDecorator(tuesday);

            IWeatherAlert wednesday = new RainAlert();
            wednesday = new WindDecorator(wednesday);
            wednesday = new SnowDecorator(wednesday);

            monday.Alert();
            tuesday.Alert();
            wednesday.Alert();
        }
    }
}
