using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double FUEL_CONSUMPTIONS_INCREMENT = 0.9;

        public Car(double fuelQuantity, double fuelConsumation) 
            : base(fuelQuantity, fuelConsumation)
        {
        }

        public override double FuelConsumation =>
            base.FuelConsumation + FUEL_CONSUMPTIONS_INCREMENT;

        
    }
}
