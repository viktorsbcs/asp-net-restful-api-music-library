using Microsoft.EntityFrameworkCore;
using MusicLibraryAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Track> Tracks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Rock"
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Metal"
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Pop"
                },

                new Category()
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Classic"
                }

           );
        }
    }
}
