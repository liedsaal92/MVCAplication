using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcApplication.Models
{
    public class album
    {
        public string  Title { get; set; }
        public Genre Genre { get; set; }
        public int albumId { get; set; }
        public int genreId { get; set; }
        public int artistId { get; set; }
        public decimal Price { get; set; }
        public string albumArtUrl { get; set; }
        public Artist Artist { get; set; }
    }
    
}