using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_CONSUMTIONS_INCREMENT = 1.6;

        private const double REFUEL_SUCCESS_COEFF = 0.95;

        public Truck(double fuelQuantity, double fuelConsumation)
            : base(fuelQuantity, fuelConsumation)
        {
        }

        public override double FuelConsumation =>
            base.FuelConsumation + FUEL_CONSUMTIONS_INCREMENT;

        public override void Refuel(double amount)
        {
            
            base.Refuel(amount * REFUEL_SUCCESS_COEFF);
        }
    } 
}
