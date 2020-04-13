using MusicLibraryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories
{
    public interface IAlbumRepository
    {
        public IEnumerable<Album> GetAllAlbums { get; }
        public Album GetAlbum(long Id);
        public void AddAlbum(Album album);
        public void UpdateAlbum(Album album);
        public void DeleteAlbum(long id);
    }
}
