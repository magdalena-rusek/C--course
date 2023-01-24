using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Kosci : NarzadWewnetrzny
    {
        public ushort MaxRuch { get; set; }

        public bool CzyMogePrzesunac()
        {
            if (MaxRuch != 0)
            {
                return true;
            }
            else return false;
        }

        public override void WyswietlStan()
        {
            Console.WriteLine("Stan kosci: " + StanNarzadu);
        }
    }
}