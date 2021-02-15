using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter User Name")]
        [Display(Name ="User Name")]
        public string userName { get; set; }
        [Required(ErrorMessage ="Enter Password")]
        [Display(Name = "Password")]
        public string password { get; set; }
    }
}
