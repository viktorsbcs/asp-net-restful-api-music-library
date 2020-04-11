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
        public Guid Id { get; set; }

        [Required]
        public Category AlbumCategory { get; set; }

        [Required]
        public ICollection<Track> TrackList { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseYear { get; set; }
    }
}
