using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OneToOne.DAL.Models;
using OneToOne.DAL.Configurations;

namespace OneToOne.DAL
{
    class AppContext : DbContext
    {
        public AppContext() : base("OneToOneDb")
        { }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }


        // Note:
        // One-to-one relationships are technically not possible in MS SQL Server.
        // These will always be one-to-zero-or-one relationships. 
        // EF forms One-to-One relationships on entities not in the DB.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressConfig());
            modelBuilder.Configurations.Add(new PersonConfig());
        }
    }
}
