using System.Data.Entity;
using DemoDb.DAL.Models;
using DemoDb.DAL.Configurations;

namespace DemoDb.DAL.Context
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("_DemoDb")
        { }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ShopConfig());
            modelBuilder.Configurations.Add(new AdminConfig());
            modelBuilder.Configurations.Add(new CustomerConfig());
            modelBuilder.Configurations.Add(new AddressConfig());
            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new OrderConfig());
        }
    }
}
