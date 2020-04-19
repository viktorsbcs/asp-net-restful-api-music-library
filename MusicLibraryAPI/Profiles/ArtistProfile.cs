using AutoMapper;
using MusicLibraryAPI.Model;
using MusicLibraryAPI.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Profiles
{
    public class ArtistProfile : Profile
    {
        public ArtistProfile()
        {
            CreateMap<Artist, ArtistDTO>();
            CreateMap<ArtistCreateDTO, Artist>();
        }
    }
}
