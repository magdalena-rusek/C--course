using System;
using System.Collections.Generic;
using System.Text;

    class TrainFactory : VehicleFactory
    {
        public override Vehicle Create() 
        {
            Train t = new Train();
            return t;
        }
    }