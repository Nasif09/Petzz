using DAL.Models.Shop;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.EXTEND
{
    public class FeedBackDTO
    {


        public int Id { get; set; }

        public string Comment { get; set; }


        public int Product_Id { get; set; }

       
        public int User_Id { get; set; }


   
    }
}
