using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication.Models
{
    [Bind(Exclude = "albumId")]
    public class album
    {
        [Required(ErrorMessage="El nombre del album es requerido")]
        [StringLength(160)]
        public string  Title { get; set; }

        public virtual Genre Genre { get; set; }
        
        [ScaffoldColumn(false)]
        public int albumId { get; set; }

        [DisplayName("Genre")]
        public int genreId { get; set; }

        [DisplayName("Artist")]
        public int artistId { get; set; }

        [Required(ErrorMessage="El precio del album es requerido")]
        [Range(0.01,100.00,ErrorMessage="El precio se debe de encontrar entre 0.01 y 100.00")]
        public decimal Price { get; set; }

        [DisplayName("Album url")]
        [StringLength(1024)]
        public string albumArtUrl { get; set; }

        public virtual Artist Artist { get; set; }
    }
    
}