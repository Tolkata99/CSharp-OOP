using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            var product = new Dictionary<string, Product>();
            try
            {
                people = ReadPeople();
                product = Readproduct();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            

            while (true)
            {
                string line = Console.ReadLine();
                if(line == "END")
                {
                    break;
                }

                var parts = line.Split();

                var personName = parts[0];
                var productName = parts[1];

                Person person = people[personName];
                Product products = product[productName];


                try
                {
                    person.AddProduct(products);

                    Console.WriteLine($"{personName} bought {productName}");

                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                
              

            }

            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }


        }

        private static Dictionary<string, Product> Readproduct()
        {
            var result = new Dictionary<string, Product>();

            var parts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in parts)
            {
                var namePrroduct = item.Split("=", StringSplitOptions.RemoveEmptyEntries);

                var productName = namePrroduct[0];
                var cost = decimal.Parse(namePrroduct[1]);

                result[productName] = new Product(productName,cost);
            }

            return result;
        }

        private static Dictionary<string, Person> ReadPeople()
        {
            var result = new Dictionary<string, Person>();

            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var personData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);

                var name = personData[0];
                var money = decimal.Parse(personData[1]);

                result[name] = new Person(name, money);
            }

            return result;
        }


    }
}
