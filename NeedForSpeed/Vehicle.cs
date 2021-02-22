using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.DefaultFuelConsumption = 1.25;
        }

        //        •	DefaultFuelConsumption – double 
        //•	FuelConsumption – virtual double
        //•	Fuel – double
        //•	HorsePower – int
        //•	virtual void Drive(double kilometers)

        public double DefaultFuelConsumption { get; set; }

        public virtual double FuelConsumption
        {
            get
            {
                return this.DefaultFuelConsumption;
            }
            set
            {
                this.DefaultFuelConsumption = value;
            }
        }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }




        public virtual void Drive(double kilometers)
        {
            double fuel = kilometers * this.FuelConsumption;
            this.Fuel -= fuel;
           
        }
    }
}
