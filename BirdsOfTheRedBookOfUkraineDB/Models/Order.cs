using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Order
    {
        public Order()
        {
            Families = new List<Family>();
        }

        public int Id { get; set; }
        public string ScientificName { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }

        public virtual ICollection<Family> Families { get; set; }
    }
}
