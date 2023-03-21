using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.Built_In
{
    class QueenAngryStrategy : IQueenStrategy
    {
        public void Execute(GameSession parentSession, bool visited)
        {
            if (visited)
            {
                parentSession.SendText("\nYou robbed my peopler! You lose 10 points health.");
                parentSession.UpdateStat(1, -10); // -10 health
            }
            else
            {
                parentSession.SendText("\nHello adventurer. Oh no.. You must be the person who robbed my people!");
                parentSession.SendText("\nGuard!! Take 50 xp points from him");
                parentSession.UpdateStat(7, 50); // +50 xp
                parentSession.FightRandomMonster();               
            }
        }
    }
}
