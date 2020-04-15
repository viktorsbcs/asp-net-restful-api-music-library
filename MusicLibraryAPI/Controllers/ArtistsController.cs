using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.Model.DTO;
using MusicLibraryAPI.Repositories.Interfaces;

namespace MusicLibraryAPI.Controllers
{

    //ControllerBase is not including Views which are unnecessary for API


    [ApiController]
    [Route("api/artists")]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;

        public ArtistsController(IArtistRepository artistRepository, IMapper mapper)
        {
            this._artistRepository = artistRepository;
            this._mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ArtistDTO>> GetArtists()
        {
            var artists = _artistRepository.GetAllArtists;

            if(artists == null)
            {
                return NotFound();
            }

            var artistsDto =_mapper.Map<IEnumerable<ArtistDTO>>(artists);
            return Ok(artistsDto);

            
        }

        [HttpGet("{id}")]
        public ActionResult<ArtistDTO> GetArtist(long id)
        {
            var artist = _artistRepository.GetArtist(id);

            if (artist == null)
            {
                return NotFound();
            }

            var artistDto = _mapper.Map<ArtistDTO>(artist);
            return Ok(artistDto);
        }
    }
}