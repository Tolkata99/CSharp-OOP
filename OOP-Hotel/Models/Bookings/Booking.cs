﻿using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Bookings
{
    internal class Booking : IBooking
    {
        private int residenceDuration;
        private int adultCount;
        private int childrenCount;
        private int bookingNumber;

        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {
            this.Room = room;
            this.residenceDuration = residenceDuration;
            this.adultCount = adultCount;
            this.childrenCount = childrenCount;
            this.bookingNumber = bookingNumber;
        }

        public IRoom Room { get; private set; }

        public int ResidenceDuration
        {
            get => this.residenceDuration;
            private set
            {
                if(value < 1)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.DurationZeroOrLess));
                }

                this.residenceDuration = value;
            }
        }

        public int AdultsCount
        {
            get => this.adultCount;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.AdultsZeroOrLess));
                }

                this.adultCount = value;
            }
        }

        public int ChildrenCount
        {
            get => this.childrenCount;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.ChildrenNegative));
                }

                this.childrenCount = value;
            }
        }

        public int BookingNumber => bookingNumber;
      



        public string BookingSummary()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Booking number: {this.BookingNumber}");
            sb.AppendLine($"Room type: {this.Room.GetType().Name}");
            sb.AppendLine($"Adults: {this.AdultsCount} Children: {this.ChildrenCount}");
            sb.AppendLine($"BTotal amount paid: {TotalPaid():F2} $");

            return sb.ToString().TrimEnd();
        }

        private double TotalPaid() => Math.Round(this.Room.PricePerNight * this.ResidenceDuration,2);
        
    }
}
