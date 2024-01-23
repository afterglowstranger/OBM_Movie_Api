using Microsoft.AspNetCore.Mvc;
using ModelLibrary;
using ModelLibrary.RequestModels;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace SimpleFrontend.Controllers
{
    //[Route("[controller]")]
    public class MovieViewController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7029/api");

        private readonly HttpClient _httpClient;

        public MovieViewController()
        {
                _httpClient = new HttpClient();
                _httpClient.BaseAddress = baseAddress;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>();
            HttpResponseMessage response = _httpClient.GetAsync(baseAddress + "/Movies?movieLimit=10").Result;

            if(response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<Movie>>(data);
            }

            return View(movies);
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult Index([FromForm] MovieSearch movieSearch)
        {
            List<Movie> movies = new List<Movie>();

            ViewBag.Page = movieSearch.page +1 ;
            ViewBag.SearchTerm = movieSearch.searchString;
            ViewBag.PageSize=movieSearch.pageSize;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(movieSearch);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            var queryString = JsonConvert.SerializeObject(movieSearch);
                
            HttpResponseMessage response = _httpClient.PostAsync(baseAddress + "/Movies", content).Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<Movie>>(data);
            }

            return View(movies);
        }

        [Route("[action]")]
        [HttpPost, Route("SearchActors")]
        public IActionResult SearchMoviesByActorName([FromForm] MovieSearch movieSearch)
        {
            List<Movie> movies = new List<Movie>();

            ViewBag.Page = movieSearch.page + 1;
            ViewBag.SearchTerm = movieSearch.searchString;
            ViewBag.PageSize = movieSearch.pageSize;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(movieSearch);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            HttpResponseMessage response = _httpClient.PostAsync(baseAddress + "/Movies/SearchActors", content).Result;
            //https://localhost:7029/api/Movies/SearchActors

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<Movie>>(data);
            }

            return View("Index", movies);
        }

        [Route("[action]")]
        [HttpPost, Route("SearchGenre")]
        public IActionResult SearchMoviesByGenre([FromForm] GenreSearch genreSearch)
        {
            List<Movie> movies = new List<Movie>();

            ViewBag.Page = genreSearch.page + 1;
            ViewBag.Genre = genreSearch.genre;
            ViewBag.PageSize = genreSearch.pageSize;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(genreSearch);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = _httpClient.PostAsync(baseAddress + "/Movies/SearchGenre", content).Result;
            //https://localhost:7029/api/Movies/SearchActors

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject<List<Movie>>(data);
            }

            return View("Index", movies);
        }
    }
}
