using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Shop
{
    public class ProductDTO
    {


        public int Id { get; set; }
  
        public string Name { get; set; }


        public double Price { get; set; }
     
        public int Quantity { get; set; }
        public int Category_Id { get; set; }
    }
}
