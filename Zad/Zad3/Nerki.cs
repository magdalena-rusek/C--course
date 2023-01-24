using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public class Nerki : NarzadWewnetrzny
    {
        Serce Serce { get; set; }
        public bool StanFiltra { get; set; }

        public bool FiltrujKrew()
        {
            StanFiltra = true;
            Console.WriteLine("Wychwytuje z " + Serce.Krew + " szkodliwe substancje");
            return true;
        }

        public bool WydalSubstancje()
        {
            if (StanFiltra)
            {
                Console.WriteLine("Wydalam z organizmu szkodliwe substancje wraz z moczem");
                return true;
            }
            else
            {
                Console.WriteLine("Nie zaszlo filtrowanie - brak substancji do usuniecia");
                return false;
            }
        }

        public override void WyswietlStan()
        {
            Console.WriteLine("Stan nerek: " + StanNarzadu);
        }
    }
}