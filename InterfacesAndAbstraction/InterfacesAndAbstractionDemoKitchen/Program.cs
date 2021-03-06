using System;

namespace InterfacesAndAbstractionDemoKitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kitchen kitchen = new Kitchen();
            GourmeKitchen kitchen = new GourmeKitchen();

            Waiter waiter = new Waiter() { Kitchen = kitchen };
            waiter.Kitchen.OrderMeal("supa");

            CEO ceo = new CEO() { Kitchen = kitchen };
            ceo.Kitchen.CalculateCost();

            Tehnician tech = new Tehnician() { Kitchen = kitchen };
            tech.Kitchen.Machines.Add("e");
            tech.Kitchen.ListOfMachines();




        }
    }
}
