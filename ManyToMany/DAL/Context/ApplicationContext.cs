using ManyToMany.DAL.Configurations;
using ManyToMany.DAL.Models;
using System.Data.Entity;

namespace ManyToMany.DAL.Context
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ManyToManyDb")
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookConfig());
            modelBuilder.Configurations.Add(new AuthorConfig());
        }
    }
}
