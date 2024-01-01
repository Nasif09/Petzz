using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Hostel
{
    public class BookingDTO
    {
        public int BookingID { get; set; }
        public int UID { get; set; }
        public int RoomID { get; set; }
        public int BranchID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
