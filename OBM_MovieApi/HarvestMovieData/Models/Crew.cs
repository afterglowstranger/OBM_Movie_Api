using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestMovieData.Models
{
    internal class Crew
    {
        //{'credit_id': '572e2522c3a36869e6001a9c', 'department': 'Visual Effects', 'gender': 0, 'id': 7949, 'job': 'CG Painter', 'name': 'Robin Cooper', 'profile_path': None}
        public string credit_id { get; set; }
        public string department { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public string job { get; set; }
        public string name { get; set; }
        public string profile_path { get; set; } = string.Empty;
    }
}
