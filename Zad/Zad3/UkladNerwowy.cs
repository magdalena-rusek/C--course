using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class UkladNerwowy : UkladNarzadow
    {
        public Mozg MozgUkladu { get; set; }

        public override string MojeZadanie()
        {
            return "Moje zadanie to kontrolowanie pracy innych ukladow oraz odbieranie bodzcy";
        }
    }
}