using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Genuses
    {
        public Genuses()
        {
            Species = new List<Species>();
        }

        public int IdGenus { get; set; }
        public int IDFamily { get; set; }
        public string ScientificName { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }

        public virtual Families Family { get; set; }

        public virtual ICollection<Species> Species { get; set; }
    }
}
