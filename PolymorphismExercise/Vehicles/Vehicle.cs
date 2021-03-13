using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelConsumation, double fuel, double airConditionerModifer)
        {
            AirConditionerModifer = airConditionerModifer;
            Fuel = fuel;
            FuelConsumation = fuelConsumation;
        }

        private double AirConditionerModifer { get; set; }

        public double Fuel { get; set; }

        public double FuelConsumation { get; set; }

        public void Drive(double distance)
        {
            double requiredFuel = (this.FuelConsumation + this.AirConditionerModifer) * distance;

            if (requiredFuel > Fuel)
            {
                throw new Exception($"{GetType().Name} needs refueling");
            }

            this.Fuel -= requiredFuel;
        }

        public virtual void ReFuel(double amount)
        {
            this.Fuel += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:F2}";
        }

    }
}
