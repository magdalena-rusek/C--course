using System;
using System.Collections.Generic;
using System.Text;

namespace zad3
{
    public abstract class UkladNarzadow : CialoCzlowieka
    {
        public virtual string MojeZadanie()
        {
            return "Moje zadanie nieznane";
        }
    }
}