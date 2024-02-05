using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Hostel
{
    public class BookingRoomDTO : BookingDTO
    {
        public List<RoomDTO> Room { get; set; }
    }
}
