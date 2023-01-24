using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Uszy : NarzadZmyslu
    {
        public bool Sluch { get; set; }

        public string CoSlysze()
        {
            return "Slysze " + Bodziec;
        }

        public override string StanNarzadu()
        {
            if (Sluch == true)
            {
                return "Moj sluch jest bardzo dobry";
            }
            else return "Jestem gluchy";
        }
    }
}