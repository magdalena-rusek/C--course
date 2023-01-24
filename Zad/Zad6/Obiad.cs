using System;
using System.Collections.Generic;
using System.Text;

class Obiad : IJedzenie
{
    private int cena;
    private string nazwa;
    private int kalorie;

    public Obiad()
    {
        cena = 0;
        nazwa = "";
        kalorie = 0;
    }

    public int PodajKoszt()
    {
        cena = 25;
        return cena;
    }
    public string PodajSklad()
    {
        nazwa = "Zupa pomidorowa + pierogi z miesem";
        kalorie = 1000;
        return nazwa + "(" + kalorie + " kcal)";
    }
}