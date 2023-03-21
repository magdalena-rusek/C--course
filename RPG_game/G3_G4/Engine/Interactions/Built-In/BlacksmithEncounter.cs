using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Interactions.Built_In;

namespace Game.Engine.Interactions
{
    class BlacksmithEncounter : ListBoxInteraction
    {
        private int visited = 0;
        private int payment = 0;
        private int help = 0;
        public QueenEncounter myQueen;

        public BlacksmithEncounter(GameSession ses, QueenEncounter myQueen) : base(ses)
        {
            Name = "interaction0005";
            this.myQueen = myQueen;
        }

        protected override void RunContent()
        {
            if (visited > 3) 
            {
                parentSession.SendText("\nHello. Thanks for coming, but I don't have any job for you right now.");
                return;
            }

            parentSession.SendText("\nHello adventurer. My name is James. Could you help me forge the armor?");

            int choice = GetListBoxChoice(new List<string>() { "Sure, no problem!", "Yes, but how much will you pay me for it?", "Do I look like a blacksmith to you?" });
            switch (choice)
            {
                case 0:
                    payment = 0;
                    ForgeArmor();
                    help++;
                    break;
                case 1:
                    parentSession.SendText("Is 18 gold enough?");
                    int choice2 = GetListBoxChoice(new List<string>() { "Yes", "Sorry, that's not enough." });
                    if (choice2 == 0)
                    {
                        payment = 18;
                        ForgeArmor();
                    }
                    else parentSession.SendText("Go away then!");
                    break;
                default:
                    parentSession.SendText("No, you look like a useless vagabond. Go away!");
                    break;
            }

            if (visited == 3) 
            {
                myQueen.peopleHelp += 1;
                return;
            }
        }

        private void ForgeArmor()
        {
            parentSession.SendText("Great! You can use my equipment over there.");
            if (payment == 0)
            {
                parentSession.SendText("Thank you so much for your help!");
                if (help == 3)
                {
                    parentSession.SendText("As a thank you, take this sword");
                    parentSession.AddThisItem(Index.ProduceSpecificItem("item0940"));
                }
            }
            else
            {
                parentSession.SendText("Good. Here is your gold.");
                parentSession.UpdateStat(8, payment); // +18 gold
            }
            visited++;           
        }
    }
}
