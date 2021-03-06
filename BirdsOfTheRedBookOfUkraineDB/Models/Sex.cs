﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class Sex
    {
        public Sex()
        {
            BirdPhotos = new List<BirdPhoto>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BirdPhoto> BirdPhotos { get; set; }
    }
}
