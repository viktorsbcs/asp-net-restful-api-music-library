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
    [ApiController]
    [Route("api/tracks")]
    public class TracksController : Controller
    {
        private readonly ITrackRepository _trackRepository;
        private readonly IMapper _mapper;

        public TracksController(ITrackRepository trackRepository, IMapper mapper)
        {
            this._trackRepository = trackRepository;
            this._mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<TrackDTO> GetTrack(long id)
        {
            var track = _trackRepository.GetTrack(id);

            if (track == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TrackDTO>(track));
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<TrackDTO>> GetTracks()
        {
            var tracks = _trackRepository.GetAllTracks;
            if (tracks == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<TrackDTO>>(tracks));
        }

        //[HttpGet]
        public ActionResult<IEnumerable<TrackDTO>> GetTracksByAlbumTitle([FromQuery] string albumTitle)
        {
            var tracks = _trackRepository.GetTracksByAlbumTitle(albumTitle);
            return Ok(_mapper.Map<IEnumerable<TrackDTO>>(tracks));
        }
    }
}