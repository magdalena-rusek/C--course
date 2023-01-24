using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Jelito : NarzadWewnetrzny
    {
        Zoladek Zoladek { get; set; }

        public bool WchlonSubstancjeOdzywcze()
        {
            Console.WriteLine("Zachodzi wchlanianie sybstancji odzywczych przez organizm zawartych w " + Zoladek.Pokarm);
            return true;
        }

        public override void WyswietlStan()
        {
            Console.WriteLine("Stan jelita: " + StanNarzadu);
        }
    }
}