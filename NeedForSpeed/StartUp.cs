namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Car(150, 200);

            vehicle.Drive(20);

            System.Console.WriteLine(vehicle.Fuel);

            System.Console.WriteLine(vehicle.FuelConsumption);

            System.Console.WriteLine(vehicle.HorsePower);
        }
    }
}
