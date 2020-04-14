using MusicLibraryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Categories { get; }
        public Category GetCategory(long id);
        public void CreateCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(long Id);
    }
}
