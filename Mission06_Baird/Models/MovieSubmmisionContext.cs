using Microsoft.EntityFrameworkCore;
using Mission07_Baird.Models;

namespace Mission06_Baird.Models
{
    public class MovieSubmmisionContext : DbContext
    {
        public MovieSubmmisionContext(DbContextOptions<MovieSubmmisionContext> options) : base (options)
        { 
        }

        public DbSet<MovieSubmission> Submissions { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Seed Data
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Television" },
                new Category { CategoryId = 4, CategoryName = "Horror/Suspence" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 8, CategoryName = "VHS" }

            );
        }
    }
}