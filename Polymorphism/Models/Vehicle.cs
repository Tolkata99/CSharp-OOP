using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Factories;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDriveable, IRefuellable
    {
        private const string SUCC_DRIVED_MSG = "{0} travelled {1} km";

        protected Vehicle(double fuelQuantity,double fuelConsumation)
        {
            this.FuelConsumation = fuelConsumation;
            this.FuelQuantity = fuelQuantity;
        }



        public double FuelQuantity { get; private set; }


        public virtual double FuelConsumation { get;}



        public string Drive(double amount)
        {
            double fuelNeeded = amount * this.FuelConsumation;
            
            if(fuelNeeded > this.FuelQuantity)
            {
                throw new InvalidOperationException(String.Format
                    (ExceptionsMessage.NOT_ENOUGH_FUEL, this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;

            return (String.Format(SUCC_DRIVED_MSG,this.GetType().Name,amount));
        }

        public virtual void Refuel(double amount)
        {
            if(amount <= 0)
            {
                throw new InvalidOperationException
                    (ExceptionsMessage.FUEL_NOT_POSITIVE);
            }

            this.FuelQuantity += amount;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }

        public static implicit operator Vehicle(VehicleFactory v)
        {
            throw new NotImplementedException();
        }
    }
}
