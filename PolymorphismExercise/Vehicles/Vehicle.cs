using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuel;

        protected Vehicle(double fuelConsumation, double fuel,double tankCapacity , double airConditionerModifer)
        {
            AirConditionerModifer = airConditionerModifer;
            TankCapacity = tankCapacity;
            Fuel = fuel;
            FuelConsumation = fuelConsumation;
        }

        protected double AirConditionerModifer { get; set; }

        public double Fuel
        {
            get => fuel;
            private set
            {
                if(value > this.TankCapacity)
                {
                    fuel = 0;
                }

                fuel = value;
            }
        }

        public double FuelConsumation { get; private set; }

        public double TankCapacity { get; private set; }

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
            if(amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if((amount + Fuel) > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            this.Fuel += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:F2}";
        }

    }
}
