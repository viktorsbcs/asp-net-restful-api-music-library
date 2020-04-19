using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.Model;
using MusicLibraryAPI.Model.DTO;
using MusicLibraryAPI.Repositories;
using MusicLibraryAPI.Repositories.Interfaces;

namespace MusicLibraryAPI.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this._categoryRepository = categoryRepository;
            this._mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public ActionResult<CategoryDTO> GetCategory(long id)
        {
            var category = _categoryRepository.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryDTO>(category));
        }



        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categories = _categoryRepository.GetAllCategories;

            if (categories == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<CategoryDTO>>(categories));
        }

        [HttpPost]
        public void CreateCategory(CategoryCreateDTO categoryDto)
        {
            if(categoryDto == null)
            {
                throw new FileNotFoundException();
            }

            var category = _mapper.Map<Category>(categoryDto);
            _categoryRepository.CreateCategory(category);

            
            
        }
    }
}