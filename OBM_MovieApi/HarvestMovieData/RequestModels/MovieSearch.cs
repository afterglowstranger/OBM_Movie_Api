using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestMovieData.RequestModels
{
    public class MovieSearch
    {
        public string sortOrder { get; set; } = string.Empty;
        public string searchString { get; set; } = string.Empty;
        public string currentFilter { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
        

        //string sortOrder, string currentFilter,  string searchString,  int? page,  int? pagesize=10
    }
}
