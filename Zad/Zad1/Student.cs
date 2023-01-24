using System;

namespace zad1
{
    class Student
    {
        private string imie;
        private string nazwisko;
        private int indeks;
        private int telefon;

        public string Imie
        {
            get { return imie; }
            set { imie = value; } 
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public int Indeks
        {
            get { return indeks; }
            set { if (value < 300000) indeks = value; }
        }

        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public Student()
        {
            imie = "";
            nazwisko = "";
            indeks = 0;
            telefon = 0;
        }

        public void PokazDane()
        {
            Console.WriteLine("Imie: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Indeks: " + indeks);
            Console.WriteLine("Telefon kontaktowy: " + telefon);
        }
    }
}
