using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestMovieData.Models
{
    internal class MovieCastCrew
    {
        public int Id { get; set; }
        public Cast[] Cast {  get; set; }= new Cast[0];
        public Crew[] Crew { get; set; } = new Crew[0];
    }
}
