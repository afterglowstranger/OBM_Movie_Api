using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Casting
    {
        [Key]
        public int id {  get; set; }
        public string CharacterName { get; set; } = null!;
        public int ActorId { get; set; }
        public Guid MovieId { get; set; }
        
        public int BillingOrder { get; set; }

        public Actor Actor { get; set; }
        public Movie Movie { get; set; }


        
    }
}
