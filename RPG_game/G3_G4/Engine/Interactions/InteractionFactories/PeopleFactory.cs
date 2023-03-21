using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.InteractionFactories
{
    [Serializable]
    class PeopleFactory : InteractionFactory
    {
        public List<Interaction> CreateInteractionsGroup(GameSession parentSession)
        {
            // Gymir and Hymir must always appear together in the game world
            HymirEncounter hymir = new HymirEncounter(parentSession);
            QueenEncounter queen = new QueenEncounter(parentSession);
            PolicemanEncounter police = new PolicemanEncounter(parentSession, queen);
            BlacksmithEncounter blacksmith = new BlacksmithEncounter(parentSession, queen);
            GymirEncounter gymir = new GymirEncounter(parentSession, hymir, queen);
            FarmerEncounter farmer = new FarmerEncounter(parentSession, queen, police, blacksmith, gymir);
            return new List<Interaction>() { hymir, gymir, queen, police, blacksmith, farmer };
        }
    }
}
