using Microsoft.EntityFrameworkCore;
using ModelLibrary;
using MySqlConnector;
using OBM_MovieApi.Context;
using OBM_MovieApi.Interfaces;
using System;


namespace OBM_MovieApi.Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieContext context) : base(context)
        {
        }

        public IEnumerable<Movie> GetMovies(int? movieLimit = 10)
        {
            var movie = new MySqlParameter("p_Limit", movieLimit );

            return _context.Movies.FromSqlInterpolated($"Call GetMovies ({movie})").ToList();
        }

        public IEnumerable<Movie> GetMoviesByTitleName(string SearchString)
        {
            var movie = new MySqlParameter("p_MovieName", SearchString);

            return _context.Movies.FromSqlInterpolated($"Call MoviesByTitleSearch ({movie})").ToList();
        }

        public IEnumerable<Movie> GetMoviesByActorName(string ActorSearchString)
        {
            var actor = new MySqlParameter("p_ActorName", ActorSearchString);

            return _context.Movies.FromSqlInterpolated($"Call MoviesByActorSearch ({actor})").ToList();
        }


        public IEnumerable<Movie> GetMoviesByGenre(string Genre)
        {
            var genre = new MySqlParameter("p_Genre", Genre);

            return _context.Movies.FromSqlInterpolated($"Call SearchMovieByGenre ({genre})").ToList();
        }


    }
}
