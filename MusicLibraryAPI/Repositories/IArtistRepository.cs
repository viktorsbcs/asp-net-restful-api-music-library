using MusicLibraryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories
{
    public interface IArtistRepository
    {
        
        public IEnumerable<Artist> Artists { get; }
        public Artist GetArtist(long Id);
        public void AddArtist(Artist artist);
        public void UpdateArtist(Artist artist);
        public void DeleteArtist(long Id);
    }
}
