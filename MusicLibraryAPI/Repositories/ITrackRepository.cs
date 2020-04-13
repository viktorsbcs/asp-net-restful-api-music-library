using MusicLibraryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories
{
    public interface ITrackRepository
    {
        public IEnumerable<Track> Tracks { get; }
        public Track GetTrack(long id);
        public void AddTrack(Track track);
        public void UpdateTrack(Track track);
        public void DeleteTrack(long Id);
    }
}
