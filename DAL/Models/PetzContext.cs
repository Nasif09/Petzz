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
        public DbSet<Token> Tokens { get; set; }


    }
}
