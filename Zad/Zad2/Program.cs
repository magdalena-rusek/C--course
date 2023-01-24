using System;
using System.Collections.Generic;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ssak> mojeSsaki = new List<Ssak>();
            mojeSsaki.Add(new Kot("mleko"));
            mojeSsaki.Add(new Pies("mieso"));
            mojeSsaki.Add(new Krowa("trawa"));

            foreach(Ssak s in mojeSsaki)
            {
                Console.WriteLine(s.DajGlos());
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine();

            Listonosz l = new Listonosz("Marek", "Nowak");
            Console.WriteLine(l.MojeDane());
            l.Pracuj();
        }
    }
}
