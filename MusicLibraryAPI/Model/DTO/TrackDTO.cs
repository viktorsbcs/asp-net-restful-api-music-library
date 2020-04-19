using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Model.DTO
{
    public class TrackDTO
    {
        public long Id { get; set; }

        public string TrackTitle { get; set; }

        public TimeSpan TrackDuration { get; set; }

        public long AlbumId { get; set; }

        public long ArtistId { get; set; }

        public string AlbumTitle { get; set; }
    }

    
}
