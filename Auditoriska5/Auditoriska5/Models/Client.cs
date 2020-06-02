using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Auditoriska5.Models
{
    public class Client
    {
        public Client()
        {
            movies = new List<Movie>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MemberCard { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Movie> movies { get; set; }

    }
}