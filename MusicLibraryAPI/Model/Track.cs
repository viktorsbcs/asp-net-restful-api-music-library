using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Model
{
    public class Track
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        public string TrackTitle { get; set; }
        
        [Required]
        [DataType(DataType.Duration)]
        public TimeSpan TrackDuration { get; set; }



        public long AlbumId { get; set; }   
        public Album Album { get; set; }
    }
}
