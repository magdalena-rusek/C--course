using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Serce : NarzadWewnetrzny
    {
        public string Krew { get; set; }

        public bool PompujKrew()
        {
            Console.WriteLine("Pompuje" + Krew);
            return true;
        }

        public bool RozprowadzKrew()
        {
            Console.WriteLine("Rozprowadzam " + Krew + " po calym ciele");
            return true;
        }

        public override void WyswietlStan()
        {
            Console.WriteLine("Stan serca: " + StanNarzadu);
        }
    }
}