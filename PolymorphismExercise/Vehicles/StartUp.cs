using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();
            Vehicle bus = CreateVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string comand = parts[0];
                string vehicleType = parts[1];
                double parameter = double.Parse(parts[2]);


                try
                {               
                    if (vehicleType == nameof(Car))
                    {
                        proccesComand(car, comand, parameter);
                    }
                    else if (vehicleType == nameof(Bus))
                    {
                        proccesComand(bus, comand, parameter);
                    }
                    else
                    {
                        proccesComand(truck, comand, parameter);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void proccesComand(Vehicle vehicle, string comand, double parameter)
        {
            if (comand == "Drive")
            {

                vehicle.Drive(parameter);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");


            }
            else if (comand == "DriveEmpty")
            {

                Bus vehicle1 = ((Bus)vehicle);
                vehicle1.TurnOffConditionerBus();

                vehicle.Drive(parameter);

                vehicle1.TurnOnConditionerBus();


            }
            else if (comand == "Refuel")
            {
                vehicle.ReFuel(parameter);

            }
        }

        private static Vehicle CreateVehicle()
        {
            string[] parts = Console.ReadLine().Split();
            string type = parts[0];
            double fuelQuantity = double.Parse(parts[1]);
            double fuelConsumation = double.Parse(parts[2]);
            double tankCapacity = double.Parse(parts[3]);


            Vehicle vehicle = null;
            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumation, tankCapacity);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelConsumation, fuelQuantity, tankCapacity);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelConsumation, fuelQuantity, tankCapacity);
            }

            return vehicle;
        }


    }
}
