using System;

    class Pies : Ssak
    {

    public override string DajGlos()
    {
        return "Hauu hauu";
    }

    public override string ToString()
    {
        return "Czesc! Jestem psem. " + "Jem " + Pokarm;
    }

    public Pies(string _Pokarm)
    {
        Pokarm = _Pokarm;
    }

}