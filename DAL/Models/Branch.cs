using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }
        public string Branchname { get; set; }
        public string Location { get; set; }
        [ForeignKey("Registration")]
        public int? UID { get; set; }
        public virtual Registration Registration { get; set; }  
    }
}
