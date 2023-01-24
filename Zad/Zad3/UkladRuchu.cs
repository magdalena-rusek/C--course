using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class UkladRuchu : UkladNarzadow
    {
        public Miesnie MiesnieUkladu { get; set; }
        public Kosci KosciUkladu { get; set; }

        public override string MojeZadanie()
        {
            return "Moje zadanie to poruszanie sie";
        }
    }
}