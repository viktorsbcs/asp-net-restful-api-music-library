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
    [Route("api/albums")]
    public class AlbumsController : Controller
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly IMapper _mapper;

        public AlbumsController(IAlbumRepository albumRepository, IMapper mapper)
        {
            this._albumRepository = albumRepository;
            this._mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult GetAlbum(long id)
        {
            var album = _albumRepository.GetAlbum(id);

            if (album == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AlbumDTO>(album));
        }

        [HttpGet]
        public ActionResult<IEnumerable<AlbumDTO>> GetAlbums()
        {
            var albums = _albumRepository.GetAllAlbums;
            if (albums == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<AlbumDTO>>(albums));
        }
        


    }
}