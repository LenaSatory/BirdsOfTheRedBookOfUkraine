using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Families
    {
        public Families()
        {
            Genuses = new List<Genuses>();
        }

        public int IdFamily { get; set; }
        public int IDOrder { get; set; }
        public string ScientificName { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual ICollection<Genuses> Genuses { get; set; }
    }
}
