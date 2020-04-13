using MusicLibraryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Categories { get; }
        public Category GetCategory(long id);
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(long Id);
    }
}
