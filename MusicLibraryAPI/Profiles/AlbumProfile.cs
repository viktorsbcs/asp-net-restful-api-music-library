using AutoMapper;
using MusicLibraryAPI.Model;
using MusicLibraryAPI.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Profiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<Album, AlbumDTO>()
                .ForMember(
                    dest => dest.Tracks,
                    act => act.MapFrom(src=>src.Tracks.Select(x=> new TrackMinimalDTO() { Id = x.Id, TrackTitle = x.TrackTitle, TrackDuration = x.TrackDuration }))
                );

            CreateMap<AlbumCreateDTO, Album>();
                
        }
    }
}
