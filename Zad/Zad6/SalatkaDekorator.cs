using System;
using System.Collections.Generic;
using System.Text;

class SalatkaDekorator : Dekorator
{
    public SalatkaDekorator(IJedzenie jedzenie) : base(jedzenie) { }

    public override int PodajKoszt()
    {
        return base.PodajKoszt() + 8;
    }

    public override string PodajSklad()
    {
        return base.PodajSklad() + " + salatka " + "(" + 110 + " kcal)";
    }
}