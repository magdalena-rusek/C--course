using System;
using System.Collections.Generic;
using System.Text;

class Kolacja : IJedzenie
{
    private int cena;
    private string nazwa;
    private int kalorie;

    public Kolacja()
    {
        cena = 0;
        nazwa = "";
        kalorie = 0;
    }

    public int PodajKoszt()
    {
        cena = 15;
        return cena;
    }
    public string PodajSklad()
    {
        nazwa = "Nalesniki ze szpinakiem";
        kalorie = 500;
        return nazwa + "(" + kalorie + " kcal)";
    }
}