using System;
using System.Collections.Generic;
using System.Text;

class Sniadanie : IJedzenie
{
    private int cena;
    private string nazwa;
    private int kalorie;

    public Sniadanie()
    {
        cena = 0;
        nazwa = "";
        kalorie = 0;
    }

    public int PodajKoszt() 
    {
        cena = 10;
        return cena;
    }
    public string PodajSklad()
    {
        nazwa = "Jajecznica";
        kalorie = 400;
        return nazwa + "(" + kalorie + " kcal)";
    }
}