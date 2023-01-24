using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class UkladOddechowy : UkladNarzadow
    {
        public Pluca PlucaUkladu { get; set; }

        public override string MojeZadanie()
        {
            return "Moje zadanie to pobieranie potrzebnego do zycia tlenu i usuwanie zbednego dwutlenku wegla";
        }
    }
}