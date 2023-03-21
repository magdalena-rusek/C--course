using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Monsters;
using Game.Engine.Interactions.Built_In;

namespace Game.Engine.Interactions
{
    class PolicemanEncounter : ListBoxInteraction
    {
        private int visited = 0;
        private int payment = 0;
        public QueenEncounter myQueen;
        
        public PolicemanEncounter(GameSession ses, QueenEncounter myQueen) : base(ses)
        {
            Name = "interaction0006";
            this.myQueen = myQueen;
        }

        protected override void RunContent()
        {
            if (visited > 1) // already visited this place more than 3 times
            {
                parentSession.SendText("\nHello. Thanks for coming, but there are not any thugs right now.");
                return;
            }

            parentSession.SendText("\nHello adventurer. My name is Andrew. Could you help me catch and kill thug?");

            int choice = GetListBoxChoice(new List<string>() { "Sure! This is my specialty", "Not for free. Tt's a dangerous task" });
            switch (choice)
            {
                case 0:
                    payment = 0;
                    KillThug();
                    break;
                case 1:
                    parentSession.SendText("Is 30 gold enough?");
                    int choice2 = GetListBoxChoice(new List<string>() { "Fine.", "Sorry, that's not enough." });
                    if (choice2 == 0)
                    {
                        payment = 30;
                        KillThug();
                    }
                    else parentSession.SendText("Go away then!");
                    break;
                default:
                    parentSession.SendText("No, you look like a useless vagabond. Go away!");
                    break;
            }

            if (visited == 1) 
            {
                myQueen.peopleHelp += 1;
                return;
            }
        }
        private void KillThug()
        {
            Thug thug = new Thug(3);
            parentSession.SendText("Great!");

            parentSession.FightThisMonster(thug);

            if (payment == 0)
            {
                parentSession.SendText("Thank you so much for your help!");
            }
            else
            {
                parentSession.SendText("Good. Here is your gold.");
                parentSession.UpdateStat(8, payment); // +30 gold
            }
            visited++;
        }
    }
}
