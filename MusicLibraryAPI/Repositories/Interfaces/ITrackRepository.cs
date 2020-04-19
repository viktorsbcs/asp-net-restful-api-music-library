using MusicLibraryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories.Interfaces
{
    public interface ITrackRepository
    {
        public IEnumerable<Track> GetAllTracks { get; }
        public Track GetTrack(long id);
        public void CreateTrack(Track track);
        public void UpdateTrack(Track track);
        public void DeleteTrack(long id);
        public IEnumerable<Track> GetTracksByAlbumTitle(string albumTitle);
    }
}
