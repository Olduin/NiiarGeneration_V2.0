using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NiiarGeneration.Models;
using SQLite.CodeFirst;

namespace NiiarGeneration
{
    public class ApplicatDbContext : DbContext
    {
        public ApplicatDbContext()
           : base("Name=ApplicatDbContext")
        {
            //Database.SetInitializer(new DBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new DBInitializer(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public DbSet<TypeApplicat> TypeApplicates { get; set; }
        public DbSet<Vehicle> Vehincles { get; set; }
        public DbSet<Applicat> Applicats { get; set; }
        public DbSet<ApplicatItem> ApplicatItems { get; set; }
        public DbSet<TypeWork> TypeWorks { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
