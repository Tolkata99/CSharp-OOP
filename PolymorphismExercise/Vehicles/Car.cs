using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle
    {
        private const double CarAirConditionerModifer = 0.9;

        public Car(double fuel, double fuelConsumation) 
            : base(CarAirConditionerModifer, fuel, fuelConsumation)
        {
        }

       
    }
}
