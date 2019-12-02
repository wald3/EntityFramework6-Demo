using ManyToMany.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace ManyToMany.DAL.Configurations
{
    class BookConfig : EntityTypeConfiguration<Book>
    {
        public BookConfig()
        {
            this.HasMany(b => b.Authors)
                .WithMany(a => a.Books);
        }
    }
}
