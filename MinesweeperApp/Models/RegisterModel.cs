using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Enter your First Name")]
        [Display(Name ="First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Enter your Last Name")]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Male or Female")]
        [Display(Name = "Sex")]
        public string sex { get; set; }

        [Required(ErrorMessage = "Enter your Age")]
        [Display(Name = "Age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Enter your State")]
        [Display(Name = "State")]
        public string state { get; set; }

        [Required(ErrorMessage = "Enter your Email")]
        [Display(Name = "Email Address")]
        public string email { get; set; }

        [Required(ErrorMessage = "Enter your Address")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required(ErrorMessage = "Enter your User Name")]
        [Display(Name = "User Name")]
        public string username { get; set; }

        [Required(ErrorMessage = "Enter your Password")]
        [Display(Name = "Password")]
        public string password { get; set; }
    }
}
