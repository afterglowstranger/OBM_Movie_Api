using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorName { get; set; } = string.Empty;
        public string ProfilePath { get; set; }
        public int Gender {  get; set; }

        [ForeignKey("ActorId")]
        public ICollection<Casting> Castings { get; set; }
    }
}
