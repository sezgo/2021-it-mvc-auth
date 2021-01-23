using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2021_it_mvc_auth.Models
{
    public class Movie
    {
        public Movie()
        {
            Clients = new List<Client>();
        }
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Download URL")]
        public string DownloadURL { get; set; }
        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }
        [Required]
        public float Rating { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}