using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Fifapub.Models.Repository
{
    public class EFDBContext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Winner> Winners { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
    }
}