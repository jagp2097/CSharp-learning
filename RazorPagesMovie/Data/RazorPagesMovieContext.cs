using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data 
{
    // This code creates a DbSet property for the entity set. 
    // In Entity Framework terminology, an entity set typically corresponds to 
    // a database table, and an entity corresponds to a row in the table. 
    public class RazorPagesMovieContext : DbContext 
    {
        public RazorPagesMovieContext (
            DbContextOptions<RazorPagesMovieContext> options) : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}