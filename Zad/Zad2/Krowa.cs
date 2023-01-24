using System;

    class Krowa : Ssak
    {

    public override string DajGlos()
    {
        return "Muuu muuu";
    }

    public override string ToString()
    {
        return "Czesc! Jestem krowa. " + "Jem " + Pokarm;
    }

    public Krowa(string _Pokarm)
    {
        Pokarm = _Pokarm;
    }

}