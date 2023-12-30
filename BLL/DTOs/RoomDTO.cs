using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RoomDTO
    {
        public int RoomID { get; set; }
        public string Availability { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
