using System;

class Album
{
    public string Nazwa { get; set; }
    public string Artysta { get; set; }
    public int IloscSciezek { get; set; }
    public int RokWydania { get; set; }

    public void ShowAlbumInfo()
    {
        Console.WriteLine("Nazwa albumu: " + Nazwa);
        Console.WriteLine("Nazwisko artysty: " + Artysta);
        Console.WriteLine("Ilosc sciezek w albumie: " + IloscSciezek);
        Console.WriteLine("Rok wydania: " + RokWydania);
    }

    public Album()
    {
        Nazwa = "unknown";
        Artysta = "unknown";
        IloscSciezek = 0;
        RokWydania = 0;
        HowManyAlbums++;
    }

    public Album(string _Nazwa, int _RokWydania)
    {
        if (_RokWydania <= 2020)
        {
            Nazwa = _Nazwa;
            RokWydania = _RokWydania;
            HowManyAlbums++;
        }
    }

    public Album(string _Nazwa, string _Artysta, int _IloscSciezek, int _RokWydania)
    {
        if (_RokWydania <= 2020 && _IloscSciezek >= 0)
        {
            Nazwa = _Nazwa;
            Artysta = _Artysta;
            IloscSciezek = _IloscSciezek;
            RokWydania = _RokWydania;
            HowManyAlbums++;
        }
    }

    public static int HowManyAlbums { get; set; }   // = 50; gdy chcemy zliczac od pewnej wartosci

    public static void CleanAlbumCounter()
    {
        HowManyAlbums = 0;
    }
}
