using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Species
    {
        public Species()
        {
            BirdPhotos = new List<BirdPhoto>();
        }

        public int Id { get; set; }
        public int GenusId { get; set; }
        public string ScientificName { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }
        public int ArealUAId { get; set; }
        public string Description { get; set; }

        public int StatusId { get; set; }
        public string VoiceURL { get; set; }
        public string IUCN_URL { get; set; }

        public virtual Genus Genus { get; set; }
        public virtual Status Status { get; set; }
        public virtual ArealUA ArealUA { get; set; }

        public virtual ICollection<BirdPhoto> BirdPhotos { get; set; }
    }
}
