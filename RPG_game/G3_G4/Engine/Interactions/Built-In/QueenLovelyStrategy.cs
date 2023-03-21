using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.Built_In
{
    class QueenLovelyStrategy : IQueenStrategy
    {
        public void Execute(GameSession parentSession, bool visited)
        {
            if (visited)
            {
                parentSession.SendText("\nHello again! Today we have pretty nice weather?");
                return;
            }
            else
            {
                parentSession.SendText("\nHello adventurer. You must be the person who helped my people! Please come in, I have to thank you.");
                parentSession.SendText("Please, take 200 gold as a gift of gratitude.");
                parentSession.UpdateStat(8, 200); // + 200 gold
            }
        }
    }
}
