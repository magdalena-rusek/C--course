using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.Built_In
{
    class QueenNeutralStrategy : IQueenStrategy
    {
        public void Execute(GameSession parentSession, bool visited)
        {
            parentSession.SendText("\nHello adventurer. Welcome to my kingdom!!! ");
            parentSession.SendText("\nIf you help minimum 3 my people, you'll get a reward ");
            parentSession.SendText("\nRemember that FArmer should be the last character you will help");
        }       
    }
}
