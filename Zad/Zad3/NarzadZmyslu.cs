using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public abstract class NarzadZmyslu : CialoCzlowieka
    {
        public string Bodziec { get; set; }

        public virtual string StanNarzadu()
        {
            return "Brak danych";
        }
    }
}