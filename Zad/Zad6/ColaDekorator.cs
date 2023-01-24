using System;
using System.Collections.Generic;
using System.Text;

class ColaDekorator : Dekorator
{
    public ColaDekorator(IJedzenie jedzenie) : base(jedzenie) { }

    public override int PodajKoszt()
    {
        return base.PodajKoszt() + 5;
    }

    public override string PodajSklad()
    {
        return base.PodajSklad() + " + Coca cola " + "(" + 90 + " kcal)";
    }
}