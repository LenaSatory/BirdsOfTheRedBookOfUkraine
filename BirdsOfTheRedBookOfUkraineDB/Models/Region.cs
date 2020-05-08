using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Region
    {
        public Region()
        {
            ArealUAs = new List<ArealUA>();
        }

        public int Id { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }

        public virtual ICollection<ArealUA> ArealUAs { get; set; }
    }
}
