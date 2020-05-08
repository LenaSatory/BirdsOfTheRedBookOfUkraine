using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class ArealUA
    {
        public ArealUA()
        {
            Species = new List<Species>();
        }

        public int Id { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }

        public virtual ICollection<Species> Species { get; set; }
    }
}
