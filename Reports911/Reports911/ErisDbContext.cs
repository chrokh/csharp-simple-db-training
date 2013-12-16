using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Reports911
{
    class ErisDbContext : DbContext
    {
        public DbSet<Emt> emts { get; set; }
        public DbSet<Incident> incidents { get; set; }
        public DbSet<BaseStation> basestations { get; set; }

        public ErisDbContext()
        {
            Database.SetInitializer<ErisDbContext>(new DropCreateDatabaseAlways<ErisDbContext>());
            emts.ToList(); // touch to force eager creation
        }
    }

    
    class Emt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BaseStation BaseStation { get; set; }
        public ICollection<Incident> Incidents { get; set; }
    }

    class Incident
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public ICollection<Emt> Emts { get; set; }
    }

    class BaseStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Emt> Emts { get; set; }
    }
}
