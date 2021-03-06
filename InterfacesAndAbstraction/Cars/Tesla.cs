using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color,int battery)
        {
            Battery = battery;
            Model = model;
            Color = color;
        }

        public int Battery { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }


        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} Batteries";
        }
    }
}
