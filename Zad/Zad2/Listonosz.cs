using System;

    class Listonosz : ICzlowiek, IPracownik
    {

    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public string MojeDane()
    {
        return "Witaj! Nazywam sie " + Imie + " " + Nazwisko;
    }

    public void Pracuj()
    {
        Console.WriteLine("Jestem listonoszem. Roznosze listy i paczki. "); ;
    }

    public Listonosz(string _Imie, string _Nazwisko)
    {
        Imie = _Imie;
        Nazwisko = _Nazwisko;
    }

    }