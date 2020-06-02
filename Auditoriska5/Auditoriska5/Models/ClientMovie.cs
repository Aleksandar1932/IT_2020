using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditoriska5.Models
{
    public class ClientMovie
    {
        public Movie Movie { get; set; }
        public List<Client> Clients { get; set; }
        public int MovieId { get; set; }
        public int ClientId { get; set; }
    }
}