using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Shop
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantitiy { get; set; }
        [Required]
        public double Total_Price { get; set; }
        [Required]
        public string Phone_number { get; set; }

        [Required]
        public string Location { get; set; }

        [ForeignKey("Registration")]
        public int User_id { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        [ForeignKey("Order_status")]
        public int Status_Id { get; set; }

        public DateTime Date { get; set; }

        public virtual Registration Registration { get; set; }
        public virtual Product Product { get; set; }

        public virtual Order_status Order_status { get; set; }

    }
}
