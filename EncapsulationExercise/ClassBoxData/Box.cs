using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }


        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                this.ThrowIsValid(value, nameof(this.Length));
                this.length = value;
            }
        }



        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.ThrowIsValid(value, nameof(this.Width));

                this.width = value;
            }

        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.ThrowIsValid(value, nameof(this.Height));

                this.height = value;
            }

        }

        public double CalculateVolume()
        {
            return this.height * this.length * this.width;
        }

        public double LateralSurfaceArea()
        {
            // = 2lh + 2wh
            return 2 * this.length * this.height + 2 * this.width * this.height;

        }
        public double SurfaceArea()
        {
            //2lw + 2lh + 2wh

            return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
        }
        private void ThrowIsValid(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }


    }
}
