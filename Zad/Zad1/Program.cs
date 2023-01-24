using System;
using System.Collections.Generic;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentElektroniki = new Student() { Imie = "Adam", Nazwisko = "Kowalski", Indeks = 236729, Telefon = 657345267 };
            // studentElektroniki.PokazDane();
            // Student s = new Student();
            // s.PokazDane();
            
            Kierunek elektronika = new Kierunek("Elektronika", 3, studentElektroniki, 5);
            // elektronika.PokazInformacje();

            List<Przedmiot> przedmioty = new List<Przedmiot>();

            przedmioty.Add(new Przedmiot("Matematyka", 4, 4, 4 ));
            przedmioty.Add(new Przedmiot("Fizyka", 3, 4, 4.5));
            przedmioty.Add(new Przedmiot("Programowanie obiektowe", 4.5, 4, 5));
            przedmioty.Add(new Przedmiot("Sieci komputerowe", 4, 3.5, 4));

            //Console.WriteLine(przedmioty[0].Procent() + "%");
            
            Console.WriteLine("Przedmioty znajdujace sie na liscie to:");
            foreach(Przedmiot p in przedmioty)
            {
                Console.WriteLine(p.NazwaPrzedmiotu);
            }
        }
    }
}
