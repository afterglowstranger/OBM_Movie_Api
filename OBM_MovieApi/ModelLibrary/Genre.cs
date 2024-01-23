using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        
        [ForeignKey("GenreId")]
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
