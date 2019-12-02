using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OneToMany.DAL.Models;
using OneToMany.DAL.Configurations;

namespace OneToMany
{
    class dbContext : DbContext
    {
        public dbContext() : base("OneToManyDb")
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GroupConfig());
            modelBuilder.Configurations.Add(new StudentConfig());
        }
    }
}

