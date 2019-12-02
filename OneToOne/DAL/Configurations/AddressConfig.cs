using OneToOne.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace OneToOne.DAL.Configurations
{
    class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            this.HasKey(ad => ad.Id);
        }
    }
}
