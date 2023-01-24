using System;
using System.Collections.Generic;
using System.Text;

    abstract class Furniture
    {
    public int Price { get; set; }
    public string Comfort { get; set; }

    public abstract string ShowInfo();

    }