using System;

namespace zad1
{
    class Kierunek
    {
        public string Nazwa { get; set; }

        public int IloscPrzedmiotow { get; set; }

        public Student Starosta { get; set; }

        public int Semestr { get; set; }

        public Kierunek(string _Nazwa, int _IloscPrzedmiotow, Student _Starosta, int _Semestr)
        {
            Nazwa = _Nazwa;
            IloscPrzedmiotow = _IloscPrzedmiotow;
            Starosta = _Starosta;
            Semestr = _Semestr;
        }

        public void PokazInformacje()
        {
            Console.WriteLine("Nazwa kierunku: " + Nazwa);
            Console.WriteLine("Ilosc przedmiotow: " + IloscPrzedmiotow);
            Console.WriteLine("Starosta kierunku: " + Starosta.Imie + " " + Starosta.Nazwisko);
            Console.WriteLine("Semestr: " + Semestr);
        }
    }
}
