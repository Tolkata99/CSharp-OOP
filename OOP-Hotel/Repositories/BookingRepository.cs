using BookingApp.Models.Bookings.Contracts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.Repositories
{
    internal class BookingRepository : IRepository<IBooking>
    {
        private List<IBooking> books;

        public BookingRepository()
        {
            this.books = new List<IBooking>();
        }

        public void AddNew(IBooking model)
        {
            this.books.Add(model);
        }

        public IReadOnlyCollection<IBooking> All() => this.books;


        public IBooking Select(string criteria) => this.books.FirstOrDefault(b => b.BookingNumber.ToString() == criteria);
       
    }
}
