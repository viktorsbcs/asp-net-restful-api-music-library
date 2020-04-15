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
    public class AlbumRepository : IAlbumRepository
    {
        private readonly AppDbContext _appDbContext;

        public AlbumRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }


        public IEnumerable<Album> GetAllAlbums => _appDbContext.Albums.Include(x => x.Tracks).Include(x => x.Category).Include(x => x.Artist).ToList();

        public void CreateAlbum(Album album)
        {
            //album.Id = 0  (to ensure that sql server will generate proper id for primary key
            _appDbContext.Add(album);
            _appDbContext.SaveChanges();
        }

        public void DeleteAlbum(long id)
        {
            var album = _appDbContext.Albums.Find(id);
            _appDbContext.Remove(album);
            _appDbContext.SaveChanges();
        }

        public Album GetAlbum(long id)
        {
            try
            {
                return _appDbContext.Albums.Include(x => x.Tracks).Include(x => x.Category).Include(x => x.Artist).First(x => x.Id == id);

            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public void UpdateAlbum(Album album)
        {
            //If only specific parameters need to be updated

            //var albumCurrent = _appDbContext.Albums.Find(album.Id);
            //albumCurrent.Price = album.Price;
            //_appDbContext.SaveChanges();

            _appDbContext.Update(album);
            _appDbContext.SaveChanges();
        }
    }
}
