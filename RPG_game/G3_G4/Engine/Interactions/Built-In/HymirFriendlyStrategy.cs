﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.Built_In
{
    // friendly Hymir strategy - get bonus xp

    [Serializable]
    class HymirFriendlyStrategy : IHymirStrategy
    {
        public void Execute(GameSession parentSession, bool visited)
        {
            if(visited)
            {
                parentSession.SendText("\nHello again! Pretty nice weather we have today, right?");
                return;
            }
            else
            {
                parentSession.SendText("\nHello adventurer. Wait, you must be the person who helped my older brother Gymir! Please come in, I have to thank you.");
                parentSession.SendText("They say that drinking the water from my well brings wisdom, so please let this be my gift for you.");
                parentSession.UpdateStat(7, 500); // + 500 xp
            }
        }
    }
}
