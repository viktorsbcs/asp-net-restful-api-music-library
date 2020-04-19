using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Model.DTO
{
    public class AlbumCreateDTO
    {


        public string AlbumTitle { get; set; }

        public DateTime ReleaseYear { get; set; }

        public decimal Price { get; set; }

        public long ArtistId { get; set; }

        public long CategoryId { get; set; }

        public List<Track> Tracks { get; set; }
    }
}
