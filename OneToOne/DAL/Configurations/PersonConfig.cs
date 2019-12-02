using OneToOne.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace OneToOne.DAL.Configurations
{
    class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            this.HasRequired(p => p.Address)
                .WithOptional(ad => ad.Person);
        }
    }
}
