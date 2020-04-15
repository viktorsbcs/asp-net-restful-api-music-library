using MusicLibraryAPI.DbContexts;
using MusicLibraryAPI.Model;
using MusicLibraryAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories
{
    public class TrackRepository : ITrackRepository
    {
        private readonly AppDbContext _appDbContext;

        public TrackRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public IEnumerable<Track> GetAllTracks => _appDbContext.Tracks.ToList();

        public void CreateTrack(Track track)
        {
            _appDbContext.Add(track);
            _appDbContext.SaveChanges();
        }

        public void DeleteTrack(long id)
        {
            var track = _appDbContext.Tracks.Find(id);
            _appDbContext.Remove(track);
            _appDbContext.SaveChanges();
        }

        public Track GetTrack(long id)
        {
            return _appDbContext.Tracks.Find(id);
        }

        public void UpdateTrack(Track track)
        {
            _appDbContext.Update(track);
            _appDbContext.SaveChanges();
        }
    }
}
