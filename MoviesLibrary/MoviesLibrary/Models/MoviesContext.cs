using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesLibrary.Models
{
    public class MoviesContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public MoviesContext() : base("DefaultConnection") { }
        public static MoviesContext Create()
        {
            return new MoviesContext();
        }
    }
}