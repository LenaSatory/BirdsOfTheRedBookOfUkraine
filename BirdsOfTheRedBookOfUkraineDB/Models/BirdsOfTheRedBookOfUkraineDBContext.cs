using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class BirdsOfTheRedBookOfUkraineDBContext : DbContext
    {
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Families> Families { get; set; }
        public virtual DbSet<Genuses> Genuses { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<ArealsUA> ArealsUA { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<BirdPhotos> BirdPhotos { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }

        public BirdsOfTheRedBookOfUkraineDBContext(DbContextOptions<BirdsOfTheRedBookOfUkraineDBContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
