﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items
{
    [Serializable]
    class BasicSword : Sword
    {
        // simple sword
        public BasicSword() : base("item0004") 
        {
            StrMod = 5;
            PrMod = 2;
            GoldValue = 10;
            PublicName = "Basic Sword"; 
        }
    }
}
