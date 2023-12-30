using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum UserRole
    {
        Customer,
        Manager,
        Admin
    }

    public class Registration
    {
        [Key]
        public int UID { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "Username must be 8 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(6, ErrorMessage = "Password must be at 6 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        [EnumDataType(typeof(UserRole), ErrorMessage = "Invalid role.")]
        public string Role { get; set; }
    }


}
