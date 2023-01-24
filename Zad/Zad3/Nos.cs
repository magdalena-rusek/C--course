using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Nos : NarzadZmyslu
    {
        public bool Wech { get; set; }

        public string CoCzuje()
        {
            return "Wyczuwam " + Bodziec;
        }

        public override string StanNarzadu()
        {
            if (Wech == true)
            {
                return "Moj wech jest bardzo dobry";
            }
            else return "Cierpie na anosmie";
        }
    }
}