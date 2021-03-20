using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private new const double AirConditionerModifer = 1.6;

        public Truck(double fuel, double fuelConsumation,double tankCapacity) 
            : base(fuel, fuelConsumation, tankCapacity, AirConditionerModifer)
        {
        }

        public override void ReFuel(double amount)
        {
            if(amount + base.Fuel > base.TankCapacity)
            {
                base.ReFuel(amount);
            }
            base.ReFuel(amount * 0.95);
        }

    }
}
