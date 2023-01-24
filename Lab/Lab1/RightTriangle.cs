using System;

class RightTriangle
{
    // pola klasy przechowujace dlugosci przyprostokatnych
    private double a;
    private double b;

    // wlasciwosci klasy odpowiadajace powyzszym polom
    public double A
    {
        get { return a; } // prosty getter - tylko zwraca wartosc
        set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
        {
            if (value > 0) a = value; // prosze zwrocic uwage na slowo kluczowe value
        }
    }

    public double B
    {
        get { return b; } // prosty getter - tylko zwraca wartosc
        set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
        {
            if (value > 0) b = value;
        }
    }

    // metoda klasy obliczajaca tangens kata w trojkacie A/B
    public double ComputeTangent()
    {
        return A / B;
    }

    // dodatkowa wlasciwosc odpowiadajaca za przechowywanie koloru powierzchni trojkata
    public string color { get; set; }  // automatyczny setter i getter
                                       // nie moglismy zrobic tak z wczesniejszymi poniewaz zawieraja dodatkowe
                                       // funkcje (poza wprowadzaniem/wyprowadzaniem wartosci dla pola prywatnego)
                                       // srodowisko automatycznie rozwinie skrocona deklaracje wlasciwosci podczas kompilacji
                                       // kompilator niejawnie utworzy pole prywatne przypisane do publicznej wlasciwosci

    // metoda zwracajaca wartosc przeciwprostokatnej trojkata
    private double ComputeC()
    {
        return Math.Sqrt(a * a + b * b);
    }

    // metoda zwracajaca wartosc sinusa 1 z katow w trojkacie z uzyciem ComputeC
    public double ComputeSine()
    {
        return A / ComputeC();
    }

    // wlasciwosc przechowujaca wartosc obwodu trojkata
    public double Circumference
    {
        get { return A + B + ComputeC(); }
    }                                        // getter moze byc bez settera
    /*public double Circumference            // setter moze byc bez gettera ale tylko zaimplementowany
    {                                        // przez uzytkownika, dla settera automatycznego wystepuje BLAD
        set { A = value; }
    }*/
}