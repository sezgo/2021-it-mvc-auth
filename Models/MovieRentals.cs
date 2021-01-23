using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2021_it_mvc_auth.Models
{
    public class MovieRentals
    {
        public MovieRentals()
        {
            Clients = new List<Client>();
        }
        [Key]
        public int MovieId { get; set; }
        public Movie Movie{ get; set; }
        public List<Client> Clients { get; set; }
        public int ClientId { get; set; }
    }
}