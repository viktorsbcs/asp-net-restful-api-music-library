using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Model
{
    public class Album
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseYear { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public long ArtistId { get; set; }
        public Artist Artist { get; set; }

        public long CategoryId { get; set; }
        public Category Category { get; set; }


        public List<Track> Tracks { get; set; }
    }
}
