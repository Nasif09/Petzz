using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        [ForeignKey("Registration")]
        public int UID { get; set; }
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        [ForeignKey("Branch")]
        public int BranchID { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime  EndDate { get; set; }
        public int TotalPrice { get; set; }
        public  string Status { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual Room Room { get; set; }
        public virtual Branch Branch { get; set; }  


    }
}
