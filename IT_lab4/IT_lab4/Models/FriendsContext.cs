using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IT_lab4.Models
{
    public class FriendsContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }
        public FriendsContext() : base("DefaultConnection") { }

        public static FriendsContext Create()
        {
            return new FriendsContext();
        }


    }
}