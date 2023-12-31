using DAL.Models.Shop;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Shop
{
    public class OrderDTO
    {
      
        public int Id { get; set; }
        
        public int Quantitiy { get; set; }
     
        public double Total_Price { get; set; }
     
        public string Phone_number { get; set; }

       
        public string Location { get; set; }

        public int User_id { get; set; }
  
        public int Product_Id { get; set; }
        public int Status_Id { get; set; }

        public DateTime Date { get; set; }

    }
}
