using DemoDb.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DemoDb.DAL.Configurations
{
    class ShopConfig : EntityTypeConfiguration<Shop>
    {
        public ShopConfig()
        {
            this.HasMany<Product>(s => s.Products)
                .WithRequired(p => p.Shop)
                .HasForeignKey(p => p.ShopId);

            this.HasRequired<Address>(s => s.Address);

            this.HasRequired<Admin>(s => s.Admin);
        }
    }
}
