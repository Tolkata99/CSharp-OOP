using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle
    {
        private const double CarAirConditionerModifer = 0.9;

        public Car(double fuel, double fuelConsumation,double tankCapacity) 
            : base(CarAirConditionerModifer, fuel,tankCapacity, fuelConsumation)
        {
        }

       
    }
}
