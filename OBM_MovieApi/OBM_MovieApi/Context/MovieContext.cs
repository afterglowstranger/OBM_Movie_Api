using Microsoft.EntityFrameworkCore;
using ModelLibrary;


namespace OBM_MovieApi.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options): base(options)
        {
                
        }

        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Actor> Actors { get; set; } = null!;

        public DbSet<Casting> Castings { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        public DbSet<MovieGenre> MovieGenres { get; set; } = null!;
    }
}
