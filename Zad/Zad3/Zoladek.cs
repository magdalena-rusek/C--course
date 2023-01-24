using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Zoladek : NarzadWewnetrzny
    {
        public string Pokarm { get; set; }

        public bool TrawPokarm()
        {
            Console.WriteLine("Zachodzi trawienie " + Pokarm);
            return true;
        }

        public override void WyswietlStan()
        {
            Console.WriteLine("Stan zoladka: " + StanNarzadu);
        }
    }
}