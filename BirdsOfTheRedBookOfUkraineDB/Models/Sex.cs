using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Sex
    {
        public Sex()
        {
            BirdPhotos = new List<BirdPhotos>();
        }

        public int IdSex { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BirdPhotos> BirdPhotos { get; set; }
    }
}
