using System;

    public class Przedmiot
    {
    public string NazwaPrzedmiotu { get; set; }

    public double OcenaEgzamin { get; set; }

    public double OcenaLaboratorium { get; set; }

    public double OcenaProjekt { get; set; }

    public double SumaOcen
    {
        get { return OcenaEgzamin + OcenaLaboratorium + OcenaProjekt; }
    }

    private double Srednia() 
    {
        return SumaOcen / 3; 
    }

    public void PokazSrednia()
    {
        Console.WriteLine("Uzyskana srednia z przedmiotu " + NazwaPrzedmiotu + " to " + Srednia());

    }

    public double Procent()
    {
        return Srednia() / 5 * 100;
    }

    public Przedmiot(string _NazwaPrzedmiotu, double _OcenaEgzamin, double _OcenaLaboratorium, double _OcenaProjekt)
    {
        NazwaPrzedmiotu = _NazwaPrzedmiotu;
        OcenaEgzamin = _OcenaEgzamin;
        OcenaLaboratorium = _OcenaLaboratorium;
        OcenaProjekt = _OcenaProjekt;
    }
    }

