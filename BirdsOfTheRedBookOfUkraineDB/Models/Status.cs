using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Status
    {
        public Status()
        {
            Specieses = new List<Species>();
        }

        public int Id { get; set; }
        public string RBCategoriesName { get; set; }

        public virtual ICollection<Species> Specieses { get; set; }
    }
}
