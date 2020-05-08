using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Genus
    {
        public Genus()
        {
            Specieses = new List<Species>();
        }

        public int Id { get; set; }
        public int FamilyId { get; set; }
        public string ScientificName { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }

        public virtual Family Family { get; set; }

        public virtual ICollection<Species> Specieses { get; set; }
    }
}
