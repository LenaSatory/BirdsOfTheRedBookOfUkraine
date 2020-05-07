using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class BirdPhotos
    {
        public int IdBirdPhoto { get; set; }
        public int IDSpecies { get; set; }
        public int IDSex { get; set; }
        public byte[] Img { get; set; }
        public string ImageMimeType { get; set; }
        public string Copyright { get; set; }

        public virtual Species Species { get; set; }
        public virtual Sex Sex { get; set; }
    }
}
