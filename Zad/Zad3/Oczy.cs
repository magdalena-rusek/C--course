using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Oczy : NarzadZmyslu
    {
        public int StanWzroku { get; set; }
        public bool Wzrok { get; set; }

        public override string StanNarzadu()
        {
            if (Wzrok == true)
            {
                if (StanWzroku == 0)
                {
                    return "Moj wzrok jest bardzo dobry";
                }
                else return "Mam wade wzroku " + StanWzroku;
            }
            else return "Jestem niewidomy";
        }

        public string CoWidze()
        {
            return "Widze " + Bodziec; 
        }
    }
}