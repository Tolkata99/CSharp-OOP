using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string comand = parts[0];
                string vehicleType = parts[1];
                double parameter = double.Parse(parts[2]);

                if (comand == "Drive")
                {
                    try
                    {
                        if (vehicleType == nameof(Car))
                        {
                            car.Drive(parameter);

                        }
                        else if (vehicleType == nameof(Truck))
                        {
                            truck.Drive(parameter);
                        }
                        Console.WriteLine($"{vehicleType} travelled {parameter} km");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (comand == "Refuel")
                {
                    if (vehicleType == nameof(Car))
                    {
                        car.ReFuel(parameter);

                    }
                    else if (vehicleType == nameof(Truck))
                    {
                        truck.ReFuel(parameter);
                    }

                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static Vehicle CreateVehicle()
        {
            string[] parts = Console.ReadLine().Split();
            string type = parts[0];
            double fuelQuantity = double.Parse(parts[1]);
            double fuelConsumation = double.Parse(parts[2]);

            Vehicle vehicle = null;
            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumation);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelConsumation, fuelQuantity);
            }

            return vehicle;
        }


    }
}
