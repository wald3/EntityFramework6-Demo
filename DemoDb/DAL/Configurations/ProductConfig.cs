using DemoDb.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DemoDb.DAL.Configurations
{
    class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            this.HasRequired<Shop>(p => p.Shop)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.ShopId);

            this.HasMany(p => p.Orders)
                .WithRequired(o => o.Product)
                .HasForeignKey(o => o.ProductId);
        }
    }
}
