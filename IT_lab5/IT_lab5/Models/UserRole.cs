using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace IT_lab5.Models
{
    public class UserRole
    {
        [Required]
        public String Email { get; set; }
        [Required]
        public String Role { get; set; }
        public List<string> AllRoles { get; set; }
        public List<ApplicationUser> AllUsers { get; set; }

        public UserRole()
        {
            AllRoles = new List<string>();
            AllUsers = new List<ApplicationUser>();
        }

    }
}