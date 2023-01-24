using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class UkladKrwionosny : UkladNarzadow
    {
        public Serce SerceUkladu { get; set; }

        public override string MojeZadanie()
        {
            return "Moje zadanie to transport krwi po calym ciele a wraz z nia waznych substancji takich jak tlen i zwiazki odzywcze";
        }
    }
}