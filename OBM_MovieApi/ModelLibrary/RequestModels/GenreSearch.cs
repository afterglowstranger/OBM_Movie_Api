using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.RequestModels
{
    public class GenreSearch
    {
        public string sortOrder { get; set; } = string.Empty;
        public string genre { get; set; } = string.Empty;
        public string currentFilter { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
