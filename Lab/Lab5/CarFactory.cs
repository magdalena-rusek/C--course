using System;
using System.Collections.Generic;
using System.Text;

    class CarFactory : VehicleFactory
    {

        public override Vehicle Create()
        {
            Car c = new Car();
            return c;
        }
    }