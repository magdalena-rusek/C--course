using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Interactions.Built_In;

namespace Game.Engine.Interactions
{
    class QueenEncounter : ConsoleInteraction
    {
        private bool visited = false; 
        public int peopleHelp { get; set; } = 0;

        public IQueenStrategy Strategy { get; set; } 

        public QueenEncounter(GameSession ses) : base(ses)
        {
            Name = "interaction0007";
            Strategy = new QueenNeutralStrategy(); 
        }
        protected override void RunContent()
        {
            Strategy.Execute(parentSession, visited); 
            visited = true;
            parentSession.SendText("\nNow you helped: " + peopleHelp + " people" );
        }
    }
}
