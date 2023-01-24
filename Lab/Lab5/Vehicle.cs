using System;

abstract class Vehicle      // klasa abstrakcyjna - nie mozna tworzyc jej obiektu
{

    public virtual void ShowData()   // virtual - pozwala klasom pochodnym nadpisywac te metode
    {
        Console.WriteLine("Unspecified vehicle");
    }

    public string Power {get; set;}
    public int MaxVelocity { get; set; }

    }