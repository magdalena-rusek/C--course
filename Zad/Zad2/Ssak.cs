using System;

abstract class Ssak
    {
    public string Pokarm { get; set; }
    
    public virtual string DajGlos() 
    {
        return "Nieznany glos";
    }

    }