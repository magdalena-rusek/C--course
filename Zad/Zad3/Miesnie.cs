using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Miesnie : NarzadWewnetrzny
    {
        public bool PrzesunKosc()
        {
                return true;
        }

        public override void WyswietlStan()
        {
            Console.WriteLine("Stan miesni: " + StanNarzadu);
        }
    }
}