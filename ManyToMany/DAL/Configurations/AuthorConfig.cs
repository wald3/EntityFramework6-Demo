using ManyToMany.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace ManyToMany.DAL.Configurations
{
    class AuthorConfig : EntityTypeConfiguration<Author>
    {
        public AuthorConfig()
        {
            this.HasMany(a => a.Books)
                .WithMany(b => b.Authors);
        }
    }
}
