using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Pluca : NarzadWewnetrzny
    {
        public bool Wdech { get; set; }
        public bool Wydech { get; set; }

        public bool PobierzTlen()
        {
            if (Wdech == true)
            {
                Console.WriteLine("Pobieram tlen");
                return true;
            }
            else
            {
                Console.WriteLine("Nie pobieram tlenu");
                return false; 
            }
        }

        public bool UsunDwutlenekWegla()
        {
            if (Wydech == true)
            {
                Console.WriteLine("Usuwam dwutlenek wegla");
                return true;
            }
            {
                Console.WriteLine("Nie usuwam dwutlenku wegla");
                return false;
            }
        }

        public override void WyswietlStan()
        {
            Console.WriteLine("Stan pluca: " + StanNarzadu);
        }
    }
}