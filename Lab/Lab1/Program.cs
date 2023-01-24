using System;
using System.Collections.Generic;

namespace lab1
{
    class Program
    {
        static double Pythagoras(double a, double b)
        {
            double result; // zmienna pomocnicza
            result = Math.Sqrt(a * a + b * b); // wykonaj dzialanie
            return result; // zwroc wartosc
                           // ponizej wersja skrocona do jednej linijki, rowniez skompiluje sie poprawnie:
                           // return Math.Sqrt(a*a+b*b);
        }

        static bool IsPrime(int a)
        {
            for (int i = a - 1; i > 1; i--)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int Silnia(int a)
        {
            int silnia;

            if (a > 0)
            {
                silnia = a;
                return silnia * Silnia(a - 1);
            }
            else if (a == 0)
            {
                silnia = 1;
                return silnia;
            }
            else
            {
                return -1;
            }

        }

        static void PrintFactorial(int a)
        {
            if (a >= 0)
            {
                Console.WriteLine("Factorial of " + a + " is equal to: " + Silnia(a));
            }
            else
            {
                Console.WriteLine("Error! Cannot compute factorial of a negative number: " + a);
            }
        }

        static void Main(string[] args)
        {
            // Console.ReadKey(); bezpośrednio pod Console.WriteLine  - jesli okienko uruchamia sie i zamyka

            Console.WriteLine("Hello World!");
            // Console.WriteLine() - wypisuje tekst na ekranie i przechodzi do nowej linii
            // Console.Write() - wypisuje tekst na ekranie i NIE przechodzi do nowej linii

            Console.ReadKey();
            // Console.ReadKey() - umozliwia wpisywanie danej w konsoli

            //////////////////////////////////////////////////////////////////////////////////////

            int number1 = 3;
            int number2 = 4;
            int sum = number1 + number2;
            Console.WriteLine("Result: " + sum);

            //////////////////////////////////////////////////////////////////////////////////////

            int number3 = 3;
            double pi = 3.14159;
            char s = 'S';
            string university = "AGH";
            Console.WriteLine("Variables: " + number3 + "\n" + pi + "\n" + s + "\n" + university);

            //////////////////////////////////////////////////////////////////////////////////////

            for (int i=2; i<101; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(Silnia(4));

            PrintFactorial(4);
            PrintFactorial(-7);

            //////////////////////////////////////////////////////////////////////////////////////

            RightTriangle trojkat1 = new RightTriangle();
            trojkat1.A = 3;
            trojkat1.B = 4;
            RightTriangle trojkat2 = new RightTriangle() { A = 4, B = 7 };
            RightTriangle trojkat3 = new RightTriangle() { A = 8, B = 10 };

            Console.WriteLine("Tangens1: " + trojkat1.ComputeTangent());
            Console.WriteLine("Tangens2: " + trojkat2.ComputeTangent());
            Console.WriteLine("Tangens3: " + trojkat3.ComputeTangent() + "\n");

            trojkat1.color = "blue";
            trojkat2.color = "pink";
            trojkat3.color = "yellow";

            Console.WriteLine("Color1: " + trojkat1.color);
            Console.WriteLine("Color2: " + trojkat2.color);
            Console.WriteLine("Color3: " + trojkat3.color + "\n");

            Console.WriteLine("Sinus1: " + trojkat1.ComputeSine());
            Console.WriteLine("Sinus2: " + trojkat2.ComputeSine());
            Console.WriteLine("Sinus3: " + trojkat3.ComputeSine() + "\n");

            Console.WriteLine("Obwod1: " + trojkat1.Circumference);
            Console.WriteLine("Obwod2: " + trojkat2.Circumference);
            Console.WriteLine("Obwod3: " + trojkat3.Circumference + "\n");

            //////////////////////////////////////////////////////////////////////////////////////

            Album mojAlbum1 = new Album();
            mojAlbum1.ShowAlbumInfo();       // brak konstruktora = wyswietla sie: int: 0, string: nic
                                             // jesli nie zdefiniujemy zadnego konstruktowa, kompilator sam 
                                             // utworzy konstruktor (domyslny) dlatego wyswietlaja sie takie wartosci

            // inicjalizator, wszystkie pola wypelnione
            Album mojAlbum2 = new Album() { Nazwa = "Perfect", Artysta = "Ed Sheeran", IloscSciezek = 10, RokWydania = 2018 };
            mojAlbum2.ShowAlbumInfo();

            // inicjalizator, nie wszystkie pola wypelnione -> otrzymuja one wartosci z konstruktora domyslnego
            Album mojAlbum3 = new Album() { Artysta = "Shawn Mendes", RokWydania = 2015 };
            mojAlbum3.ShowAlbumInfo();

            //////////////////////////////////////////////////////////////////////////////////////

            Album mojAlbum4 = new Album("Mama", 2010); 
            mojAlbum4.ShowAlbumInfo();

            Album mojAlbum5= new Album("mama", "Ewa", 8, 2007);
            mojAlbum5.ShowAlbumInfo();

            Console.WriteLine(Album.HowManyAlbums);
            Album.CleanAlbumCounter();
            Console.WriteLine(Album.HowManyAlbums);

            // metody statyczne - mozemy uzywac bez koniecznosci tworzenia obiektu klasy, sa zwiazane z typem
            // pola statyczne - tez sa zwiazane z typem klasy, ich wartosc jest wspolna dla kazdego obiektu

            //////////////////////////////////////////////////////////////////////////////////////

            string[] tablica = new string[5];   // lub string[] tablica2 = new string[] { "s1", "s2", "s3", "s4", "s5" };
            tablica[0] = "Tekst1";
            tablica[1] = "Tekst2";
            tablica[2] = "Tekst3";
            tablica[3] = "Tekst4";
            tablica[4] = "Tekst5";

            // petla for dla []
            for (int i=0; i<tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }

            // petla foreach dla []
            foreach (string i in tablica)
            {
                Console.WriteLine(i);
            }

            //////////////////////////////////////////////////////////////////////////////////////

            List<string> mojaLista = new List<string> { "Tekst1", "Tekst2", "Tekst3", "Tekst4", "Tekst5"};

            // petla for dla listy<>
            for(int i=0; i<mojaLista.Count; i++)
            {
                Console.WriteLine(mojaLista[i]);
            }

            // petla foreach dla listy<>
            foreach (string i in mojaLista)
            {
                Console.WriteLine(i);
            }

            // Add - dodaj nowy element do listy<> (na koniec - stos)
            mojaLista.Add("nowy element - add");

            // Insert (gdzie, co) - dodaj nowy element do listy 
            mojaLista.Insert(1, "nowy element - insert");

            // Remove (co) - usun element z listy<>
            mojaLista.Remove("Tekst3");

            // RemoveAt (gdzie/indeks) - usun element z listy<>
            mojaLista.RemoveAt(4);

            // IndexOf (co) - znajdz element
            Console.WriteLine(mojaLista.IndexOf("Tekst2"));
            Console.WriteLine(mojaLista.IndexOf("nieistniejacy"));  // wynik = -1

            //////////////////////////////////////////////////////////////////////////////////////

            // Dictionary <klucz, wartosc>
            Dictionary<string, int> mojSlownik = new Dictionary<string, int>()
            {
                { "Nowak", 1234 },
                { "Kowalski", 5678 }
            };

            // Add (klucz, wartosc)- dodaj pozycje
            mojSlownik.Add("Robinson", 1357);
            mojSlownik.Add("Andersen", 2468);
            mojSlownik.Add("Sheeran", 1245);

            // Remove (klucz) - usun pozycje
            mojSlownik.Remove("Kowalski");

            // ContainsKey - sprawdz czy pozycja o kluczu jest w slowniku
            Console.WriteLine(mojSlownik.ContainsKey("Sheeran"));   // wynik = true
            Console.WriteLine(mojSlownik.ContainsKey("nieistniejacy"));  // wynik= false
           
            // wyswietl wartosc dla klucza
            Console.WriteLine(mojSlownik["Andersen"]);

            // wyswietl zawartosc slownika
            foreach(KeyValuePair<string, int> i in mojSlownik)
            {
                Console.WriteLine("Pod kluczem " + i.Key + " jest wartosc " + i.Value);
            }
        }
    }
}