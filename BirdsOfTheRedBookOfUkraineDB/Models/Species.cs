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
            BirdPhotos = new List<BirdPhotos>();
        }

        public int IdSpecies { get; set; }
        public int IDGenus { get; set; }
        public string ScientificName { get; set; }
        public string UkrName { get; set; }
        public string EngName { get; set; }
        public int IDArealUA { get; set; }
        public string Description { get; set; }

        public int IDStatus { get; set; }
        public string VoiceURL { get; set; }
        public string IUCN_URL { get; set; }

        public virtual Genuses Genus { get; set; }
        public virtual Statuses Status { get; set; }
        public virtual ArealsUA ArealUA { get; set; }

        public virtual ICollection<BirdPhotos> BirdPhotos { get; set; }
    }
}
