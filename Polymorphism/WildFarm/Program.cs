using System;
using System.Collections.Generic;
using WildFarm.Animal.Birds;
using WildFarm.Animal.Mammal;
using WildFarm.Animal.Mammal.Feline;
using WildFarm.Foods;

namespace WildFarm.Animal
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] animalParts = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Animal animal = CreateAnimal(animalParts);
                animals.Add(animal);

                string[] foodParts = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

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

            foreach (var animal in animals)
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
            else if (type == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }
            else if (type == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }
            else if (type == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }

            return food;


        }

        private static Animal CreateAnimal(string[] animalParts)
        {
            string type = animalParts[0];
            //            •	Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}";
            //•	Birds - "{Type} {Name} {Weight} {WingSize}";
            //•	Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}";

            Animal animal = null;

            string name = animalParts[1];
            double weight = double.Parse(animalParts[2]);

            if (type == nameof(Hen))
            {
                animal = new Hen(name, weight, int.Parse(animalParts[3]));
            }
            else if (type == nameof(Own))
            {
                animal = new Own(name, weight, int.Parse(animalParts[3]));
            }
            else if (type == nameof(Mouse))
            {
                animal = new Mouse(name, weight,animalParts[3]);
            }
            else if (type == nameof(Dog))
            {
                animal = new Dog(name, weight, animalParts[3]);
            }
            else if (type == nameof(Tiger))
            {
                animal = new Tiger(name, weight, animalParts[3], animalParts[4]);
            }
            else if (type == nameof(Cat))
            {
                animal = new Cat(name, weight, animalParts[3], animalParts[4]);

            }


            return animal;
        }
    }
}
