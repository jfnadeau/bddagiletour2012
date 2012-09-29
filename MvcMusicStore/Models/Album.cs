using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace MvcMusicStore.Models
{
    [Bind(Exclude = "AlbumId")]
    public class Album
    {
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }

        [DisplayName("Genre")]
        public int GenreId { get; set; }

        [DisplayName("Artiste")]
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Un titre d'album est requis")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Le prix est requis")]
        [Range(0.01, 100.00,
            ErrorMessage = "Le prix doit être entre 0.01 et 100.00")]
        public decimal Price { get; set; }

        [DisplayName("Couverture URL")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}