using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class UkladPokarmowy : UkladNarzadow
    {
        public Zoladek ZoladekUkladu { get; set; }
        public Jelito JelitoUkladu { get; set; }

        public override string MojeZadanie()
        {
            return "Moje zadanie to odzywianie organizmu";
        }
    }
}