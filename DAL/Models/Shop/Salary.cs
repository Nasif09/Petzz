using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Shop
{
    public class Salary
    {
        [Key]

        public int Id { get; set; }

        public double Amount { get; set; }

        [ForeignKey("Registration")]
        public int User_id { get; set; }

        public virtual Registration Registration { get; set; }

    }
}
