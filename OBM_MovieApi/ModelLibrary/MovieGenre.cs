using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class MovieGenre
    {
        [Key]
        public Guid Id { get; set; }
        public Guid GenreId { get; set; }
        public Guid MovieId { get; set; }

        public Genre Genre { get; set; }
        public Movie Movie { get; set; }
    }
}
