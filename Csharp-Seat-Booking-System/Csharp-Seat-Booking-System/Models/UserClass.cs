using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp_Seat_Booking_System.Models
{
    public class UserClass
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Enter Username")]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please Confirm Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pwd")]
        public string Confirmpwd { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Email")]
        public string Uemail { get; set; }
    }
}
