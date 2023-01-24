using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    class Submarine
    {
        // all fields and properties
        private List<Human> crew;
        private List<ITool> equipment;
        private NavigationPanel navPanel;
        private FoodSupply foodSupply;
        private OxygenSupply oxygenSupply;
        private Waste genericWaste;
        private Engine engine;

        // constructor
        public Submarine(Engine eng, NavigationPanel panel)
        {
            crew = new List<Human>();
            foodSupply = new FoodSupply();
            oxygenSupply = new OxygenSupply(100000.0); // maximum oxygen capacity set to 100k
            genericWaste = new Waste("Generic");
            engine = eng; // engine and navigation panel will be prepared somewhere else
            navPanel = panel;
            equipment = new List<ITool>()
            {
                navPanel
            };
        }

        // methods
        private void AddCrewMember(Human h) { crew.Add(h); } // for private use only
        public void Recruit(int crewmembers, int scientists)
        {
            //always include one captain in the crew
            AddCrewMember(new Captain(2.0 * Human.MedianSalary));
            //how many crewmembers to include
            for (int i = 0; i < crewmembers; i++)
            {
                AddCrewMember(new Crewmember(Human.MedianSalary));
            }
            //for scientists, also create new scientific probes
            //and add them to the equipment list
            for (int i = 0; i < scientists; i++)
            {
                Scientist sc = new Scientist(1.5 * Human.MedianSalary);
                ScientificProbe p = new ScientificProbe();
                sc.MyProbe = p;
                equipment.Add(p);
                AddCrewMember(sc);
            }
            Console.WriteLine("Recruited:\n\t1 captain\n\t" + crewmembers + " crewmembers\n\t" + scientists + " scientists\n");
        }

        // function used to increase the number of supplies
        // different supplies have different cost, the total cost is returned as double
        public double RefillStocks(double food, double fuel)
        {
            double refillCost = 50.0 * food + 10.0 * genericWaste.Amount;
            foodSupply.Amount += food;
            oxygenSupply.Amount = oxygenSupply.MaxCapacity;
            genericWaste.Amount = 0.0;
            refillCost += engine.Refill(fuel); // Engine.cs should have a similar method
            return refillCost;
        }

        // function used to simulate one day of travel 
        private void OneDayOfTravel()
        {
            engine.Fuel1.Amount = 100;
            engine.OneDayOfTravel(); // Engine.cs should have a similar method
            // first, everyone needs to eat and breathe
            double foodUse = 0.0;
            double O2use = 0.0;
            foreach (Human h in crew)
            {
                foodUse += h.Eat();
                O2use += h.Breathe();
            }
            foodSupply.Amount -= foodUse;
            foodSupply.HowMuchLeft();
            oxygenSupply.Amount -= O2use;
            oxygenSupply.HowMuchLeft();
            genericWaste.Amount += 50.0;
            genericWaste.HowMuchLeft();
            // now, take care of the equipment
            foreach (ITool tool in equipment) tool.Conserve();
            // and use scientists to collect some data
            foreach (Human human in crew)
            {
                if (human.GetType().Equals(typeof(Scientist))) //meaning: if this human is a scientist
                {
                    Scientist tmp = (Scientist)human; //meaning: treat human as a member of the Scientist class specifically
                    tmp.Work();
                }
            }
            Console.WriteLine();
        }

        // function used to simulate the entire journey
        public void Travel()
        {
            int days = 0;
            for (int i = 0; i < navPanel.TotalNumber; i++) //navPanel.TotalNumber says how many ports we need to visit
            {
                Console.WriteLine("Next destination: " + navPanel.NextDestination()); //what's the next destination?
                for (int j = 0; j < navPanel.DaysToNextDestination(); j++) //and how many days we need to travel?
                {
                    Console.WriteLine("****\tDAY " + days + "\t****");
                    days++;
                    OneDayOfTravel(); //day after day after day...
                }
                navPanel.Arrived(); //finally arrived - navPanel needs to know this to update the current destination
                Console.WriteLine();
            }
        }

        // utility function to check our supplies at any given moment
        public void CheckSupplies()
        {
            engine.CheckSupplies(); // Engine.cs should have a similar method
            foodSupply.HowMuchLeft();
            oxygenSupply.HowMuchLeft();
            genericWaste.HowMuchLeft();
        }
    }
}
