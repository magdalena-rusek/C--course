using System;
using System.Collections.Generic;
using System.Text;

class SzarlotkaDekorator : Dekorator
{
    public SzarlotkaDekorator(IJedzenie jedzenie) : base(jedzenie) { }

    public override int PodajKoszt()
    {
        return base.PodajKoszt() + 10;
    }

    public override string PodajSklad()
    {
        return base.PodajSklad() + " + szarlotka " + "(" + 150 + " kcal)";
    }
}