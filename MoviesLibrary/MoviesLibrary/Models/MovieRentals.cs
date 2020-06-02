using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesLibrary.Models
{
    public class MovieRentals
    {
        public Movie Movie { get; set; }
        public List<Client> Clients { get; set; }

        public MovieRentals()
        {
            Clients = new List<Client>();
        }
    }
}