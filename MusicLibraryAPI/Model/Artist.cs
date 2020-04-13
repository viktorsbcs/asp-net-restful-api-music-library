using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Model
{
    public class Artist
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ArtistName { get; set; }

        public List<Album> Albums { get; set; }
    }
}
