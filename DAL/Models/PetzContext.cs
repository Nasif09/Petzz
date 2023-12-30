using DAL.Models.Shop;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PetzContext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }   
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }



        public DbSet<Category> Categories { get; set; }

        public DbSet<FeedBack> FeedBacks { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Order_status> Orders_status { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Salary> Salarys { get; set; }


    }
}
