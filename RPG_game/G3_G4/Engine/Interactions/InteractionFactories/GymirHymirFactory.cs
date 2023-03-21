using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.InteractionFactories
{
    class GymirHymirFactory : InteractionFactory
    {
        public List<Interaction> CreateInteractionsGroup(GameSession parentSession)
        {
            // Gymir and Hymir must always appear together in the game world
            HymirEncounter hymir = new HymirEncounter(parentSession);
            QueenEncounter queen = new QueenEncounter(parentSession);
            GymirEncounter gymir = new GymirEncounter(parentSession, hymir, queen);
            return new List<Interaction>() { hymir, gymir };
        }
    }
}
