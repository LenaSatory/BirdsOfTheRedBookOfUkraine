using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Regions
    {
        public Regions()
        {
            ArealsUA = new List<ArealsUA>();
        }

        public int IdRegion { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }

        public virtual ICollection<ArealsUA> ArealsUA { get; set; }
    }
}
