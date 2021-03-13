using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirConditionerModifer = 1.6;

        public Truck(double fuel, double fuelConsumation) 
            : base(fuel, fuelConsumation, AirConditionerModifer)
        {
        }

        public override void ReFuel(double amount)
        {
            base.ReFuel(amount * 0.95);
        }

    }
}
