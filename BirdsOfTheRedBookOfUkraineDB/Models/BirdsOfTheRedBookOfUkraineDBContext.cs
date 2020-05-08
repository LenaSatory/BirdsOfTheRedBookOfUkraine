using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace BirdsOfTheRedBookOfUkraineDB.Models
{
    public class BirdsOfTheRedBookOfUkraineDBContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<Genus> Genuses { get; set; }
        public virtual DbSet<Species> Specieses { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<ArealUA> ArealUAs { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<BirdPhoto> BirdPhotos { get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }

        public BirdsOfTheRedBookOfUkraineDBContext(DbContextOptions<BirdsOfTheRedBookOfUkraineDBContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
