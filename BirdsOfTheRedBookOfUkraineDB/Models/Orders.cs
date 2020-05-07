using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Orders
    {
        public Orders()
        {
            Families = new List<Families>();
        }

        public int IdOrder { get; set; }
        public string ScientificName { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }

        public virtual ICollection<Families> Families { get; set; }
    }
}
