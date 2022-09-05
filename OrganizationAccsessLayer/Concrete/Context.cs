using Microsoft.EntityFrameworkCore;
using OrganizationEntityLayer.Event;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationAccsessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ASES;database=OrganizationDb;integrated security=true;");

        }

        
        public DbSet<Company> Company { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Subcontractor> Subcontractors { get; set; }
       public DbSet<Admin> Admins { get; set; }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<SubconEvent> SubconEvents { get; set; }
        public DbSet<OrganEvent> OrganEvents { get; set; }
        public DbSet<CompanyEvent> CompanyEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
       
            modelBuilder.Entity<SubconEvent>().HasKey(x => new { x.EventId, x.SubcontractorMail });

            modelBuilder.Entity<OrganEvent>().HasKey(x => new { x.EventId, x.OrganizerMail });
            modelBuilder.Entity<CompanyEvent>().HasKey(x => new { x.EventId, x.CompanyName });

        }

        

    }
}
