using AutoMapper;
using MusicLibraryAPI.Model;
using MusicLibraryAPI.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Profiles
{
    public class TrackProfile : Profile
    {
        public TrackProfile()
        {
            CreateMap<Track, TrackDTO>()
                .ForMember(
                    dest => dest.ArtistId, 
                    act => act.MapFrom(src => src.Album.ArtistId)
                 );
        }
    }
}
