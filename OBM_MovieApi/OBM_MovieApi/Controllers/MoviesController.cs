using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModelLibrary;
using ModelLibrary.RequestModels;
using OBM_MovieApi.Interfaces;
using X.PagedList;
//using System.Web.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OBM_MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly ILogger<MoviesController> _logger;

        private IActorRepository _actorRepository;
        private IMovieRepository _movieRepository;

        public MoviesController(ILogger<MoviesController> logger, IMovieRepository movieRepository, IActorRepository actorRepository)
        {
            _logger = logger;
            _actorRepository = actorRepository;
            _movieRepository = movieRepository;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movie> Index(int movieLimit)
        {
            var page = 1;
            
            //var movies = from m in _movieRepository.GetAll().Where(x => x.Poster_Url != "").Take(5)
            //               select m;

            var movies = from m in _movieRepository.GetMovies(movieLimit) select m;

            //foreach (var movie in movies)
            //{
            //    movie.LeadingActors = _actorRepository.GetTopnActorsForMovie(movie.Id.ToString(), 5);
            //}

            return movies;
            
        }

        // POST: api/<MoviesController>
        [HttpPost, ActionName("SearchFilms")]
        public IEnumerable<Movie> Post([FromBody] MovieSearch movieSearch)
        {
            var pageSize = movieSearch.pageSize == 0 ? 10 : movieSearch.pageSize;
            var skipVal = movieSearch.page == null ? 1 : movieSearch.page;
            skipVal = (skipVal - 1) * movieSearch.pageSize;
                        
            //var movies =  from m in _movieRepository.Find(m => m.Title.ToUpper().Contains(movieSearch.searchString.ToUpper()))
            //              select m;
            var movies = from m in _movieRepository.GetMoviesByTitleName(movieSearch.searchString) select m;

            

            switch (movieSearch.sortOrder)
            {
                case "title_asc":
                    movies = movies.OrderBy(m => m.Title);
                    break;
                case "title_desc":
                    movies = movies.OrderByDescending(m => m.Title);
                    break;
                case "date_asc":
                    movies = movies.OrderBy(m => m.Release_Date);
                    break;
                case "date_desc":
                    movies = movies.OrderByDescending(m => m.Release_Date);
                    break;
                default:  // Name ascending 
                    movies = movies.OrderBy(m => m.Title);
                    break;
            }

            movies = from m in movies.Skip((int)skipVal).Take(pageSize).ToList() select m;


            return movies;

        }

        // POST: api/<MoviesController>
        [HttpPost, Route("SearchActors")]
        public IEnumerable<Movie> PostActor([FromBody] MovieSearch search)
        {
            var pageSize = search.pageSize == 0 ? 10 : search.pageSize;
            var skipVal = search.page == null ? 1 : search.page;
            skipVal = (skipVal - 1) * search.pageSize;

            var movies = from m in _movieRepository.GetMoviesByActorName(search.searchString) select m;

            

            switch (search.sortOrder)
            {
                case "title_asc":
                    movies = movies.OrderBy(m => m.Title);
                    break;
                case "title_desc":
                    movies = movies.OrderByDescending(m => m.Title);
                    break;
                case "date_asc":
                    movies = movies.OrderBy(m => m.Release_Date);
                    break;
                case "date_desc":
                    movies = movies.OrderByDescending(m => m.Release_Date);
                    break;
                default:  // Name ascending 
                    movies = movies.OrderBy(m => m.Title);
                    break;
            }

            movies = from m in movies.Skip((int)skipVal).Take(pageSize).ToList() select m;

            return movies;

        }

        // POST: api/<MoviesController>
        [HttpPost, Route("SearchGenre")]
        public IEnumerable<Movie> PostGenre([FromBody] GenreSearch search)
        {
            var pageSize = search.pageSize == 0 ? 10 : search.pageSize;
            var skipVal = search.page == null ? 1 : search.page;
            skipVal = (skipVal - 1) * search.pageSize;

            var movies = from m in _movieRepository.GetMoviesByGenre(search.genre) select m;
            
            

            switch (search.sortOrder)
            {
                case "title_asc":
                    movies = movies.OrderBy(m => m.Title);
                    break;
                case "title_desc":
                    movies = movies.OrderByDescending(m => m.Title);
                    break;
                case "date_asc":
                    movies = movies.OrderBy(m => m.Release_Date);
                    break;
                case "date_desc":
                    movies = movies.OrderByDescending(m => m.Release_Date);
                    break;
                default:  // Name ascending 
                    movies = movies.OrderBy(m => m.Title);
                    break;
            }

            movies = from m in movies.Skip((int)skipVal).Take(pageSize).ToList() select m;

            return movies;

        }
    }
}
