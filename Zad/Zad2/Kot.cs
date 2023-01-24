using System;

    class Kot : Ssak
    {

    public override string DajGlos()
    {
        return "Miaauu miauuu";
    }

    public override string ToString()
    {
        return "Czesc! Jestem kotem. " + "Jem " + Pokarm;
    }

    public Kot(string _Pokarm)
    {
        Pokarm = _Pokarm;
    }

}