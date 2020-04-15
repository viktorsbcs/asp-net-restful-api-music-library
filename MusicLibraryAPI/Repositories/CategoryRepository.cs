using MusicLibraryAPI.DbContexts;
using MusicLibraryAPI.Model;
using MusicLibraryAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories.ToList();

        public void CreateCategory(Category category)
        {
            _appDbContext.Add(category);
            _appDbContext.SaveChanges();
        }

        public void DeleteCategory(long id)
        {
            var category = _appDbContext.Categories.Find(id);
            _appDbContext.Remove(category);
            _appDbContext.SaveChanges();
        }

        public Category GetCategory(long id)
        {
            return _appDbContext.Categories.Find(id);
        }

        public void UpdateCategory(Category category)
        {
            _appDbContext.Update(category);
            _appDbContext.SaveChanges();
        }
    }
}
