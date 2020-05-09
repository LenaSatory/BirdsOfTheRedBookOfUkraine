using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class ArealUA
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int SpeciesId { get; set; }

        public virtual Region Region { get; set; }
        public virtual Species Species { get; set; }
    }
}
