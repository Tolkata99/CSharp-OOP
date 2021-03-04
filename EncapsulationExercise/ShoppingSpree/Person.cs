using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> product;

        public Person(string name, decimal cost)
        {
            this.Name = name;
            this.Money = cost;

            this.product = new List<Product>();

        }


        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ThrowIfNameEmpty(value, "Name cannot be empty");

                this.name = value;
            }


        }

        public decimal Money
        {
            get => this.money;
            private set
            {
                Validator.ThrowIfCostEmpty(value, "Money cannot be negative");

                this.money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }


            this.product.Add(product);

            this.Money -= product.Cost;



        }

        public override string ToString()
        {
            if (this.product.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }

            return $"{this.Name} - {string.Join(", ",this.product.Select(n => n.Name))}";
        }
    }
}
