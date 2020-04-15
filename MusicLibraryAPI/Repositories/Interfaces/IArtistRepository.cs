using MusicLibraryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories.Interfaces
{
    public interface IArtistRepository
    {
        
        public IEnumerable<Artist> GetAllArtists { get; }
        public Artist GetArtist(long id);
        public void CreateArtist(Artist artist);
        public void UpdateArtist(Artist artist);
        public void DeleteArtist(long id);
    }
}
