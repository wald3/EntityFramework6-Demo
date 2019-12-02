using DemoDb.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DemoDb.DAL.Configurations
{
    class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            this.HasKey(a => a.Id);
        }
    }
}
