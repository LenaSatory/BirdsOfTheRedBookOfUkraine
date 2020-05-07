using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class ArealsUA
    {
        public ArealsUA()
        {
            Species = new List<Species>();
        }

        public int IdArealUA { get; set; }
        public int IDRegion { get; set; }

        public virtual Regions Region { get; set; }

        public virtual ICollection<Species> Species { get; set; }
    }
}
