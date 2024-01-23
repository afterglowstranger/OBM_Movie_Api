using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly? Release_Date { get; set; }
        public string Title { get; set; }
        public string? Overview { get; set; }
        public decimal? Popularity { get; set; }
        public int? Vote_Count { get; set; }

        public decimal? Vote_Average { get; set; }
        public string? Original_Language { get; set; }

        public int? MovieIdInt { get; set; }

        public string? Genre { get; set; } = string.Empty;
        public string? Poster_Url { get; set; } = string.Empty;
        //[NotMapped]
        public string? LeadingActors { get; set; } 

        

        [ForeignKey("MovieId")]
        public ICollection<Casting> Castings { get; set; }


        [ForeignKey("MovieId")]
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
