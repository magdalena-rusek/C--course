using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public abstract class NarzadWewnetrzny : CialoCzlowieka
    {
        public bool StanNarzadu { get; set; }

        public virtual void WyswietlStan()
        {
            Console.WriteLine("Stan narzadu: " + StanNarzadu);
        }
    }
}