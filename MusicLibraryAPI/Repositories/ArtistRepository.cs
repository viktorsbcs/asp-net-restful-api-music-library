using Microsoft.EntityFrameworkCore;
using MusicLibraryAPI.DbContexts;
using MusicLibraryAPI.Model;
using MusicLibraryAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly AppDbContext _appDbContext;

        public ArtistRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public IEnumerable<Artist> GetAllArtists => _appDbContext.Artists.Include(x => x.Albums).ToList();

        public void CreateArtist(Artist artist)
        {
            _appDbContext.Add(artist);
            _appDbContext.SaveChanges();
        }

        public void DeleteArtist(long id)
        {
            var artist = _appDbContext.Artists.Find(id);
            _appDbContext.Remove(artist);
            _appDbContext.SaveChanges();
        }

        public Artist GetArtist(long id)
        {
            try
            {
                var artist = _appDbContext.Artists.Include(x => x.Albums).First(x => x.Id == id);
                return artist;
            }
            catch (InvalidOperationException)
            {
                return null;
            }


        }

        public void UpdateArtist(Artist artist)
        {
            _appDbContext.Update(artist);
            _appDbContext.SaveChanges();
        }
    }
}
