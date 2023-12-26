using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int UID { get; set; }
        public int RoomID { get; set; }   
        public int BranchID { get; set; }
    }
}
