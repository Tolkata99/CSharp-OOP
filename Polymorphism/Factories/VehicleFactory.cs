using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models;

namespace Vehicles.Factories
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {

        }

        public Vehicle CreateVehicle(string vehicleType,
            double fuelQuantity, double fuelConsumation)
        {
            Vehicle vehicle;

            if (vehicleType == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumation);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumation);
            }
            else
            {
                throw new InvalidOperationException(ExceptionsMessage.INVALID_VEHICLE_TYPE);
            }

            return vehicle;
        }


    }
}
