﻿using Game.Engine.Interactions.Built_In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions
{
    // meet with a troll named Hymir, who is a brother of Gymir
    // Hymir's behavior will depend on your previous interactions with Gymir, if you had them

    [Serializable]
    class HymirEncounter : ConsoleInteraction
    {
        private bool visited = false; // has this place been visited?
        public IHymirStrategy Strategy { get; set; } // store strategy 
        public HymirEncounter(GameSession ses) : base(ses)
        {
            Name = "interaction0004";
            Strategy = new HymirNeutralStrategy(); // start with default strategy
        }
        protected override void RunContent()
        {
            Strategy.Execute(parentSession, visited); // execute strategy
            visited = true;
        }
    }
}
