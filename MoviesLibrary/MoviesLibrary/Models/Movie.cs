using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MoviesLibrary.Models
{
    public class Movie
    {
        public Movie()
        {
            clients = new List<Client>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "The Download URL")]
        public string DownloadURL { get; set; }
        [Display(Name = "The Image URL")]
        public string ImageURL { get; set; }
        [Required]
        public float Rating { get; set; }
        public virtual ICollection<Client> clients { get; set; }

    }
}