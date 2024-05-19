using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace Laboratory_2.Data.Models.Data
{
    public class ApplicationContext : DbContext
    {

        public DbSet<EPatient> Patients { get; set; }
        public DbSet<EDoctor> Doctors { get; set; }
        public DbSet<ENurse> Nurses { get; set; }
        public DbSet<ETreatment> Treatments { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=123321456654789987;database=hospital",
            version => version.ServerVersion(new Version(8, 0, 3), ServerType.MySql));
        }
    }
}
