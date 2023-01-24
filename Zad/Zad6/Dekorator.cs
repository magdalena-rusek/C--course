using System;
using System.Collections.Generic;
using System.Text;

abstract class Dekorator : IJedzenie
{
    protected IJedzenie jedzenie;

    public Dekorator(IJedzenie j)
    {
        jedzenie = j;
    }

    public virtual int PodajKoszt()
    {
        return jedzenie.PodajKoszt();
    }

    public virtual string PodajSklad()
    {
        return jedzenie.PodajSklad();
    }
}