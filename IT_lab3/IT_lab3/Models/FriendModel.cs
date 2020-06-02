using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IT_lab3.Models
{
    public class FriendModel
    {
        [Required]
        [Range(0, 200, ErrorMessage ="The ID Range must be in the range (0, 200)")]
        [Display(Name = "Friend ID")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Place { get; set; }
    }
}