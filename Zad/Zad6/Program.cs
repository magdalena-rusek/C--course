using System;

namespace zad6
{
    class Program
    {
        static void Main()
        {
            IJedzenie snPoniedzialek = new Sniadanie();
            snPoniedzialek = new ColaDekorator(snPoniedzialek);

            IJedzenie obPoniedzialek = new Obiad();

            IJedzenie koPoniedzialek = new Kolacja();
            koPoniedzialek = new SalatkaDekorator(koPoniedzialek);

            IJedzenie snPiatek = new Sniadanie();

            IJedzenie koCzwartek = new Kolacja();

            IJedzenie obWtorek = new Obiad();
            obWtorek = new SzarlotkaDekorator(obWtorek);

            Kompozyt zamowienia = new Kompozyt();
            zamowienia.DodajPosilek(snPoniedzialek);
            zamowienia.DodajPosilek(obPoniedzialek);
            zamowienia.DodajPosilek(koPoniedzialek);
            zamowienia.DodajPosilek(snPiatek);
            zamowienia.DodajPosilek(koCzwartek);
            zamowienia.DodajPosilek(obWtorek);

            zamowienia.ZamowienieInformacje();

            Console.WriteLine();
            zamowienia.UsunPosilek(snPiatek);
            zamowienia.ZamowienieInformacje();
        }
    }
}
