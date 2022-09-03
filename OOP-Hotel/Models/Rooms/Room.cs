using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Rooms
{
    internal abstract class Room : IRoom
    {
        private int bedCapacity;
        private double pricerNight = 0;
        public Room(int bedCapacity)
        {
            this.bedCapacity = bedCapacity; 
        }
        public int BedCapacity => this.bedCapacity;

        public double PricePerNight
        {
            get => this.pricerNight;
            private set
            {
                if (value < 0)
                {
                    value = 0;
                    throw new ArgumentException(String.Format(ExceptionMessages.PricePerNightNegative));
                }

                this.pricerNight = value;
            }
        }


        public void SetPrice(double price)
        {
            this.PricePerNight = price;
        }
    }
}
