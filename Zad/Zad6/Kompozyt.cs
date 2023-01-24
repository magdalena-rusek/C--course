using System;
using System.Collections.Generic;
using System.Text;

class Kompozyt : IJedzenie
{
    List<IJedzenie> posilki = new List<IJedzenie>();

    public void ZamowienieInformacje()
    {
        int i = 1;
        foreach(IJedzenie j in posilki)
        {
            Console.WriteLine("Zamowienie nr " + i + ": " + j.PodajSklad() + " | koszt: " + j.PodajKoszt() + " zl");
            i++;
        }
    }

    public int PodajKoszt()
    {
        int suma = 0;
        foreach (IJedzenie j in posilki)
        {

            suma += j.PodajKoszt();
        }
        return suma;
    }

    public string PodajSklad()
    {
        string suma = "";
        foreach (IJedzenie j in posilki)
        {
            suma += j.PodajSklad();
        }
        return suma;
    }

    public void DodajPosilek(IJedzenie j)
    {
        posilki.Add(j);
    }

    public void UsunPosilek(IJedzenie j)
    {
        posilki.Remove(j);
    }
}