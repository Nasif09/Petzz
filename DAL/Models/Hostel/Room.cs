using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        [Required]
        public string Availability { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
