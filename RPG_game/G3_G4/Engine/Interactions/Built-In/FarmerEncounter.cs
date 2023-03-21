using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Interactions.Built_In;

namespace Game.Engine.Interactions
{
    class FarmerEncounter : ListBoxInteraction
    {
        private int visited = 0;
        private int payment = 0;
        public QueenEncounter myQueen;
        private PolicemanEncounter police;
        private BlacksmithEncounter blacksmith;
        private GymirEncounter gymir;

        public FarmerEncounter(GameSession ses, QueenEncounter myQueen, PolicemanEncounter police, BlacksmithEncounter blacksmith, GymirEncounter gymir) : base(ses)
        {
            Name = "interaction0008";
            this.myQueen = myQueen;
            this.police = police;
            this.blacksmith = blacksmith;
            this.gymir = gymir;
        }

        protected override void RunContent()
        {
            if (visited > 1)
            {
                parentSession.SendText("\nHello. Thanks for coming, but I don't have any job for you right now.");
                return;
            }

            parentSession.SendText("\nHello adventurer. My name is Johny. Could you help me at the farm?");

            int choice = GetListBoxChoice(new List<string>() { "Sure, no problem!", "No, I have no time." });
            switch (choice)
            {
                case 0:
                    payment = 0;
                    Planting();
                    break;
                case 1:
                    parentSession.SendText("OK");
                    break;
                default:
                    parentSession.SendText("No, you look like a useless vagabond. Go away!");
                    break;
            }

            if (visited == 1)
            {
                myQueen.peopleHelp += 1;
            }
            if (police.myQueen.peopleHelp == 1)
            {
                myQueen.peopleHelp += 1;
            }
            if (blacksmith.myQueen.peopleHelp == 1)
            {
                myQueen.peopleHelp += 1;
            }
            if (gymir.myQueen.peopleHelp == 1)
            {
                myQueen.peopleHelp += 1;
            }
            if (myQueen.peopleHelp >= 3)
            {
                myQueen.Strategy = new QueenLovelyStrategy();
            }
        }

        private void Planting()
        {
            parentSession.SendText("Great! You can use my equipment over there.");
            if (payment == 0)
            {
                parentSession.SendText("Thank you so much for your help!");
                parentSession.SendText("As a thank you, take this item");
                parentSession.AddThisItem(Index.RandomItem());               
            }       
            visited++;
        }
    }
}
