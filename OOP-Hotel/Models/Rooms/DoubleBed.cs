using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Rooms
{
    internal class DoubleBed : Room
    {
        private const int MaxbedCapacity = 2;
        public DoubleBed() : base(MaxbedCapacity)
        {
        }
    }
}
