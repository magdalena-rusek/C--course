using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    public class NavigationPanel : ITool
    {
        private int currentNumber;
        private List<Destination> ports;
        private List<int> travelDays;

        public int TotalNumber { get; set; }

        public void AddPort(string name, int days) 
        {
            Destination d = new Destination(name);
            ports.Add(d);
            travelDays.Add(days);
        }

        public void Arrived() 
        {
            int i = 0;
            string s = "";

            foreach (Destination d in ports)
            {
                if (i == currentNumber)
                {
                    s = d.Name;
                    break;
                }

                i++;
            }
            Console.WriteLine("UPDATE. The current location is: " + s);
            currentNumber++;
        }

        public void Conserve() 
        {
            Console.WriteLine("Conserving... Navigation Panel ready");
        }

        public int DaysToNextDestination() 
        {
            int i = 0, d = 0;

            foreach (int k in travelDays)
            {
                if (i == currentNumber)
                {
                    d = k;
                    break;
                }

                i++;
            }
            return d; 
        }

        public NavigationPanel() 
        {
            currentNumber = 0;
            ports = new List<Destination>();
            travelDays = new List<int>();
        }

        public string NextDestination() 
        {
            int i = 0;
            string s = "";

            foreach(Destination d in ports)
            {
                if (i == currentNumber)
                {
                    s = d.Name;
                    break;
                }

                i++;
            }
            return s;
        }
    }
}