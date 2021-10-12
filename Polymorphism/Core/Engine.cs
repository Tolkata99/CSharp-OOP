using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicles.Core.Contracts;
using Vehicles.Factories;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        
        private readonly VehicleFactory vehicleFactory;
        public Engine()
        {
            vehicleFactory = new VehicleFactory();
        }
 

        public void Run()
        {
            Vehicle car =  this.ProccesVehicleInfo();
            Vehicle truck = this.ProccesVehicleInfo();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArg[0];
                string vehicleType = cmdArg[1];
                //can be liters or kilometers
                double arg = double.Parse(cmdArg[2]);

                try
                {
                    if (cmdType == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            this.Drive(car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.Drive(truck, arg);
                        }
                    }
                    else if (cmdType == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            this.Refuel(car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.Refuel(truck, arg);
                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private void Refuel(Vehicle vehicle,double liters)
        {
            vehicle.Refuel(liters);
        }

        private void Drive(Vehicle vehicle,double kilometers)
        {
            Console.WriteLine(vehicle.Drive(kilometers));
           
        }

        private Vehicle ProccesVehicleInfo()
        {
            string[] vehicleArg = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string vehicleType = vehicleArg[0];
            double fuelQuontity = double.Parse(vehicleArg[1]);
            double fuelConsumption = double.Parse(vehicleArg[2]);
            
            Vehicle currVehicle = this.vehicleFactory.CreateVehicle(vehicleType, fuelQuontity, fuelConsumption);

            return currVehicle;
        }
    }
}
