using Microsoft.EntityFrameworkCore;

namespace Mission06_Baird.Models
{
    public class MovieSubmmisionContext : DbContext
    {
        public MovieSubmmisionContext(DbContextOptions<MovieSubmmisionContext> options) : base (options)
        { 
        }

        public DbSet<MovieSubmission> Submissions { get; set; }
    }
}