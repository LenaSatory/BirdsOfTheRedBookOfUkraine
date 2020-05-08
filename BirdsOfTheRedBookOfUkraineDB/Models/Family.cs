using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Family
    {
        public Family()
        {
            Genuses = new List<Genus>();
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ScientificName { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }

        public virtual Order Order { get; set; }

        public virtual ICollection<Genus> Genuses { get; set; }
    }
}
