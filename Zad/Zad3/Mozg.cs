using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{   
    public class Mozg : NarzadWewnetrzny
    {
        public bool SprawdzSerce(Serce serce)
        {
            if (!serce.PompujKrew() || !serce.RozprowadzKrew())
            {
                serce.StanNarzadu = false;
                return false;
            }
            else return true;
        }

        public bool SprawdzPluca(Pluca pluca)
        {
            if (!pluca.PobierzTlen() || !pluca.UsunDwutlenekWegla())
            {
                pluca.StanNarzadu = false;
                return false;
            }
            else return true;
        }

        public bool SprawdzNerki(Nerki nerki)
        {
            if (!nerki.FiltrujKrew() || !nerki.WydalSubstancje())
            {
                nerki.StanNarzadu = false;
                return false;
            }
            else return true;
        }

        public bool SprawdzZoladek(Zoladek zoladek)
        {
            if (!zoladek.TrawPokarm())
            {
                zoladek.StanNarzadu = false;
                return false;
            }
            else return true;
        }

        public bool SprawdzJelito(Jelito jelito)
        {
            if (!jelito.WchlonSubstancjeOdzywcze())
            {
                jelito.StanNarzadu = false;
                return false;
            }
            else return true;
        }

        public bool SprawdzMiesnie(Miesnie miesnie)
        {
            if (!miesnie.PrzesunKosc())
            {
                miesnie.StanNarzadu = false;
                return false;
            }
            else return true;
        }

        public override void WyswietlStan()
        {
            Console.WriteLine("Stan mozgu: " + StanNarzadu);
        }
    }
}