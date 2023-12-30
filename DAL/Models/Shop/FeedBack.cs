using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Shop
{
    public class FeedBack
    {

        [Key]
        public int Id { get; set; }

        public string Comment { get; set; }

        [ForeignKey("Product")]
        public int Product_Id { get; set; }

        [ForeignKey("Registration")]
        public int User_Id { get; set; }


        public virtual Registration Registration { get; set; }

        public virtual Product Product { get; set; }

    }
}
