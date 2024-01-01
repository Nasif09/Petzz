using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Hostel
{
    internal class BookingRepo : Repo, IRepo<Booking, int, bool>, IRoom<Booking, int, DateTime, Booking>
    {
        public List<Booking> GetByID(int id, DateTime UIU)
        {
            var data = db.Bookings.Where(x => x.RoomID == id && x.StartDate == UIU).ToList();
            return data;
        }
        public bool Create(Booking obj)
        {
            db.Bookings.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Bookings.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Booking> Read()
        {
            return db.Bookings.ToList();
        }

        public Booking Read(int id)
        {
            return db.Bookings.Find(id);
        }

        public bool Update(Booking obj)
        {
            var ex = Read(obj.BookingID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
