using System;
using System.Collections.Generic;
using WildFarm.Animal.Mammals.Feliles;
using WildFarm.Animals.Mammals;
using WildFarm.Birds;
using WildFarm.Foods;
using WildFarm.Mammals;
using WildFarm.Mammals.Feliles;

namespace WildFarm.Animal
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>(); 
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] AnimalParts = line.Split();

                Animal animal = CreateAnimal(AnimalParts);
                animalList.Add(animal);

                string[] foodParts = Console.ReadLine().Split();

                Food food = CreateFood(foodParts);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            foreach (var animal in animalList)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] foodParts)
        {
            string type = foodParts[0];
            int quantity = int.Parse(foodParts[1]);

            Food food = null;

            if(type == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if(type == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (type == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }
            else if (type == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }

            return food;
        }

        private static Animal CreateAnimal(string[] animalParts)
        {
            string type = animalParts[0];
            string name = animalParts[1];
            double weight = double.Parse(animalParts[2]);
            

            Animal animal = null;

            if (type == nameof(Hen))
            {

                animal = new Hen(name, weight, double.Parse(animalParts[3]));
            }
            else if (type == nameof(Owl))
            {
                animal = new Owl(name, weight, double.Parse(animalParts[3]));
            }
            else if (type == nameof(Dog))
            {
                animal = new Dog(name, weight, animalParts[3]);
            }
            else if (type == nameof(Mouse))
            {
                animal = new Mouse(name, weight, animalParts[3]);

            }
            else if (type == nameof(Cat))
            {
                animal = new Cat(name, weight, animalParts[3], animalParts[4]);
            }
            else if (type == nameof(Tiger))
            {
                animal = new Tiger(name, weight, animalParts[3], animalParts[4]);
            }

            return animal;
            
        }
    }
}
