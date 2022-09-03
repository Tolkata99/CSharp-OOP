using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.Models.Hotels
{
    internal class Hotel : IHotel
    {
        private string fullName;
        private int category;

        public Hotel(string fullName, int category)
        {
            this.fullName = fullName;
            this.category = category;
           // this.Rooms = new RoomRespository();
            //this.Bookings//
        }

        public string FullName
        {
            get => this.fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(String.Format(ExceptionMessages.HotelNameNullOrEmpty));
                }
            }
        }

        public int Category
        {
            get => this.category;
            private set
            {
                if (value < 1 && value > 5)
                {
                    throw new ArgumentNullException(String.Format(ExceptionMessages.InvalidCategory));
                }
            }
        }

        public double Turnover
            => Math.Round(Bookings.All().Sum(x => x.ResidenceDuration * x.Room.PricePerNight), 2);



        public IRepository<IRoom> Rooms { get; set; }

        public IRepository<IBooking> Bookings { get; set; }
    }
}
