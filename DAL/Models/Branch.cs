using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Branch
    {
        public int BranchID { get; set; }
        public string Brancename { get; set; }
        public string Location { get; set; }
        public int? UID { get; set; }
    }
}
