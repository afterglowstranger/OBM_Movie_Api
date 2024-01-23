using ModelLibrary;

namespace OBM_MovieApi.Interfaces
{
    public interface IMovieRepository :IGenericRepository<Movie>
    {
        public IEnumerable<Movie> GetMovies(int? movieLimit);
        public IEnumerable<Movie> GetMoviesByTitleName(string SearchString);
        public IEnumerable<Movie> GetMoviesByActorName(string ActorSearchString);
        public IEnumerable<Movie> GetMoviesByGenre(string Genre);
    }
}
