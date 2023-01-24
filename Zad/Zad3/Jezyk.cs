using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Jezyk : NarzadZmyslu
    {
        public bool Smak { get; set; }

        public string CoCzuje()
        {
            return "Czuje " + Bodziec;
        }

        public override string StanNarzadu()
        {
            if (Smak == true)
            {
                return "Moj smak jest bardzo dobry";
            }
            else return "Cierpie na aguesie";
        }
    }
}